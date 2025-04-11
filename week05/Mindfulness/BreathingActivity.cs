public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            int cycleTime;

            if (timeLeft >= 10)
            {
                cycleTime = 10;
            }
            else
            {
                cycleTime = timeLeft;
            }

            int breathIn = (int)(cycleTime * 0.4);
            int breathOut = cycleTime - breathIn;

            Console.Write("\nBreathe in...");
            ShowCountDown(breathIn);

            Console.Write("\nNow breathe out...");
            ShowCountDown(breathOut);

            timeLeft -= cycleTime;
        }
    }
}
