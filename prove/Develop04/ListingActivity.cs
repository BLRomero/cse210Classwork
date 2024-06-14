using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Whi has given you a helping hand this week?, what did they do?",
        "How have you felt the Holy Ghost today?",
        "Who is your hero?"
    };

    private static Random _random = new Random();

    public ListingActivity(string startingMessage, string endingMessage)
        : base(startingMessage, endingMessage)
    {
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Start()
    {
        Console.WriteLine(GetStartingMessage());
        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("Get ready to begin...");
            PauseWithCountdown(3);

            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            PauseWithCountdown(5); // Countdown for user to start thinking

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            Console.WriteLine("Start listing items. Press Enter after each item. When the time is up, you will see how many items you listed.");

            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"You listed {items.Count} items.");
            Console.WriteLine(GetEndingMessage());
            PauseWithCountdown(3);
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number.");
        }
    }
}
