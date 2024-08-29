using Dish.Stores;

namespace Dish.Util
{
	public static class StoreUtils
	{
		public static string Get(string Key)
		{
			return ExportStore.Exports[Key];
		}

		public static void Set(string Key, string Value)
		{
			ExportStore.Exports[Key] = Value;
		}

		public static string GetPrepend()
		{
			List<string> Final = new List<string>();
			foreach(var KVP in ExportStore.Exports)
			{
				Final.Add($"{KVP.Key}={KVP.Value}");
			}
			return string.Join(" ", Final);
		}
		
		public static void Import(string Key)
		{
			ExportStore.Exports[Key] = Environment.GetEnvironmentVariable(Key) ?? throw new ArgumentNullException();
		}
	}
}
