using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>(); 

        var random = new Random();
        activities.Add(new Running("07 Apr 2023", random.Next(20, 60), random.NextDouble() * 10));
        activities.Add(new Cycling("09 Feb 2023", random.Next(30, 90), random.Next(10, 25)));
        activities.Add(new Swimming("15 Jan 2023", random.Next(40, 80), random.Next(20, 60)));
        activities.Add(new Running("18 Mar 2024", random.Next(30, 60), random.Next(5, 10)));
        activities.Add(new Cycling("22 Aug 2024", random.Next(40, 100), random.Next(15, 30)));
        activities.Add(new Swimming("28 Dec 2023", random.Next(30, 70), random.Next(10, 50)));  
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
