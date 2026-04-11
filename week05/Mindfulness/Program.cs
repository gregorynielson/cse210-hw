
//To exceed requirements on this project I added a fourth activity. This activity guides the user through a scan of their body,
//allowing them to focus on each part and how it is feeling.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity act1 = new Activity("", "");
        int _choice = 0;

        while (_choice != 5)
        {
            Console.WriteLine("Mindfulness Activities Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Body Scan Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select one of the activities: ");
            string choiceStr = Console.ReadLine();
            _choice = int.Parse(choiceStr);

            if (_choice == 1)
            {
                BreathingActivity breathe1 = new BreathingActivity("Breathing", "This helps you calm down and relax by focusing on nothing but taking deep breaths.");
                breathe1.DisplayStartingMessage();
                breathe1.ShowSpinner();
                breathe1.RunBreathing();
                breathe1.DisplayEndingMessage("Breathing");
            }
            else if (_choice == 2)
            {
                ListingActivity list1 = new ListingActivity("Listing", "This helps you think about your day and reflect on the good things that have happened by listing as many as you can.");
                list1.DisplayStartingMessage();
                list1.RunListing();
                list1.DisplayEndingMessage("Listing");
            }
            else if (_choice == 3)
            {
                ReflectionActivity ref1 = new ReflectionActivity("Reflection", "This activity helps you to reflect on different times in your life when you have demonstrated that you are stronger and more wonderful than you might realize.");
                ref1.DisplayStartingMessage();
                ref1.RunReflection();
                ref1.DisplayEndingMessage("Reflection");
            }

            else if (_choice == 4)
            {
                BodyScanActivity body1 = new BodyScanActivity("Body Scan", "This activity will allow you to slow down and guide your focus on your body, how it is feeling, and how it is interacting with the world around you.");
                body1.DisplayStartingMessage();
                body1.RunBodyScan();
                body1.DisplayEndingMessage("Body Scan");
            }
        }

        
    }
}