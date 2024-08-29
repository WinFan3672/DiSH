using Dish.Util;

namespace Dish.Commands
{
	public static class VarImport
	{
		public static int Program(string[] Args)
		{
			if (Args.Length == 0)
			{
				Console.WriteLine("usage: import <variable> [variable...]");
				return 1;
			}

			foreach(string Arg in Args)
			{
				try
				{
					StoreUtils.Import(Arg);
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("error: Invalid variable");
					return 1;
				}
			}
			return 0;
		}
	}
}
