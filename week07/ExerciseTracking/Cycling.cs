public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed;
    }

    public override double GetSpeed()
    {
        return _speed / _length * 60;
    }

    public override double GetPace()
    {
        return _length / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_length} min) - Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min per km";
    }
}