

public abstract class Activity
{
    private string _date;
    protected double _length;
    private string _type;


    public Activity(string type, string date, double length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public virtual void GetSummary()
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed(); 
        double pace = CalculatePace();
        
        Console.WriteLine("");
        Console.WriteLine($"{_date} {_type} ({_length} min)-");
        Console.WriteLine($"Distance: {distance} miles, Speed: {speed} mph,");
        Console.WriteLine($"Pace: {pace} min per mile");
    }
}