using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<string> comments = new List<string>
        {
            "Great job! Keep it up!",
            "I totally agree with this.",
            "This is very insightful, thanks for sharing!",
            "Could you explain this part a bit more?",
            "I think there's a small mistake here.",
            "This made my day!",
            "Interesting perspective, but I see it differently.",
            "Well said! I couldn’t have put it better myself.",
            "Not sure I understand—can you clarify?",
            "This is so helpful, thank you!"
        };
        List<string> usernames = new List<string>
        {
            "ShadowPhoenix",
            "BlueNebulaX",
            "PixelWarrior87",
            "MysticEcho",
            "ThunderPaws99",
            "CyberNova",
            "EchoFalcon23",
            "GlitchMasterX",
            "FrostByte007",
            "SolarFlareKing"
        };
        Comment comment1;
        List<Video> videos = new List<Video>
        {
            new Video("CodeMasterYT", "How to Generate Random Comments in C#", 420),
            new Video("TechWizard", "C# Beginner Tutorial - Lists & Random", 515)
        };
        Console.WriteLine("-----------------------------------------------");
        foreach (Video video in videos)
        {
           Random num = new Random();
            int randomNumber = num.Next(1, usernames.Count);
            for (int i = 0; i <= randomNumber; i++)
            {
                Random rnd = new Random();
                string randomUser = usernames[rnd.Next(usernames.Count)];
                string randomComment = comments[rnd.Next(comments.Count)];
                comment1 = new Comment(randomUser, randomComment);
                video.AddComment(comment1);
            }
            int NumComments = video.CountComments();
            video.DisplayVideo();
            Console.WriteLine($"Total Comments: {NumComments}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}