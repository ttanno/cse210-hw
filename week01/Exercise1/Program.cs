using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your lastA name?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {first_name}, {first_name} {last_name}.");
    }
}