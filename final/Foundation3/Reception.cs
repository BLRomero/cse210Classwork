using System;
using System.Threading;

class Reception : Event
{
    public Reception(string eventTitle, string description, DateTime date, DateTime time, string address):base (eventTitle, description,  date,  time, address)
    {
     }
}