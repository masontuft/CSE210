public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(points, name, description)
    {
        _points = points;
        _name = name;
        _desc = description;
    }
    public EternalGoal() : base()
    {
        _points = 0;
        _name = "";
        _desc = "";
    }

    public EternalGoal(string goal)
    {
        // figure out how to parse the string
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void Display()
    {

        Console.WriteLine($"[ ]Eternal Goal: {_name} - {_desc} ({_points} points)");
    }

    public override string GetRep()
    {
        return "EternalGoal~" + _name + "~" + _desc + "~" + _points;
    }

    public override int SetCompleted()
    {
        return _points;
    }


    // public override void DisplayGoal()
    // {
    //     Console.WriteLine($"Eternal Goal: {Name} - {Description} ({Points} points)");
    // }

    // public override void CompleteGoal()
    // {
    //     Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    // }
}