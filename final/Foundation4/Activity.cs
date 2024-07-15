using System;

abstract class Activity
{
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int Duration
    {
        get { return _duration; }
    }

    public abstract float GetDistance(); 
    public abstract float GetSpeed();    
    public abstract float GetPace();    

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_duration} min)";
    }
}
