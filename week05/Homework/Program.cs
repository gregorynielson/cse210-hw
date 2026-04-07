using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asmnt1 = new Assignment("Greg", "math");
        Console.WriteLine(asmnt1.GetSummary());
        Console.WriteLine("");

        MathAssignment math1 = new MathAssignment("Adrian", "Geometry", "4.3", "9-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment write1 = new WritingAssignment("Bryce", "Offensive Strategies", "Reading Defensive Structures");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}