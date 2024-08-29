using Dish.Stores;

namespace Dish.Commands
{
	public static class ExportsView
	{
		public static int Program(string[] Args)
		{
			foreach(var KVP in ExportStore.Exports)
			{
				Console.WriteLine($"{KVP.Key}={KVP.Value}");
			}
			return 0;
		}
	}
}
