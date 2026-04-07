

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public int DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
        Console.Write("How long in seconds do you want to run this activity: ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        return _duration;
    }
}