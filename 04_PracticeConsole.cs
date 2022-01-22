using System;

public class PracticeConsole
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.Write("enter the first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, c);
        Console.ReadLine();

    }
}
