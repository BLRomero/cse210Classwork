using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
       "What made this experience meaningful?",
        "Would you do this again?",
        "What made this experience meaningful?",
        "Would you do this again?",
        "How did this experience make you feel?",
        "What is your favorite part about this experience?",
        "How can you apply this to other experieinces you may have in the future?",
        "What did you learn from this expereince",
        "What things can you do to ensure you do not forget what you learned from this experience?",
        "What made this expereince successful?"    };

    private static Random _random = new Random();

    public ReflectionActivity(string startingMessage, string endingMessage)
        : base(startingMessage, endingMessage)
    {
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void Start()
    {
        Console.WriteLine(GetStartingMessage());
        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine("Get ready to begin...");
            PauseWithCountdown(3);

            Console.WriteLine(GetRandomPrompt());
            PauseWithCountdown(10); // Pause for reflection on the prompt

            int elapsed = 10;
            while (elapsed < duration)
            {
                Console.WriteLine(GetRandomQuestion());
                PauseWithCountdown(10); // pause for 5 seconds for each question
                elapsed += 10;
            }

            Console.WriteLine(GetEndingMessage());
            PauseWithCountdown(3);
            Console.WriteLine($"You have completed the Reflection Activity for {duration} seconds.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a valid number.");
        }
    }
}
