public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "a", "b", "c" };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int i= rand.Next(_prompts.Count);
        return _prompts[i];
    }
}   