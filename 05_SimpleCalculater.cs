using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n1, n2, add, sub, mul, div;
        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        add = n1 + n2;
        sub = n1 - n2;
        mul = n1 * n2;
        div = n1 / n2;

        Console.WriteLine("Add is :" + add);
        Console.WriteLine("Sub is :" + sub);
        Console.WriteLine("Mul is :" + mul);
        Console.WriteLine("Div is :" + div);

        Console.Read();

    }
}