using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int percentage_num = int.Parse(percentage);

        string letter;
        string add;
        if (percentage_num >= 90)
        {
            letter = "A";
        }
        else if (percentage_num >= 80)
        {
            letter = "B";
        }
        else if (percentage_num >= 70)
        {
            letter = "C";
        }
        else if (percentage_num >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if ((percentage_num < 93) && (percentage_num >= 60))
        {
            percentage_num = percentage_num % 10;
            if (percentage_num >= 7)
            {
                add = "+";
            }
            else if (percentage_num < 3)
            {
                add = "-";
            }
            else
            {
                add = "";
            }
        }
        else
        {
          add = "";  
        }
        Console.WriteLine($"Your grade is: {letter}{add}");


        if (!(letter == "D" || letter == "F"))
        {
            Console.WriteLine("You passed the course. Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't passed but it is not the end. Effort next time.");
        }
    }
}