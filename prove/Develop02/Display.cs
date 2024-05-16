using System;
using System.Collections.Generic;
using System.IO;

public class Display
{
    public static void _display()
    {
        // Specify the file name
        string fileName = "journal.txt";

        try
        {
            // Check if the file exists
            if (File.Exists(fileName))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(fileName);

                // Process each line (assuming each line represents an entry)
                foreach (string line in lines)
                {
                    // Split the line by the "|" character to separate date, prompt, and content
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        // Extract date, prompt, and content from the parts array
                        string date = parts[0].Trim();
                        string prompt = parts[1].Trim();
                        string content = parts[2].Trim();

                        // Display the entry
                        Console.WriteLine($"Date: {date}");
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.WriteLine($"Content: {content}");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("Journal entries displayed successfully.");
            }
            else
            {
                Console.WriteLine("Journal file not found.");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            Console.WriteLine($"Error displaying journal entries: {ex.Message}");
        }

        // Wait for user input before returning
        Console.ReadLine();
    }
}
