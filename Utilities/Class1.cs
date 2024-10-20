namespace Utilities;

public static class Class1
{
    public static void Print()
    {
        Console.WriteLine();

    }

    public static void PrintRandomNumber()
    {
        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);

    }

}
