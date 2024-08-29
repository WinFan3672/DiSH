namespace Dish.Util
{
	public class NoCommandException : Exception
	{
		public string Command;
		public NoCommandException(string Command) : base(Command)
		{
			this.Command = Command;
		}
	}
}
