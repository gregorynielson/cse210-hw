

public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "What is something that made you laugh today?",
        "What is one thing you are grateful for today?",
        "If you could do one thing different today, what would it be?",
        "If all of your commitments today cancelled, what would you do?",
        "If you could have lunch with anyone from history, who would it be and why?"
    };
    

    public void DisplayPrompt()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"{prompt}");
        }
    }
}