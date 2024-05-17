using System;
using System.Collections.Generic;
using System.IO;

public class Save
{
    public static void _save(List<Entry> entries)
    {
        try
        {
            // Open or create the journal.txt file for writing
           using (StreamWriter writer = new StreamWriter("journal.txt", true))

            {
                // Write each entry to the file
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Content}");
                }
            }

            Console.WriteLine("Journal entries saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal entries: {ex.Message}");
        }

        // Wait for user input before returning
        Console.ReadLine();
    }
}
