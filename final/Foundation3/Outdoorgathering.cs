using System;
using System.Threading;

class OutdoorGathering : Event
{
    protected string _weather;

    public OutdoorGathering(string eventTitle, string description, DateTime date, DateTime time, string address) : base(eventTitle, description, date, time, address)
    {

    }
    public void FullDetails()
    {
        Console.WriteLine($"Event: {_eventTitle}\n{_description}\nDate & Time: {_date}, {_time}\n{_address}\n{_weather}");
    }



}