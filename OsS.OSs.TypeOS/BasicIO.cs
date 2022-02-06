using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 基础输入输出。
	/// </summary>
	public static class BasicIO
	{
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		/// <summary>
		/// 获取控制台窗口的Graphic。
		/// </summary>
		public static Graphics GetConsole()
		{
			return Graphics.FromHwnd(GetConsoleWindow());
		}
	}
}
