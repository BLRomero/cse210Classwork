using System;
using System.Collections.Generic;
using System.Linq;

class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected string _address;
    protected string _standardDetails;
    protected string _FullDetails;

    public Event(string eventTitle, string description, DateTime date, DateTime time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }




}