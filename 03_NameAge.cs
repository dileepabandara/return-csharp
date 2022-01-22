using System;

public class NameAge
{
    public static void Main(string[] args)
    {
        string name;
        int age;
        Console.Write("ENTER YOUR NAME HERE: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("ENTER YOUR AGE HERE: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nHello {0} Your age is {1} years old", name, age);
        Console.ReadLine();
    }
}