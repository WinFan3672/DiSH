namespace Dish.Commands
{
	public static class ExitCommand
	{
		public static int RunCommand()
		{
			System.Environment.Exit(0);
			return 0;
		}
	}
}
