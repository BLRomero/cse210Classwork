using System;
using System.Threading;

class Reception : Event
{

    protected string _emailRSVP;
    public Reception(string eventTitle, string description, DateTime date, DateTime time, string address):base (eventTitle, description,  date,  time, address)
    {
     }
}