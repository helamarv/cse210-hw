using System;

public class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity()
    {
        _date = DateTime.Now;
        _length = 30;
    }
    
    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        // return $"{_date:dd MMM yyyy} ({_length} min)";
        return "";
    }
}