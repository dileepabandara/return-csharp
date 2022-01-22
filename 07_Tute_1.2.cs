using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name;
        int age;
        Console.Write("Enter your name: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello {0}. You are {1} years old.", name, age);
        Console.ReadLine();
    }
}
