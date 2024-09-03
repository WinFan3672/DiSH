using Dish.Util;

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
			try
			{
				Directory.SetCurrentDirectory(Command.ExpandPath(Args[0]));
				return 0;
			}
			catch (System.IO.DirectoryNotFoundException)
			{
				Console.WriteLine("dish: Invalid directory");
				return 1;
			}
		}
	}
}
