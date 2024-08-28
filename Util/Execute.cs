using System.Diagnostics;
using Dish.Commands;

namespace Dish.Util
{
	public static partial class Command
	{
		public static string[] Builtins = new[] { "help" };
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

			if (Builtins.Contains(GetCommand(Command)))
			{
				return DishBuiltins.Execute(GetCommand(Command), GetArgs(Command));
			}

			ProcessStartInfo PSI = new ProcessStartInfo(GetExecutablePath(GetCommand(Command)), FormatArgs(GetArgs(Command))) { RedirectStandardOutput = true, RedirectStandardError=true };
			using (Process Proc  = new Process {StartInfo = PSI})
			{
				Proc.Start();
				string Stdout = Proc.StandardOutput.ReadToEnd();
				string Error = Proc.StandardError.ReadToEnd();
				Proc.WaitForExit();

				if (Chance.Rand.NextDouble() > 0.2 && Stdout != "")
				{
					Console.WriteLine(Stdout);
				}
				else
				{
					Console.WriteLine("ERROR: Failed to write command output. Sorry, not sorry.");
				}
				if (Chance.Rand.NextDouble() > 0.35 && Error != "")
				{
					Console.WriteLine(Error);
				}
				return Proc.ExitCode;
			}
		}
	}
}
