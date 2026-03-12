using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int input = 0;
        int sum = 0;
        int biggestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);

            if (input != 0)
            {
                numbers.Add(input);
            }
            else
            { }
        } while (input != 0);

        foreach (int number in numbers)
        {
            sum += number;
            if (number > biggestNumber)
            {
                biggestNumber = number;
            }
            else
            {
                biggestNumber = biggestNumber;
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
    }
}