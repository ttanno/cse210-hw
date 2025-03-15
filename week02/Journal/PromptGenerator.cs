public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing I learned about myself today?",
        "What challenge did I face today, and how did I handle it?",
        "What is something I did today that made me proud?",
        "What is one small step I took toward my goals today?",
        "Who made a positive impact on my day today?",
        "What is one meaningful conversation I had today?",
        "How did I strengthen a relationship today?",
        "If I could have spent more time with someone today, who would it be and why?",
        "What is something that brought me peace or joy today?",
        "If I could change one thought I had today, what would it be?",
        "What is one thing I am grateful for today?",
        "What was a small moment of happiness I experienced today?",
        "What is something beautiful I noticed today?",
        "What is one thing I am looking forward to tomorrow?",
        "What was my biggest accomplishment today?",
        "What is one thing I could do better tomorrow?",
        "What was the most important task I completed today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int i= rand.Next(_prompts.Count);
        return _prompts[i];
    }
}   