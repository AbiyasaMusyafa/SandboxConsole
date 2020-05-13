using System;

namespace SandboxConsole
{
	/// <summary>
	/// To prewritten methods contain a lot of Console methods usage.
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
			Console.WriteLine("  quit\t\tShutdown this program");
			Console.WriteLine("  listcmd\tShow every available commands");
			Console.WriteLine("  clear\t\tClear the console");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Miscellaneous:");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(">Usage: <command> <args> <words>");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  changeuser\tChange the username. Only reads one word after the command");
			Console.WriteLine("  print\t\tWrite words after the command. (-clear: clear console) (-n: write a new line)");
			Console.WriteLine("  speak\t\tSpeak written input.");
			Console.WriteLine("  run\t\tStart a process");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Math: ");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(">Usage: <command> <number[1] number[2] . . . number[n]>");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  add\t\tAdds every number after the command. Supports more than two numbers");
			Console.WriteLine("  subtract\tSubtracts every number after the command. Supports more than two numbers");
			Console.WriteLine("  multiply\tMultiplies every number after the command. Supports more than two numbers");
			Console.WriteLine("  divide\tDivides every number after the command. Supports more than two numbers");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Internet:");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine(">Usage: <command> <searchkeys>");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("  google\tSearch to web using Google");
			Console.WriteLine("  duckduckgo\tSearch to web using DuckDuckGo");
			Console.WriteLine("  youtube\tSearch on YouTube");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("");
		}
	}
}
