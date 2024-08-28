using Dish.Util;

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
		if (Chance.CoinFlip())
		{
			Console.WriteLine("And with sudo for extra good luck!");
			Command.ExecuteCommand("sudo " + Cmd);
		}
		else
		{
			Command.ExecuteCommand(Cmd);

		}
	}
}
