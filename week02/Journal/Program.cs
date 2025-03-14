using System;
using System.Threading.Tasks.Dataflow;
using System.IO; 
class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Journal Program");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write \n2. Display\n3.Load\n4. Save\n5. Quit.");
    }

    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        while (true)
        {
            DisplayMenu();
            Console.WriteLine("What would you like to do?");
            string opt = Console.ReadLine();
            int option = int.Parse(opt);
            Journal journal1 = new Journal();
            if (option == 5)
            {
                break;
            }
            else if (option == 1)
            {
                Entry entry1 = new Entry();
                entry1._date = dateText;
                
                Console.WriteLine(entry1._promptText);
                entry1._entryText = Console.ReadLine();
                journal1.AddEntry(entry1);
            }
            else if (option == 2)
            {
                journal1.DisplayAll();
            }
            else if (option == 4)
            {
                Console.WriteLine("How would you like to name your file?");
                string FileName = Console.ReadLine();
                journal1.SaveToFile(FileName);
            }
            else if (option == 3)
            {
                Console.WriteLine("What is the file name?");
                string FileName = Console.ReadLine();
                journal1.LoadFromFile(FileName);
            }
        }
    }
}