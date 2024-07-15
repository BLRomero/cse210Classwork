using System;

class Cycling : Activity
{
    private int _speed;



    public Cycling(DateTime date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        return _speed * (Duration / 60f);
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
        return $"{base.GetSummary()} Cycling - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
    }
}