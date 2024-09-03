using System.Diagnostics;
using Dish.Commands;
using Dish.Stores;

namespace Dish.Util
{
	public static partial class Command
	{
		public static void CancelKeyPressed(object? Sender, ConsoleCancelEventArgs Args)
		{
			Args.Cancel = true;
		}

		public static string[] BuiltinCommands = new[] { 
			"help",
				"clear",
				"cls",
				"export",
				"import",
				"import-all",
				"quit",
				"exit",
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
			catch (NoCommandException Ex)
			{
				Console.WriteLine($"dish: Bad command, builtin or file name: {Ex.Command}");
				return 1;
			}

			ProcessStartInfo PSI = new ProcessStartInfo(ExecPath, FormatArgs(GetArgs(Command))) { RedirectStandardOutput = false, RedirectStandardError = false};
			foreach(KeyValuePair<string, string> KVP in ExportStore.Exports)
			{
				PSI.Environment.Add(KVP.Key, KVP.Value);
			}
			using (Process Proc  = new Process {StartInfo = PSI})
			{
				Proc.Start();
				Proc.WaitForExit();
				return Proc.ExitCode;
			}
		}

		public static void RunScript(string Path)
		{
		}
	}
}
