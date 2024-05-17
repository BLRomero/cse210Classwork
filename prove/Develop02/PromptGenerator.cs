using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;
    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "What blessings did you see today?",
            "What challenge or obstacle did you face and how did you overcome it? ",
            "Is there a skill or hobby you want to learn, tell me about your plan to learn.",
            "Write a memorable conversation you had today?  Why is it memorable? What did you learn from it? ",
            "What are you grateful for and why? ",
            "Who are your most important people and what have you done to ensure they know they are important? ",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",


        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}