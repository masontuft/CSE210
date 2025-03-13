public class ChecklistGoal : Goal
{
    private int _totalTimes;
    private int _bonusPoints;
    private int _timesCompleted;
    public ChecklistGoal(string name, string description, int points, int totalTimes, int bonusPoints, int timesCompleted) : base(points, name, description)
    {
        _points = points;
        _name = name;
        _desc = description;
        _totalTimes = totalTimes;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }
    public ChecklistGoal() : base()
    {
        _points = 0;
        _name = "";
        _desc = "";
        _totalTimes = 0;
        _bonusPoints = 0;
        _timesCompleted = 0;
    }

    public ChecklistGoal(string goal)
    {
        // figure out how to parse the string
    }

    public override int GetPoints()
    {
        if (_timesCompleted == _totalTimes)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override void Display()
    {
        if (_timesCompleted == _totalTimes)
        {
            Console.WriteLine($"[X]Checklist Goal: {_name} - {_desc} ({_points} points) - {_timesCompleted}/{_totalTimes} completed");
        }
        else
        {
            Console.WriteLine($"[ ]Checklist Goal: {_name} - {_desc} ({_points} points) - {_timesCompleted}/{_totalTimes} completed");
        }
    }

    public override string GetRep()
    {
        return "ChecklistGoal~" + _name + "~" + _desc + "~" + _points + "~" + _totalTimes + "~" + _bonusPoints + "~" + _timesCompleted;
    }
    public override int SetCompleted()
    {
        _timesCompleted++;
        if (_timesCompleted == _totalTimes)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }

    // public override void DisplayGoal()
    // {
    //     Console.WriteLine($"Checklist Goal: {Name} - {Description} ({Points} points)");
    // }

    // public override void CompleteGoal()
    // {
    //     Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    // }
}