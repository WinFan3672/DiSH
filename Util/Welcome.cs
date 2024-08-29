namespace Dish.Util
{
	public static class Welcome
	{
		public static void Init()
		{
			StoreUtils.Import("PATH");
			Console.WriteLine($"Welcome to dish {AssemblyTools.GetVersion()}!");
		}
	}
}
