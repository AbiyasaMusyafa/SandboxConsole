using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxing
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
			HandleCommandInputs();
		}

		void ReadCommand()
		{
			PredefinedClusterfuck.ReadSetup();
			string _read = Console.ReadLine();
			readInput = _read.Split();
			command = readInput[0].ToLower();
		}

		void HandleCommandInputs()
		{
			switch (command)
			{
				case "print":
					PrintMSG(readInput);
					break;
				case "changeuser":
					ChangeUser(readInput);
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
						HandleMathCommands(command);
					}
					else if (command != "")
					{
						Console.WriteLine($"Unrecognized command \'{command}\'\nType 'listcmd' to view available commands");
					}
					break;
			}
		}
		void HandleMathCommands(string cmd)
		{
			switch (cmd)
			{
				case "add":
					double add = Mathf.Add(readInput);
					Console.WriteLine(add);
					break;
				case "subtract":
					double subtract = Mathf.Subtract(readInput);
					Console.WriteLine(subtract);
					break;
				case "multiply":
					double multiply = Mathf.Multiply(readInput);
					Console.WriteLine(multiply);
					break;
				case "divide":
					double divide = Mathf.Divide(readInput);
					Console.WriteLine(divide);
					break;
				default:
					break;
			}
		}

		void PrintMSG(string[] messageSrc)
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

		void ChangeUser(string[] newUsername)
		{
			Username = newUsername[1];

			Console.WriteLine($"User has been changed to {Username}");
		}
	}
}