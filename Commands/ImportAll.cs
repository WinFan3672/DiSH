using Dish.Util;
using System.Collections;

namespace Dish.Commands
{
	public static class ImportAll
	{
		public static int Program(string[] Args)
		{
			foreach(DictionaryEntry DE in Environment.GetEnvironmentVariables())
			{
				if (!Args.Contains(DE.Key))
				{
					StoreUtils.Import(DE.Key.ToString() ?? throw new ArgumentNullException());
				}
			}
			return 0;
		}
	}
}
