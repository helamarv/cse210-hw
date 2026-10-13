using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _status;

    public Goal()
    {
        _shortName = "Default Short Name";
        _description = "Default Description";
        _points = 0;
        _status = false;
    }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _status = false;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points} points.";
    }

    public abstract string GetStringRepresentation();

    public int Points
    {
        get { return _points; }
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

}
