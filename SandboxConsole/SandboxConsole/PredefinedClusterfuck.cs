using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxing
{
	/// <summary>
	/// To predefine methods contain a lot of Console methods usage.
	/// </summary>
	class PredefinedClusterfuck
	{
		static MainClass main = new MainClass();

		public static void ReadSetup()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write($"{main.Username}@sandbox");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(":");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("~");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("$ ");
		}

		public static void ShowCommandList()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("== Available Commands ==");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Program:");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  quit  listcmd  clear");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Miscellaneous:");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("(Usage: <command> <args> <words>)");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  changeuser  print");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Math: ");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("(Usage: <command> <number[1] number[2] . . . number[n]>)");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  add  subtract  multiply  divide");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("");
		}
	}
}
