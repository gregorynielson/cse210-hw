using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        string letter = "";
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You received a(n) {letter}.");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}