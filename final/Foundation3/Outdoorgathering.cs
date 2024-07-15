using System;
using System.Threading;

class OutdoorGathering : Event
{

    protected string _emailRSVP;

    public OutdoorGathering(string eventTitle, string description, DateTime date, DateTime time, string address) : base(eventTitle, description, date, time, address)
    {

    }



}