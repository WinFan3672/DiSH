namespace Dish.Util
{
	public static class AssemblyTools
	{
		public static string GetVersion()
		{
			var Assembly = System.Reflection.Assembly.GetExecutingAssembly();
			return System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.Location).FileVersion ?? throw new ArgumentNullException();
		}
	}
}
