using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Activity> _activities = new List<Activity>();
        
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity run1 = new RunningActivity("Running", "12 Apr 2026", 60, 5);
        _activities.Add(run1);
        CyclingActivity cycle1 = new CyclingActivity("Cycling", "13 Apr 2026", 30, 20);
        _activities.Add(cycle1);
        SwimmingActivity swim1 = new SwimmingActivity("Swimming", "14 Apr 2026", 45, 50);
        _activities.Add(swim1);

        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
        }

    }
}