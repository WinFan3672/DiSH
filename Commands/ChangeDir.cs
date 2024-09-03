namespace Dish.Commands
{
	public static class ChangeDir
	{
		public static int Program(string[] Args)
		{
			if (Args.Length != 1)
			{
				Console.WriteLine("usage: cd [directory]");
				return 1;
			}
			Directory.SetCurrentDirectory(Args[0]);
			return 0;
		}
	}
}
