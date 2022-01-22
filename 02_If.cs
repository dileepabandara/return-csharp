using System;

public class If
{
    public static void Main(string[] args)
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 50)
        {
            Console.WriteLine("GO");
        }
        else
        {
            Console.WriteLine("DON'T");
        }
        Console.Read();
    }
}