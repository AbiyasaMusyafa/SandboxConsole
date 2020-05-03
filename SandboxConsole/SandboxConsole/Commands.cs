using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole.CommandsLib
{
	class Commands
	{
		public static void PrintMSG(string[] messageSrc)
		{
			foreach (string s in messageSrc)
			{
				if (s == "-clear")
				{
					Console.Clear();
				}
				if (s == "-n")
				{
					Console.WriteLine();
				}
				if (s != messageSrc[0] && s != "-clear" && s != "-n")
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

		public static void GoogleSearch(string[] searchkeys)
		{
			string url = "https://www.google.com/search?q=";
			
			if (searchkeys.Length == 1)
			{
				url = "https://www.google.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					url = i != searchkeys.Length - 1 ? url + searchkeys[i] + "+" : url + searchkeys[i];
				}
			}

			Process.Start(url);
			Console.WriteLine($"Opened URL in browser: \"{url}\"");
		}

		public static void DuckDuckGoSearch(string[] searchkeys)
		{
			string url = "https://duckduckgo.com/?q=";

			if (searchkeys.Length == 1)
			{
				url = "https://duckduckgo.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					url = i != searchkeys.Length - 1 ? url + searchkeys[i] + "+" : url + searchkeys[i];
				}
			}

			Process.Start(url);
			Console.WriteLine($"Opened URL in browser: \"{url}\"");
		}

		public static void YoutubeSearch(string[] searchkeys)
		{
			string url = "https://www.youtube.com/results?search_query=";

			if (searchkeys.Length == 1)
			{
				url = "https://www.youtube.com/";
			}
			else
			{
				for (int i = 1; i < searchkeys.Length; i++)
				{
					url = i != searchkeys.Length - 1 ? url + searchkeys[i] + "+" : url + searchkeys[i];
				}
			}

			Process.Start(url);
			Console.WriteLine($"Opened URL in browser: \"{url}\"");
		}
	}
}
