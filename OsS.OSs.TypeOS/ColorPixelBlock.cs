using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 彩色像素块。
	/// </summary>
	public class ColorPixelBlock
	{
		private int width;
		/// <summary>
		/// 块宽度。
		/// </summary>
		public int Width { get { return width; } }
		private int height;
		/// <summary>
		/// 块高度。
		/// </summary>
		public int Height { get { return height; } }

		private Color[][] pixels;
		/// <summary>
		/// 所有像素。
		/// </summary>
		public Color[][] Pixels { get { return (Color[][])(pixels.Clone()); } }

		public void ReSize(int width, int height)
		{
			;
		}
	}
}
