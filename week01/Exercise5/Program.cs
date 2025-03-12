using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }
    static int SquareNumber(int number)
    {
        int SquaredNumber = number * number;
        return SquaredNumber;
    }
    static void DisplayResult(string name,int SquaredNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {SquaredNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int SquaredNumber = SquareNumber(number);
        DisplayResult(name, SquaredNumber);
    }
}