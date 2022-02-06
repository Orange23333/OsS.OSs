using System;
using System.Collections.Generic;
using System.Text;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// TypeOS的（假的，仅用于游戏内的）信息集。
	/// </summary>
	public static class Info
	{
		/// <summary>
		/// 产品的名称。
		/// </summary>
		/// <remarks>
		/// TypeOS的名字是向模仿DOS即硬盘操作系统，我在想对于我而言，这个系统可能是给键盘创造的，所以叫Type（打字）OS。
		/// </remarks>
		public static readonly string ProductName = "TypeOS";

		/// <summary>
		/// 作者名称。
		/// </summary>
		public static readonly string Authors = "Orange233";

		/// <summary>
		/// 版权信息。
		/// </summary>
		public static readonly string Copyright = "Copyright (c) Orange Studio 2012";

		/// <summary>
		/// 文字图标。
		/// </summary>
		public static readonly string TextLogo =
			@"         //       " + " | " + @"  *--------------*  *------------*    *-----------* " + '\n' +
			@"   /----------\   " + " | " + @" /              / /              /  /              \" + '\n' +
			@" /           /-   " + " | " + @"*----*    *----* /   *------*   /  \      *---/    /" + '\n' +
			@"/           |     " + " | " + @"    /    /      /   /      /   /     \     \ *----* " + '\n' +
			@"|   *        \---|" + " | " + @"   /    /      /   /      /   / *----* \     \      " + '\n' +
			@"\  * * *         /" + " | " + @"  /    /      /   *------*   / /    /---*      \    " + '\n' +
			@" \  * * *       / " + " | " + @" /    /      /              /  \              /     " + '\n' +
			@"   \__________/   " + " | " + @"*----*       *------------*     *-----------*       " + '\n' +
			@" Orange Studio(R) " + " | " + @"             Type Opreation System(R)               ";

		/// <summary>
		/// 信息。
		/// </summary>
		public static readonly string Information = "A OS fot typing :)";

		/// <summary>
		/// 输出所有信息。
		/// </summary>
		public static void PrintAll()
		{
			Console.WriteLine(TextLogo);
			Console.WriteLine(Information);
			Console.WriteLine(ProductName + " made by " + Authors + ".");
			Console.WriteLine(Copyright);
		}
	}
}
