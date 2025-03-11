using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int sentinel = -1;//This is for the strong or extra requirements
        while (sentinel != 0)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guess = -1;
            int tries = 0;
            while (guess != number)
            {
                Console.Write("What is your guess?");
                string guess_word = Console.ReadLine();
                guess = int.Parse(guess_word);
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                tries++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {tries} to guess");
            sentinel = -1;//is this the unique way to reinitialized?

            while (sentinel == -1)
            {
                Console.WriteLine("Do you want to continue?");
                string intention = Console.ReadLine().ToLower();
                if (intention == "yes")
                {
                    sentinel = 1;
                }
                else if (intention == "no")
                {
                    sentinel = 0;
                }
                else
                {
                    Console.WriteLine("Enter a valid answer");
                }
            }
        }
    }    
}