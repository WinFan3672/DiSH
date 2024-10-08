namespace Dish.Util
{
	public static partial class Command
	{		
		public static string GetCommand(string Command)
		{
			return Command.Split(" ")[0];
		}

		public static string[] GetArgs(string Command)
		{
			List<string> CommandPlusArgs = Command.Split(" ").ToList();
			CommandPlusArgs.RemoveAt(0);
			return CommandPlusArgs.ToArray();
		}

		public static string FormatArgs(string[] Args)
		{
			return string.Join(" ", Args);
		}
	}
}
