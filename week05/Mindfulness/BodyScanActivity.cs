

public class BodyScanActivity : Activity
{

    public BodyScanActivity(string name, string description) : base(name, description)
    {

    }

    public void RunBodyScan()
    {
        Console.Clear();
        Console.WriteLine("Begin by sitting upright in a chair with your feet on the ground.");
        Console.WriteLine("");
        Thread.Sleep(2000);
        Console.WriteLine("Stay very still throughout the activity.");
        Thread.Sleep(1500);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Turn your focus to your breath. Focus on each inhale and exhale.");
        ShowDots();
        ShowDots();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Next, focus on how your clothing feels against your skin.");
        ShowDots();
        ShowDots();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Starting at your feet, focus on how each part of your body is feeling as you move your focus up towards your head.");
        ShowDots();
        ShowDots();
        ShowDots();
        ShowDots();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Finish by taking three more deep breaths, focusing on how your chest expands and contracts with each one.");
        ShowDots();
        ShowDots();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}