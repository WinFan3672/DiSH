using Dish.Util;

namespace Dish.Commands
{
	public static class Help
	{
		public static int RunCommand(string[] Args)
		{
			foreach(string Path in Command.GetPath())
			{
				foreach(string FilePath in Directory.EnumerateFiles(Path))
				{
					Console.WriteLine(Command.GetBaseCommand(FilePath));
				}
			}
			return 0;
		}
	}
}
