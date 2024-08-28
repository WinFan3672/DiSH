namespace Dish.Commands
{
	public static class DishBuiltins
	{
		public static int Execute(string Command, string[] Args)
		{
			if (Command == "help")
			{
				return Help.RunCommand(Args);
			}
			throw new Exception();
		}
	}
}
