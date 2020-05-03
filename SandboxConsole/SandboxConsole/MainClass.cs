using System;
using System.Linq;
using SandboxConsole.Math;
using SandboxConsole.CommandsLib;

namespace SandboxConsole
{
	class MainClass
	{
		string[] readInput;
		string command;

		private static string _username;
		public string Username { get => _username; set => _username = value; }

		//Initialization
		public MainClass()
		{
			Username = "defaultuser0";
		}

		//Executed while program is running
		public void OnUpdate()
		{
			ReadCommand();
			HandleCommandInputs(readInput);
		}

		void ReadCommand()
		{
			PredefinedClusterfuck.ReadSetup();
			string _read = Console.ReadLine();
			readInput = _read.Split();
			command = readInput[0].ToLower();
		}

		void HandleCommandInputs(string[] args)
		{
			switch (command)
			{
				case "google":
					Commands.GoogleSearch(args);
					break;
				case "duckduckgo":
					Commands.DuckDuckGoSearch(args);
					break;
				case "youtube":
					Commands.YoutubeSearch(args);
					break;
				case "print":
					Commands.PrintMSG(args);
					break;
				case "changeuser":
					Username = Commands.ChangeUser(args);
					break;
				case "listcmd":
					PredefinedClusterfuck.ShowCommandList();
					break;
				case "clear":
					Console.Clear();
					break;
				case "quit":
					Program.OnShutdown();
					break;
				default:
					if (Mathf.mathcmd.Any(s => s.Contains(command)))
					{
						HandleMathCommands(command, args);
					}
					else if (command != "")
					{
						Console.WriteLine($"Unrecognized command \'{command}\'\nType 'listcmd' to view available commands");
					}
					break;
			}
		}
		void HandleMathCommands(string cmd, string[] args)
		{
			switch (cmd)
			{
				case "add":
					double add = Mathf.Add(args);
					Console.WriteLine(add);
					break;
				case "subtract":
					double subtract = Mathf.Subtract(args);
					Console.WriteLine(subtract);
					break;
				case "multiply":
					double multiply = Mathf.Multiply(args);
					Console.WriteLine(multiply);
					break;
				case "divide":
					double divide = Mathf.Divide(args);
					Console.WriteLine(divide);
					break;
				default:
					break;
			}
		}
	}
}