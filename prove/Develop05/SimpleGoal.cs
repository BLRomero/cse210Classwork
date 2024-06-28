class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStatus()
    {
        return isComplete ? "[X]" : "[ ]";
    }
public override string Serialize()
    {
        return $"SimpleGoal|{_name}|{_points}|{isComplete}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _points = int.Parse(parts[2]);
        isComplete = bool.Parse(parts[3]);
    }
}
