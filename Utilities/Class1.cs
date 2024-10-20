namespace Utilities;

public static class Class1
{
	public static void Print()
	{
		Console.WriteLine();

	}

	private static readonly Random _random = new();
	public static void PrintRandomNumber()
	{
		var roll = _random.Next(1, 7);
		Console.WriteLine(roll);
	}
}