using System;
using System.Threading;

class Lecture: Event
{
    protected string _speakerName;
    protected int _capacity;

    public Lecture(string eventTitle, string descritption, DateTime date, DateTime time, string address,string speakerName, int capacity): base (eventTitle, descritption, date, time, address)
    {
       
    }
}