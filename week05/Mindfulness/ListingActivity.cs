

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "What made you smile this week?",
        "How have you been selfless this week?",
        "What can you do to show more gratitude?",
        "How have you been served this month?",
        "What made you laugh this week?"
    };


    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
    }

    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            Console.WriteLine("");
        }
    }

    public void RunListing()
    {
        Console.Clear();
        GetRandomPrompt();
        ShowDots();
        Console.WriteLine("");
        GetListFromUser();
        Console.WriteLine("");
    }
}