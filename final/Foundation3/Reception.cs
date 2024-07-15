using System;
using System.Threading;

class Reception : Event
{

    protected string _emailRSVP;
    public Reception(string eventTitle, string description, DateTime date, DateTime time, string address, string emailRSVP):base (eventTitle, description,  date,  time, address)
    {
        _emailRSVP = emailRSVP;
     }

     public new void PrintFullDetails(){
        base.PrintFullDetails();
        Console.WriteLine($"RSVP to: {_emailRSVP}");
     }
}