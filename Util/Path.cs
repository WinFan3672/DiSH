namespace Dish.Util
{
	public static partial class Command
	{
		public static string GetPathString()
		{
			return Environment.GetEnvironmentVariable("PATH") ?? throw new Exception();
		}

		public static char GetPathSeparator()
		{
			return OperatingSystem.IsWindows() ? ';' : ':';
		}

		public static string[] GetPath()
		{
			return GetPathString().Split(GetPathSeparator());
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
			throw new Exception();
		}

		public static string GetBaseCommand(string FullPath)
		{
			return GetCommand(Path.GetFileName(FullPath));
		}
	}
}
