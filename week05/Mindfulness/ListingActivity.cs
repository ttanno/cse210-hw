public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int duration, List<string> prompts) 
        : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _prompts= prompts;
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();
        _count = responses.Count;

        Console.WriteLine($"\nYou listed {_count} items!");
    }
    public string GetRandomPrompt()
    {
        Random num = new Random();
        int number = num.Next(_prompts.Count()+1);
        return _prompts[number];
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
        }
        return responses;
    }
}