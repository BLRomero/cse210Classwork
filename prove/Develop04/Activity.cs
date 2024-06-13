using System;
using System.Threading;

public class Activity
{
    protected string _startingMessage;
    protected string _endingMessage;

    public Activity(string startingMessage, string endingMessage)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
    }

    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    public void SetStartingMessage(string startingMessage)
    {
        _startingMessage = startingMessage;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SetEndingMessage(string endingMessage)
    {
        _endingMessage = endingMessage;
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // 1000 milliseconds = 1 second
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }
}
