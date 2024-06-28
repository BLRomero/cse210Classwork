class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStatus()
    {
        return "";
    }
    public override string Serialize()
    {
        return $"EternalGoal|{_name}|{_points}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _points = int.Parse(parts[2]);
    }
}
