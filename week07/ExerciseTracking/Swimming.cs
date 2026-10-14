public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int length, double laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50; // Assuming each lap is 50 meters
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Swimming ({_length} min) - Laps: {_laps}, Distance: {GetDistance():F2} m, Speed: {GetSpeed():F2} m/min, Pace: {GetPace():F2} min per 50 m";
    }
}