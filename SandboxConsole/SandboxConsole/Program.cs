using System;

namespace SandboxConsole
{
	class Program
	{
		static MainClass main = new MainClass();

		public static bool Running;

		static void Main(string[] args)
		{
			OnInitialize();
			while (Running)
			{
				OnUpdate();
			}
		}

		//Use this for initialization
		static void OnInitialize()
		{
			Running = true;
			Console.Title = "Sandbox Console";

			Console.WriteLine("Sandbox Console Window\nType 'listcmd' to view available commands");
		}

		//Executed while running
		static void OnUpdate()
		{
			main.OnUpdate();
		}

		//Executed when about to shutdown
		public static void OnShutdown()
		{
			Console.WriteLine("Exiting program . . . ");
			Running = false;
		}
	}
}