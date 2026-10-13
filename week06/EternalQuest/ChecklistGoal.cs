public class ChecklistGoal : Goal
{
    private int _amountCompleated;
    private int _target;
    private int _bonus;

    public ChecklistGoal()
    {
        _shortName = "Name of Checklist Goal";
        _description = "Description of Checklist Goal";
        _points = 75;
        _amountCompleated = 0;
        _target = 5;
        _bonus = 50;
    }
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleated)
        : base(shortName, description, points)
    {
    _target = target;
    _bonus = bonus;
    _amountCompleated = amountCompleated;
    }

    public void CreateChildGoal()
    {
        CreateBaseGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _target = Convert.ToInt32(stringChecklistSteps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonus = Convert.ToInt32(bonus);
    }
    public override void RecordEvent()
    {
        if (_amountCompleated < _target)
        {
            _amountCompleated++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleated >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" Progress: {_amountCompleated}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[X] Checklist Goal: {GetDetailsString()}";
        }
        else
        {
            return $"[ ] Checklist Goal: {GetDetailsString()}";
        }
    }
    public int Bonus
    {
        get { return _bonus; }
    }
    public override string SaveGoal()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleated},{_target},{_bonus}";
    }
}