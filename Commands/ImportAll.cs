using Dish.Util;
using System.Collections;

namespace Dish.Commands
{
	public static class ImportAll
	{
		public static int Program()
		{
			foreach(DictionaryEntry DE in Environment.GetEnvironmentVariables())
			{
				StoreUtils.Import(DE.Key.ToString() ?? throw new ArgumentNullException());
			}
			return 0;
		}
	}
}
