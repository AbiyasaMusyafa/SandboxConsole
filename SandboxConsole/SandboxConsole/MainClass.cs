﻿using System;
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
				case "add":
				case "subtract":
				case "multiply":
				case "divide":
					HandleMathCommands(command);
					break;
				case "say":
					Say();
					break;
				case "changeuser":
					ChangeUser();
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
					if (command != "")
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
					int add = Mathf.Add(readInput);
					Console.WriteLine(add);
					break;
				case "subtract":
					int subtract = Mathf.Subtract(readInput);
					Console.WriteLine(subtract);
					break;
				case "multiply":
					int multiply = Mathf.Multiply(readInput);
					Console.WriteLine(multiply);
					break;
				case "divide":
					int divide = Mathf.Divide(readInput);
					Console.WriteLine(divide);
					break;
				default:
					break;
			}
		}

		void Say()
		{
			foreach (string s in readInput)
			{
				if (s != readInput[0])
				{
					Console.Write($"{s} ");
				}
			}
			Console.WriteLine();
		}

		void ChangeUser()
		{
			Username = readInput[1];

			Console.WriteLine($"User has been changed to {Username}");
		}
	}
}