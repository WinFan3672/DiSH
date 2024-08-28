namespace Dish.Util
{
	public static class Welcome
	{
		public static void Init()
		{
			Console.WriteLine($"Welcome to dish {AssemblyTools.GetVersion()}!");
		}
	}
}
