using Dish.Util;

namespace Dish.Commands
{
	public static class DishBuiltins
	{
		public static int Execute(string Command, string[] Args)
		{
			if (Command == "help")
			{
				return Help.RunCommand();
			}
			else if (Command == "clear" || Command == "cls")
			{
				Console.Clear();
				return 0;
			}
			else if (Command == "builtin")
			{
				return BuiltinList.RunCommand();
			}
			else if (Command == "export")
			{
				return ExportsView.Program(Args);
			}
			else if (Command == "import")
			{
				return VarImport.Program(Args);
			}
			else if (Command == "import-all")
			{
				return ImportAll.Program(Args);
			}
			else if (Command == "exit" || Command == "quit")
			{
				return ExitCommand.RunCommand();
			}
			else if (Command == "cd")
			{
				return ChangeDir.Program(Args);
			}
			else
			{
				throw new NoCommandException(Command);
			}
		}
	}
}
