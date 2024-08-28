using Dish.Util;

namespace Dish.Commands
{
	public static class BuiltinList
	{
		public static int RunCommand()
		{
			foreach(string Command in Command.BuiltinCommands)
			{
				Console.WriteLine(Command);
			}

			return 0;
		}
	}
}
