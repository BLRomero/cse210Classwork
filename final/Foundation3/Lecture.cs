using System;

class Lecture : Event
{
    protected string _speakerName;
    protected int _capacity;

    public Lecture(string eventTitle, string description, DateTime date, DateTime time, string address, string speakerName, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public new void PrintFullDetails()
    {
        base.PrintFullDetails();
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}
