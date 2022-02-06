using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 控制台。
	/// </summary>
	public static class MyConsole
	{
		public static void Initialze()
		{
			ScreenBuffer.Resize;
		}
#if __GAME_GRAPHIC_
		//游戏脚本
#elif __CONSOLE_APP_
		public delegate void SizeChangedHandler(Size oldSize, Size newSize);
		public static event SizeChangedHandler OnConsoleSizeChanged;
#endif
	}
}
