using System;

namespace OsS.OSs.TypeOS
{
	/// <summary>
	/// 程序。
	/// </summary>
	public class Program
	{
		/// <summary>
		/// 主函数。
		/// </summary>
		/// <param name="args">启动参数。</param>
		static void Main(string[] args)
		{
			MyConsole.Initialze();

			Info.PrintAll();
		}
	}
}
