using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string startingMessage, string endingMessage) : base(startingMessage, endingMessage)
    {
    }

    public void Start()
    {
        Console.WriteLine(GetStartingMessage());
        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("Get ready to begin...");
            PauseWithCountdown(3);

            int elapsed = 0;
            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in...");
                PauseWithCountdown(5); // pause for 5 seconds
                elapsed += 5;

                if (elapsed >= duration) break;

                Console.WriteLine("Breathe out...");
                PauseWithCountdown(5); // pause for 5 seconds
                elapsed += 5;
            }

            Console.WriteLine(GetEndingMessage());
            PauseWithCountdown(3);
            Console.WriteLine($"You have completed the Breathing Activity for {duration} seconds.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number.");
        }
    }
}
