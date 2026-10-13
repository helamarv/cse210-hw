using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal()
    {
        _shortName = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 50;
        _isComplete = false;
    }

    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
            return $"[X] Simple Goal: {GetDetailsString()}";
        }
        else
        {
            return $"[ ] Simple Goal: {GetDetailsString()}";
        }
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

}