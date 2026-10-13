public class EternalGoal : Goal
{
    private bool _isComplete;
    public EternalGoal()
    {
        _shortName = "Name of Eternal Goal";
        _description = "Description of Eternal Goal";
        _points = 100;
    }
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] Eternal Goal: {GetDetailsString()}";
    }

    public override string SaveGoal()
{
    return $"EternalGoal:{_shortName},{_description},{_points}";
}
}