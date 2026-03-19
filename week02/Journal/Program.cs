// To exceed requirements on this project, I added a question during the journal entry to ask for the user's
// mood on a scale from 1-10. This is saved with each journal entry and is shown when each entry is displayed.


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        PromptGenerator prompt1 = new PromptGenerator();

        int choice = 0;
        
        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("Please select one of the following choices:"); //display the menu to user
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Load entries");
            Console.WriteLine("4. Save entries");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? "); //ask user for input of what they want to do
            string choiceString = Console.ReadLine();
            choice = int.Parse(choiceString);

            if (choice == 1)
            {
                string _date = journal1.GetDate();
                Console.Write("How is your mood on a scale from 1 - 10, with 10 being the best? ");
                string _mood = Console.ReadLine();
                string _prompt = prompt1.GetRandomPrompt(); // generate random prompt
                Console.WriteLine($"{_prompt}");
                Console.Write("> "); // user enters journal entry
                string entry = Console.ReadLine();
                journal1._entries.Add($"{_date} | Mood: {_mood}/10 | {_prompt} >{entry}");
            }
            else if (choice == 2)
            {
                // display all entires
                journal1.DisplayEntries();
                
            }
            else if (choice == 3)
            {
                // ask for filename
                journal1.LoadEntries();
                
            }
            else if (choice == 4)
            {
                // ask for filename and save entries to file
                journal1.SaveEntry();
            }
            
        }

    }
}