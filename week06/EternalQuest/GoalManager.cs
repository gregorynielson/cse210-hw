

public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

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
    }

    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
            //[ ] then name then (description) then --how many completed if checklist
        }
    }

    public void CreateGoal()
    {
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
        //type of goal?
        //save name of goal to variable
        //save desc of goal to variable
        //how many points
        //if checklist, how many times to completion
    }

    public void RecordEvent()
    {
        Console.WriteLine("choose goal");
        //list goal names
        //choose which goal
        //update bool to complete if simple
        //update number of times done if checklist
        //apply points
    }

    public void SaveGoals()
    {
        Console.WriteLine("where to save");
        //enter filename
        //save to file in format
    }

    public void LoadGoals()
    {
        Console.WriteLine("load from file");
        //enter filename
        //add goals in file to list of Goals
    }

    // public void AddGoal(Goal goal)
    // {
    //     _goals.Add(goal);
    // }
}