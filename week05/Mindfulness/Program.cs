using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Prompts
        List<string> Rprompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        List<string> Lprompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Main program loop
        bool centinela = true;
        while (centinela)
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. Quit");

            // Read menu option
            Console.WriteLine("Choose an option: ");
            int option = int.Parse(Console.ReadLine());
            int duration = 0;

            // Handle different options
            if (option == 1)
            {
                Console.Clear();
                BreathingActivity activity = new BreathingActivity(duration);
                activity.DisplayStartingMessage();
                duration = int.Parse(Console.ReadLine()); // Read duration
                activity = new BreathingActivity(duration);
                activity.Run();
                activity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (option == 2)
            {
                Console.Clear();
                ReflectingActivity activity = new ReflectingActivity(duration, questions, Rprompts);
                activity.DisplayStartingMessage();
                duration = int.Parse(Console.ReadLine()); // Read duration
                activity= new ReflectingActivity(duration, questions, Rprompts);
                activity.Run();
                activity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (option == 3)
            {
                Console.Clear();
                ListingActivity activity = new ListingActivity(duration, Lprompts);
                activity.DisplayStartingMessage();
                duration = int.Parse(Console.ReadLine()); // Read duration
                activity = new ListingActivity(duration, Lprompts);
                activity.Run();
                activity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (option == 4)
            {
                centinela = false;
            }
            else
            {
                Console.WriteLine("Enter a valid option for menu");
                Console.Clear();
            }
        }
    }
}
