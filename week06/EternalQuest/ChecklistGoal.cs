

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        bool check = IsComplete();
        if (check == false)
        {
            _amountCompleted += 1;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        bool check = IsComplete();
        if (check == true)
        {
            return $"[X] {_shortName} ({_description}): {_points} points -- {_target}/{_target} completed for {_bonus} bonus points";
        }
        return $"[ ] {_shortName} ({_description}): {_points} points -- {_amountCompleted}/{_target} completed for {_bonus} bonus points";
    }

    public override string GetStringRepresentation()
    {
        return $"checklist|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override int GetPoints()
    {
        bool check = IsComplete();
        if (check == true)
        {
            int points = int.Parse(_points);
            int bonus = _bonus;
            _bonus = 0;
            return points + bonus;
        }
        else
        {
            int points = int.Parse(_points);
            return points;
        }
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }


}