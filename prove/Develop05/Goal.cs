using System;
abstract class Goal
{
    protected string _name;
    protected int _points;


    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();
    public abstract void Deserialize(string data);

}