public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity( int duration, List<string> questions, List<string> prompts) 
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Clear();

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine(); // Espera ENTER

        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            DisplayQuestions();

            if (timeLeft >= 5)
            {
                ShowSpinner(5);
                timeLeft -= 5;
            }
            else
            {
                ShowSpinner(timeLeft);
                timeLeft = 0;
            }

            Console.WriteLine(); // Espacio entre preguntas
        }
    }
    public string GetRandomPrompt()
    {
        Random num = new Random();
        int number = num.Next(_prompts.Count());
        return _prompts[number];
    }
    public string GetRandomQuestion()
    {
        Random num = new Random();
        int number = num.Next(_questions.Count());
        return _questions[number];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
}