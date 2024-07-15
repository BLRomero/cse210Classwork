using System;

class Program
{
    static void Main(string[] args)
    {
       
        Running runningActivity = new Running(new DateTime(2024, 11, 3), 30, 3);
        Cycling cyclingActivity = new Cycling(new DateTime(2024, 11, 3), 45, 15);
        Swimming swimmingActivity = new Swimming(new DateTime(2024, 11, 3), 60, 20);

        Console.WriteLine(runningActivity.GetSummary());
        Console.WriteLine(cyclingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}
