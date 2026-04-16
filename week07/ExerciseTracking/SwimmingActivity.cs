

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string type, string date, double length, double laps) : base(type, date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = (_laps * 50) / (1000 * 0.62);
        double roundedDist = Math.Round(distance, 2);
        return roundedDist;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        double speed = (distance / _length) * 60;
        double roundedSpeed = Math.Round(speed, 2);
        return roundedSpeed;
    }

    public override double CalculatePace()
    {
        double speed = CalculateSpeed();
        double pace = 60 / speed;
        double roundedPace = Math.Round(pace, 2);
        return roundedPace;
    }

}