using System;

class Swimming : Activity
{
    private int _laps; 

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50f / 1609.34f; 
    }

    public override float GetSpeed()
    {
        return GetDistance() / (Duration / 60f);
    }

    public override float GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
    }
}
