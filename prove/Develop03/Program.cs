using System;
using System.Collections.Generic;

class Program
{
    static List<Scripture> scriptures;

    static void Main(string[] args)
    {
        MainMenu();
    }

    public static void MainMenu()
    {
        string input = "";
        while (input != "q")
        {
            Console.WriteLine("Welcome to Scripture Memorizer, Please select from the following choices:");
            Console.WriteLine("1: Display and hide words in a single verse");
            Console.WriteLine("2: Display and hide words in multiple verses");
            Console.WriteLine("Type 'q' to quit the program.");
            Console.WriteLine("What would you like to do?");
            input = Console.ReadLine().ToLower();
           
            switch (input)
            {
                case "1":
                    scriptures = Scripture.LoadVerses("scripture.txt");
                    if (scriptures.Count > 0)
                    {
                        Scripture.DisplayVerses(new List<Scripture> { scriptures[0] });
                        int wordsToHide = PromptForWordCount(new List<Scripture> { scriptures[0] });
                        Scripture.HideWords(new List<Scripture> { scriptures[0] }, wordsToHide);
                    }
                    break;

                case "2":
                    scriptures = Scripture.LoadVerses("scripture.txt");
                    Scripture.DisplayVerses(scriptures);
                    int totalWordsToHide = PromptForWordCount(scriptures);
                    Scripture.HideWords(scriptures, totalWordsToHide);
                    break;

                case "q":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter '1', '2', or 'q'.");
                    break;
            }
        }
    }

    public static int PromptForWordCount(List<Scripture> scriptures)
    {
        int totalWordCount = 0;
        foreach (var scripture in scriptures)
        {
            totalWordCount += scripture.WordCount();
        }

        Console.WriteLine($"Enter the number of words to hide (maximum {totalWordCount}):");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            if (count > totalWordCount)
            {
                Console.WriteLine($"You entered too many words. Hiding the maximum available: {totalWordCount} words.");
                return totalWordCount;
            }
            return count;
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a valid number.");
            return PromptForWordCount(scriptures); // Retry on invalid input
        }
    }
}
