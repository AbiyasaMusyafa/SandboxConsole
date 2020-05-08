using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole.CommandsLib
{
	class Commands
	{
		public static string URL;

		public static void Print(string[] messages)
		{
			foreach (string s in messages)
			{
				if (s == "-clear")
				{
					Console.Clear();
				}
				if (s == "-n")
				{
					Console.WriteLine();
				}
				if (s != messages[0] && s != "-clear" && s != "-n")
				{
					Console.Write($"{s} ");
				}
			}
			Console.WriteLine();
		}
		
		public static String ChangeUser(string[] newUsername)
		{
			string usr = newUsername[1];

			Console.WriteLine($"User has been changed to {usr}");
			return usr;
		}

		public static void RunProcess(string[] args)
		{
			URL = string.Empty;
			for (int i = 1; i < args.Length; i++)
			{
				URL = URL + args[i];
			}
			if (URL != "")
			{
				try
				{
					Process.Start(URL);
					Console.WriteLine($"Process started: \"{URL}\"");
				}
				catch (Win32Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			else Console.WriteLine("URL has not been specified");			
		}

		public static void GoogleSearch(string[] searchkeys)
		{
			URL = "https://www.google.com/search?q=";
			
			if (searchkeys.Length == 1)
			{
				URL = "https://www.google.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					URL = i != searchkeys.Length - 1 ? URL + searchkeys[i] + "+" : URL + searchkeys[i];
				}
			}

			Process.Start(URL);
			Console.WriteLine($"Opened URL in browser: \"{URL}\"");
		}

		public static void DuckDuckGoSearch(string[] searchkeys)
		{
			URL = "https://duckduckgo.com/?q=";

			if (searchkeys.Length == 1)
			{
				URL = "https://duckduckgo.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					URL = i != searchkeys.Length - 1 ? URL + searchkeys[i] + "+" : URL + searchkeys[i];
				}
			}

			Process.Start(URL);
			Console.WriteLine($"Opened URL in browser: \"{URL}\"");
		}

		public static void YoutubeSearch(string[] searchkeys)
		{
			URL = "https://www.youtube.com/results?search_query=";

			if (searchkeys.Length == 1)
			{
				URL = "https://www.youtube.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					URL = i != searchkeys.Length - 1 ? URL + searchkeys[i] + "+" : URL + searchkeys[i];
				}
			}

			Process.Start(URL);
			Console.WriteLine($"Opened URL in browser: \"{URL}\"");
		}
	}
}
