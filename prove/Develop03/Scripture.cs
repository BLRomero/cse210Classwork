using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    
    public static void LoadSingleVerse()
    {
        // Specify the file name
        string fileName = "scripture.txt";

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
                        string bookChapter = parts[0].Trim();
                        int verse = int.Parse(parts[1].Trim());
                        string content = parts[2].Trim();
                        

                        // Display the entry (you can modify this part to parse and store entries)
                        Console.WriteLine($"{bookChapter} {verse}");
                        Console.WriteLine($"{content}");
                        Console.WriteLine();
                        break;
                    }
                }

                Console.WriteLine("Single verse loaded successfully.");
            }
            else
            {
                Console.WriteLine("Scripture file not found.");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            Console.WriteLine($"Error loading scripture: {ex.Message}");
        }

        // Wait for user input before returning
        Console.ReadLine();
    }
    public static void LoadMultipleVerses(){
         string fileName = "scripture.txt";

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
                        string bookChapter = parts[0].Trim();
                        int verse = int.Parse(parts[1].Trim());
                        string content = parts[2].Trim();
                        

                        // Display the entry (you can modify this part to parse and store entries)
                        Console.WriteLine($"{bookChapter} {verse}");
                        Console.WriteLine($"{content}");
                        Console.WriteLine();
                    
                    }
                }

                Console.WriteLine("Single verse loaded successfully.");
            }
            else
            {
                Console.WriteLine("Scripture file not found.");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            Console.WriteLine($"Error loading scripture: {ex.Message}");
        }

        // Wait for user input before returning
        Console.ReadLine();
    }
}

    