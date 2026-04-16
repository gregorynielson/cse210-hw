

public class Goal 
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        bool check = IsComplete();
        if (check == true)
        {
            return $"[X] {_shortName} ({_description}): {_points} points";
        }
        else 
        {
            return $"[ ] {_shortName} ({_description}): {_points} points";
        }
        
    }

    public virtual string GetStringRepresentation()
    {
        return "";   
    }

    public virtual int GetPoints()
    {
        int points = int.Parse(_points);
        return points;
    }


}