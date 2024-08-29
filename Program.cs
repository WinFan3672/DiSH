using Dish.Util;
using Dish.Stores;

Console.CancelKeyPress += new ConsoleCancelEventHandler(Command.CancelKeyPressed);
Welcome.Init();
string Cmd;
int ExitCode;
while(true)
{
	Console.Write("dish >");
	Cmd = Console.ReadLine() ?? throw new Exception();
	ExitCode = Command.ExecuteCommand(Cmd);
	if (ExitCode != 0)
	{
	}
	if (Chance.Rand.NextDouble() < 0.15)
	{
		Console.WriteLine("Running command again for good luck!");
		Command.ExecuteCommand(Cmd);
	}
}
