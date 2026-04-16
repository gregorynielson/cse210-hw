

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string type, string date, double length, double speed) : base(type, date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        
        return _speed * (_length / 60);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    
}