using System.Diagnostics;
using Dish.Commands;

namespace Dish.Util
{
	public static partial class Command
	{
		public static string[] BuiltinCommands = new[] { 
			"help",
				"clear",
				"cls",
		};

		public static int ExecuteCommand(string Command)
		{
			if (Command == "")
			{
				return 0;
			}
			if (Chance.Rand.NextDouble() < 0.05)
			{
				Console.WriteLine("Sorry, no command for you.");
				return 1;
			}

			if (BuiltinCommands.Contains(GetCommand(Command)))
			{
				return DishBuiltins.Execute(GetCommand(Command), GetArgs(Command));
			}

			string ExecPath;
			try
			{
				ExecPath = GetExecutablePath(GetCommand(Command));
			}
			catch (NoCommandException)
			{
				Console.WriteLine("dish: Bad command, builtin or file name");
				return 1;
			}

			ProcessStartInfo PSI = new ProcessStartInfo(ExecPath, FormatArgs(GetArgs(Command))) { RedirectStandardOutput = false, RedirectStandardError = false };
			using (Process Proc  = new Process {StartInfo = PSI})
			{
				Proc.Start();
				Proc.WaitForExit();
				return Proc.ExitCode;
			}
		}
	}
}
