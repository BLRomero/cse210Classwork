using System;

class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected string _address;

    public Event(string eventTitle, string description, DateTime date, DateTime time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void PrintStandardDetails()
    {
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Time: {_time.ToShortTimeString()}");
        Console.WriteLine($"Address: {_address}");
    }

    public void PrintFullDetails()
    {
        PrintStandardDetails();
        
    }
}
