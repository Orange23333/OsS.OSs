using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 字体加载器。
	/// </summary>
	public static class FontLoader
	{
		/// <summary>
		/// 以字体类为目标进行加载。
		/// </summary>
		/// <param name="font">字体。</param>
		/// <returns>预加载好从空格' '到波浪线'~'的所有字符的字体缓存。</returns>
		public static FontCache LoadFromFontClass(Font font)//或者把字体的名称字符串作为参数？
		{
			int i;
			FontCache r = new FontCache(font);
			for(i=' '; i <= '~'; i++)
			{
				r.PreLoad((char)i);
			}
			return r;
		}
	}
}
