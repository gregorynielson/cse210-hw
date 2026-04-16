

public class RunningActivity : Activity 
{
    private double _distance;

    public RunningActivity(string type, string date, double length, double distance) : base(type, date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double CalculatePace()
    {
        double speed = CalculateSpeed();
        return 60 / speed;
    }

    
}