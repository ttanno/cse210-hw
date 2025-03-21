using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int lengthVerse;
        do
        {
            Console.WriteLine("Select a one-verse scripture[1] or a two-verse scripture[2]:");//added
            string verseType = Console.ReadLine();
            lengthVerse = int.Parse(verseType);
        } while (lengthVerse != 1 && lengthVerse != 2);

        Scripture scripture1;

        if (lengthVerse == 1)//two scriptures
        {
            Reference ref1 = new Reference("John", 3, 16);
            scripture1 = new Scripture(ref1, "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");
        }
        else
        {
            Reference ref1 = new Reference("Alma", 37, 6, 7);
            scripture1 = new Scripture(ref1, "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.\nAnd the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");
        }

        string difficulty;//difficulty also added

        do
        {
            Console.WriteLine("What level of difficulty would you want? (easy, medium, hard)");
            difficulty = Console.ReadLine().ToLower();
        } 
        while (difficulty != "easy" && difficulty != "medium" && difficulty != "hard");

        while (!scripture1.IsCompletelyHidden())
        {
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userOption = Console.ReadLine();

            if (userOption == "quit")
                break;
            else if (userOption == "")
            {
                if (difficulty == "easy")
                {
                    scripture1.HideRandomWords(2);
                }
                else if (difficulty == "medium")
                {
                    scripture1.HideRandomWords(4);
                }
                else if (difficulty == "hard")
                {
                    scripture1.HideRandomWords(6);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid option");
                Console.ReadLine();
            }
            
            Console.Clear();
        }

        Console.WriteLine(scripture1.GetDisplayText());
        Console.ReadLine();
    }
}
