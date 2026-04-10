

public class BreathingActivity : Activity
{


    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void RunBreathing()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe In ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            Console.WriteLine("");
            Console.Write("Breathe Out ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            
        } 
    }
}