using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        int sum = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();

            if (!int.TryParse(num, out number))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
            sum += number;
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int numInList in numbers)
        {
            if (numInList > max)
            {
                max = numInList;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
//extra
                int min = numbers[0];
        foreach (int numInList in numbers)
        {
            if (numInList < min &&numInList>0)
            {
                min = numInList;
            }
        }
        Console.WriteLine($"The smallest positive number is:: {min}");
//extra
        Console.WriteLine("The sorted list is:");
        foreach (int numInList in numbers)
        {
            Console.WriteLine(numInList);
        }
    }
}