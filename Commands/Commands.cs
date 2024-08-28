namespace Dish.Commands
{
	public static class DishBuiltins
	{
		public static int Execute(string Command, string[] Args)
		{
			if (Command == "help")
			{
				return Help.RunCommand();
			}
			else if (Command == "clear" || Command == "cls")
			{
				Console.Clear();
			}
			else if (Command == "builtin")
			{
				BuiltinList.RunCommand();
			}
			throw new Exception();
		}
	}
}
