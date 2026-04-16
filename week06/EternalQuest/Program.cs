
//To exceed requirements for this project I added a system to level up.
//The user will level up with every 100 points they earn. Once they level up,
//a congratulations message will appear on the screen letting them know. The program
//keeps track of the level with each save and load.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager game1 = new GoalManager();
        
        game1.Start();
    }
}