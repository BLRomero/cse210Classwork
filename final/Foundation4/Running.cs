using System;

class Running : Activity
{
    private float _distance; 

    public Running(DateTime date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return GetDistance() / (Duration / 60.0f);
    }

    public override float GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
    }
}
