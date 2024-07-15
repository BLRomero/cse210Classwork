using System;
using System.Threading;

class OutdoorGathering : Event
{
    protected string _weather;
    protected char _degreeSymbol = '\u00B0';


    public OutdoorGathering(string eventTitle, string description, DateTime date, DateTime time, string address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
        

    }
    public new void PrintFullDetails(){
        base.PrintFullDetails();
        Console.WriteLine($"Expected weather for Event: {_weather}{_degreeSymbol}F");
       
    }



}