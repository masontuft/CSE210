using System;

public class SimpleGoal : Goal
{
    private bool _done;
    public SimpleGoal(string name, string description, int points, bool done) : base(points, name, description)
    {
        _points = points;
        _name = name;
        _desc = description;
        _done = done;
    }
    public SimpleGoal() : base()
    {
        _points = 0;
        _name = "";
        _desc = "";
        _done = false;
    }
    public SimpleGoal(string goal)
    {
        // figure out how to parse the string
    }


    public override bool IsComplete()
    {
        return _done;
    }

    public override void Display()
    {
        if (_done)
        {
            Console.WriteLine($"[X]Simple Goal: {_name} - {_desc} ({_points} points)");
        }
        else
        {
            Console.WriteLine($"[ ]Simple Goal: {_name} - {_desc} ({_points} points)");
        }
    }

    public override string GetRep()
    {
        return "SimpleGoal~" + _name + "~" + _desc + "~" + _points + "~" + _done;
    }

    public override int SetCompleted()
    {
        _done = true;
        return _points;
    }

    // public override void DisplayGoal()
    // {
    //     Console.WriteLine($"Simple Goal: {Name} - {Description} ({Points} points)");
    // }

    // public override void CompleteGoal()
    // {
    //     Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    // }
}