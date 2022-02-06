using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 字体缓存。
	/// </summary>
	public class FontCache
	{
		private Font font;
		/// <summary>
		/// 所用字体。
		/// </summary>
		public Font Font { get { return (Font)(font.Clone()); } }
		//private string name; //可以是源字体名称，也可以是新字体（不一定存在，可以是多个已有字体或是自造字体组合的）。
		private Dictionary<char, Bitmap> fontBitmaps;

		/// <summary>
		/// 字体缓存图像字典。
		/// </summary>
		/// <param name="character">目标字符。</param>
		/// <returns>对应的字符图像。</returns>
		public Bitmap this[char character]
		{
			get
			{
				if(fontBitmaps.TryGetValue(character, out Bitmap _cacheBitmap))
				{
					return _cacheBitmap;
				}
				else
				{
					return PreLoad(character);
				}
			}
			set
			{
				if (fontBitmaps.TryAdd(character, value))
				{
					fontBitmaps[character] = value;
				}
			}
		}

		/// <summary>
		/// 预加载字符。
		/// </summary>
		/// <param name="character">目标字符。</param>
		/// <param name="forced">降至重新缓存，默认值为false。（即使字符已经缓存也重新缓存）</param>
		/// <returns>对应的字符图像。</returns>
		public Bitmap PreLoad(char character, bool forced = false)
		{
			Bitmap r;
			if (fontBitmaps.TryGetValue(character, out r))
			{
				if (forced)
				{
					r = ToBitmap(this.font, character);
					fontBitmaps[character] = r;
				}
				return r;
			}
			else
			{
				r = ToBitmap(this.font, character);
				fontBitmaps.Add(character, r);
				return r;
			}
		}
		/// <summary>
		/// 获取字符的图像。
		/// </summary>
		/// <param name="font">字体。</param>
		/// <param name="character">目标字符。</param>
		/// <returns>对应的字符图像。</returns>
		public static Bitmap ToBitmap(Font font, char character)
		{
			Bitmap bitmap = new Bitmap(1, 1);
			Graphics graphics = Graphics.FromImage(bitmap);
			StringFormat stringFormat = new StringFormat(StringFormatFlags.NoClip | StringFormatFlags.NoWrap | StringFormatFlags.NoFontFallback);
			SizeF measureSize = graphics.MeasureString(character.ToString(), font, SizeF.Empty, stringFormat);

			bitmap.Dispose();
			graphics.Dispose();
			Rectangle size = new Rectangle(0, 0, (int)Math.Ceiling(measureSize.Width), (int)Math.Ceiling(measureSize.Height));
			bitmap = new Bitmap(size.Width, size.Height);
			graphics = Graphics.FromImage(bitmap);

			//使用ClearType字体功能
			graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(0,0,0,0)), size);
			graphics.DrawString(character.ToString(), font, Brushes.Black, size, stringFormat);

			graphics.Dispose();
			return bitmap;
		}

		/// <summary>
		/// 清除缓存。
		/// </summary>
		public void ClearCache()
		{
			fontBitmaps.Clear();
		}

		/// <summary>
		/// 初始化一个空的字体缓存。
		/// </summary>
		/// <param name="font">字体。</param>
		public FontCache(Font font)
		{
			this.font = font;
			fontBitmaps = new Dictionary<char, Bitmap>();
		}
	}
}
