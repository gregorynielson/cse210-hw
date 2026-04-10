

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have selected the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        if (_name == "Body Scan")
        {
            Console.WriteLine("This activity will run for 30 seconds");
            _duration = 30;
        }else {
            Console.Write("How long in seconds do you want to run this activity: ");
            string duration = Console.ReadLine();
            _duration = int.Parse(duration);
        }
        
        Console.WriteLine("");
        Console.Write("Prepare to begin");
        ShowDots();
        return _duration;
    }

    public void DisplayEndingMessage(string activity)
    {
        Console.WriteLine("");
        Console.Write("Great job!");
        ShowDots();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write($"You completed the {activity} activity for {_duration} seconds!");
        ShowDots();
        Console.Clear();
    }

    public void ShowDots()
    {
        
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write("\b\b\b   \b\b\b");
            Thread.Sleep(300);
        }
    }
}