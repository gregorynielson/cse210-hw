

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for what you believe in.",
        "Think of a time when you served someone in need.",
        "Think of a time when you went out of your way to help someone.",
        "Think of a time when you proved the doubters wrong.",
        "Think of a time when you did the right thing when everyone else was doing wrong."
    };

    private List<string> _questions = new List<string>()
    {
        "What makes this experience special? ",
        "How did this experience make you feel? ",
        "Did you get any recognition for doing this? ",
        "Did anyone know you were doing this? ",
        "Would you do this again? ",
        "Why did you do this in the first place? ",
        "Would you have done anything different? ",
        "How have you been blessed from this experience? "
    };

    private List<int> _usedQuestions = new List<int>()
    {

    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        Console.WriteLine($"---- {_prompts[randomIndex]} ----");
    }

    public void DisplayRandomQuestion()
    {
        Random random = new Random();
        GetQuestion:
        int randomIndex = random.Next(0, _questions.Count);

        if (!_usedQuestions.Contains(randomIndex))
        {
            _usedQuestions.Add(randomIndex);

            Console.Write(_questions[randomIndex]);
        }
        else{
            goto GetQuestion;
        }
    }

    public void RunReflection()
    {
        Console.Clear();

        Console.WriteLine("Consider this prompt:");
        Console.WriteLine("");
        Console.WriteLine("");
        DisplayRandomPrompt();
        Console.WriteLine("");
        Console.Write("When you think of something, press enter.");
        Console.ReadLine();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            DisplayRandomQuestion();
            ShowSpinner();
        }

        
    }
}