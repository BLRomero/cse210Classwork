using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Content { get; set; }

    // Constructor to initialize Date and Content
    public Entry(string date, string content)
    {
        Date = date;
        Content = content;
    }

    // Method to create a new entry with a random prompt
    public static Entry CreateEntry()
    {
        // Create an instance of PromptGenerator
        PromptGenerator promptGenerator = new PromptGenerator();

        // Get a random prompt
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("Enter the date (e.g., 5/20/24):");
        string date = Console.ReadLine();
        Console.WriteLine("Enter the content:");
        string content = Console.ReadLine();

        // Create a new Entry with the provided date, prompt, and content
        return new Entry(date, content) { Prompt = prompt };
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Content: {Content}");
    }
}
