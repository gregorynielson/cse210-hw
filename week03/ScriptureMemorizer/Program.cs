
//to exceed requirements on this program, I added a text file with seven different scriptures
//everytime the user starts the program, a random scripture will be chosen from the file



using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture scrip1 = new Scripture();
        Word word1 = new Word(scrip1);
        string userChoice = "";

        Console.Clear();
        string[] scriptureParts = scrip1.GetScriptureParts();
        Reference ref1 = new Reference(scriptureParts[0], int.Parse(scriptureParts[1]), int.Parse(scriptureParts[2]), (scriptureParts[3]));

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.Write("Press enter to begin");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("");
        ref1.GetReferenceText();
        word1.DisplayScripture();
        Console.WriteLine("");

        
        Console.Write("Press enter to continue. Type quit to end.");
        userChoice = Console.ReadLine();
        Console.Clear();

        while (userChoice != "quit")
        {
            Console.WriteLine("");
            ref1.GetReferenceText();
            word1.HideRandomWord();
            Console.WriteLine("");

            Console.Write("Press enter to continue. Type quit to end.");
            userChoice = Console.ReadLine();
            Console.Clear();

            
        }
        
    }
}