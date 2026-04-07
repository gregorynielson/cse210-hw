using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity act1 = new Activity();
        int _choice = 0;

        while (_choice != 4)
        {
            Console.WriteLine("Mindfulness Activities Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select one of the activities: ");
            string choiceStr = Console.ReadLine();
            _choice = int.Parse(choiceStr);

            if (_choice == 1)
            {
                act1.DisplayStartingMessage();
            }
        }

        
    }
}