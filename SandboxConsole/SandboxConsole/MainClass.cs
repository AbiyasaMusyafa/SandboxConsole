using System;
using System.Linq;
using SandboxConsole.Math;
using SandboxConsole.CommandsLib;

namespace SandboxConsole
{
	class MainClass
	{
		string[] userinputs;
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
			HandleCommandInputs(userinputs);
		}

		void ReadCommand()
		{
			PredefinedClusterfuck.ReadSetup();
			string _read = Console.ReadLine();
			userinputs = _read.Split();
			command = userinputs[0].ToLower();
		}

		void HandleCommandInputs(string[] args)
		{
			switch (command)
			{
				case "run":
					Commands.RunProcess(args);
					break;
				case "google":
					Commands.GoogleSearch(args);
					break;
				case "duckduckgo":
					Commands.DuckDuckGoSearch(args);
					break;
				case "youtube":
					Commands.YoutubeSearch(args);
					break;
				case "speak":
					Commands.Speak(args);
					break;
				case "print":
					Commands.Print(args);
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
			double _result;
			switch (cmd)
			{
				case "add":
					_result = Mathf.Add(args);
					Console.WriteLine(_result);
					break;
				case "subtract":
					_result = Mathf.Subtract(args);
					Console.WriteLine(_result);
					break;
				case "multiply":
					_result = Mathf.Multiply(args);
					Console.WriteLine(_result);
					break;
				case "divide":
					_result = Mathf.Divide(args);
					Console.WriteLine(_result);
					break;
				default:
					break;
			}
		}
	}
}