namespace Dish.Util
{
	public static partial class Command
	{
		public static char GetPathSeparator()
		{
			return OperatingSystem.IsWindows() ? ';' : ':';
		}

		public static string[] GetPath()
		{
			return StoreUtils.Get("PATH").Split(GetPathSeparator());
		}

		public static string GetExecutablePath(string Executable)
		{
			string FullPath;
			foreach (string Path in GetPath())
			{
				FullPath = System.IO.Path.Combine(Path, Executable);
				if (File.Exists(FullPath))
				{
					return FullPath;
				}
			}
			throw new NoCommandException(Executable);
		}

		public static string GetBaseCommand(string FullPath)
		{
			return GetCommand(Path.GetFileName(FullPath));
		}
	}
}
