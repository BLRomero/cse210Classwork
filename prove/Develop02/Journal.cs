using System;
using System.Collections.Generic;
public class Journal
{
    public static void MainMenu()
    {
        // Console.Clear();
        Console.WriteLine("Welcome to Your Journal, Please select from the following choices:");
       
        Console.WriteLine("Option 1: Write ");
        Console.WriteLine("Option 2: Display ");
        Console.WriteLine("Option 3: Save ");
        Console.WriteLine("Option 4: Load ");
        Console.WriteLine("Option 5: Quit"); Console.WriteLine("What would you like to do?");
        string options = Console.ReadLine();

        switch (options)
        {
            case "1":
                Write();
                break;

            case "2":
                Display();
                break;

            case "3":
                Save();
                break;

            case "4":
                Load();
                break;

            case "5":
                Quit();
                break; 
            default:
                Console.WriteLine("Invalid Option. Please enter a number between 1 and 5.");
                break;               
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}