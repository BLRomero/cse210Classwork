class ChecklistGoal : Goal
{
    private int requiredCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints)
        : base(name, points)
    {
        this.requiredCount = requiredCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (currentCount < requiredCount)
        {
            currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return currentCount >= requiredCount;
    }

    public override string GetStatus()
    {
        return IsComplete() ? $"[X] Completed {currentCount}/{requiredCount}" : $"[ ] Completed {currentCount}/{requiredCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{_name}|{_points}|{currentCount}|{requiredCount}|{bonusPoints}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _points = int.Parse(parts[2]);
        currentCount = int.Parse(parts[3]);
        requiredCount = int.Parse(parts[4]);
        bonusPoints = int.Parse(parts[5]);
    }

    public int BonusPoints => bonusPoints;
}
