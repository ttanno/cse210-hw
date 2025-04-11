public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(6);     
    }
    public void ShowSpinner(int second)
    {
        List<string> animationStrings = [
            "|","/","-","\\","|","/","-","\\"
        ];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int second)
    {
        for (int i = second; i >= 0; i -= 1) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
