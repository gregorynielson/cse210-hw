using System.IO;

public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;
    private int _level = 1;
    private int _levelUp = 100;

    public void Start()
    {
        int _choice = 0;
        while (_choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Eternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do: ");
            string choiceStr = Console.ReadLine();
            _choice = int.Parse(choiceStr);

            if (_choice == 1)
            {
                CreateGoal();
            }
            else if (_choice == 2)
            {
                ListGoals();
            }
            else if (_choice == 3)
            {
                SaveGoals();
            }
            else if (_choice == 4)
            {
                LoadGoals();
            }
            else if (_choice == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
        Console.WriteLine($"You are level {_level}");
    }

    public void ListGoals()
    {
        Console.Clear();
        int listNum = 1;
        foreach (Goal goal in _goals)
        {
            string number = listNum.ToString();
            Console.Write($"{number}. ");
            Console.WriteLine(goal.GetDetailsString());
            listNum += 1;
        }
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal: ");
        string goalType = Console.ReadLine();
        int type = int.Parse(goalType);

        if (type == 1)
        {
            Console.Write("Name of goal: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("How many points: ");
            string points = Console.ReadLine();
            SimpleGoal simple1 = new SimpleGoal($"{name}", $"{description}", $"{points}");
            _goals.Add(simple1);
        }

        if (type == 2)
        {
            Console.Write("Name of goal: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("How many points: ");
            string points = Console.ReadLine();
            EternalGoal eternal1 = new EternalGoal($"{name}", $"{description}", $"{points}");
            _goals.Add(eternal1);
        }

        if (type == 3)
        {
            Console.Write("Name of goal:");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("How many points: ");
            string points = Console.ReadLine();
            Console.Write("How many times do you want to complete this goal: ");
            string numTimes = Console.ReadLine();
            int target = int.Parse(numTimes);
            Console.Write("How many bonus points will this earn: ");
            string bonusPoints = Console.ReadLine();
            int bonus = int.Parse(bonusPoints);
            ChecklistGoal checklist1 = new ChecklistGoal($"{name}", $"{description}", $"{points}", target, bonus);
            _goals.Add(checklist1);
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("");
        int listNum = 1;
        foreach (Goal goal1 in _goals)
        {
            
            string number = listNum.ToString();
            Console.Write($"{number}. ");
            Console.WriteLine(goal1.GetDetailsString());
            listNum += 1;
        }

        Console.WriteLine("");
        Console.Write("For which goal would you like to record an event: ");
        string choiceStr = Console.ReadLine();
        int choice = int.Parse(choiceStr);

        int indexOfChoice = -1 + choice;

        Goal goal = _goals[indexOfChoice];
        goal.RecordEvent();
        int points = goal.GetPoints();
        _score += points;

        DidYouLevelUp();

    }

    public void SaveGoals()
    {
        Console.WriteLine("");
        Console.Write("Enter a filename: ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"{_score}|{_level}|{_levelUp}");
            foreach (Goal goal in _goals)
            {
                string fileText = goal.GetStringRepresentation();
                outputFile.WriteLine(fileText);
            }  
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter a filename: ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];

            if (goalType == "simple")
            {
                SimpleGoal simple = new SimpleGoal($"{parts[1]}", $"{parts[2]}", $"{parts[3]}");
                bool complete = bool.Parse(parts[4]);
                simple.SetIsComplete(complete);
                _goals.Add(simple);
            }
            else if (goalType == "eternal")
            {
                EternalGoal eternal = new EternalGoal($"{parts[1]}", $"{parts[2]}", $"{parts[3]}");
                _goals.Add(eternal);
            }
            else if (goalType == "checklist")
            {
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                
                ChecklistGoal checklist = new ChecklistGoal($"{parts[1]}", $"{parts[2]}", $"{parts[3]}", target, bonus);
                int amountCompleted = int.Parse(parts[4]);
                checklist.SetAmountCompleted(amountCompleted);
                _goals.Add(checklist);
            }
            else {
                int score = int.Parse(parts[0]);
                int level = int.Parse(parts[1]);
                int levelUp = int.Parse(parts[2]);
                _score = score;
                _level = level;
                _levelUp = _levelUp;
            }
        }

    }

    public void DidYouLevelUp()
    {
        if (_score >= _levelUp)
        {
            Console.WriteLine("");
            Console.WriteLine("Congratulations!");
            Console.Write("");
            Thread.Sleep(2000);
            Console.WriteLine("You have leveled up!");
            Console.WriteLine("");
            Thread.Sleep(2000);
            _levelUp += 100;
            _level += 1;
        }
    }
}