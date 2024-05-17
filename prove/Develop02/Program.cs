using System;

class Program
{
    static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        MainMenu();

    }
    public static void MainMenu()
    {

        string input = "";
        while (input != "5")
        {
            Console.WriteLine("Welcome to Your Journal, Please select from the following choices:");
            Console.WriteLine("Option 1: Write ");
            Console.WriteLine("Option 2: Display ");
            Console.WriteLine("Option 3: Save ");
            Console.WriteLine("Option 4: Load ");
            Console.WriteLine("Option 5: Quit");
            Console.WriteLine("What would you like to do?");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Entry entry = Entry.CreateEntry();
                    entries.Add(entry); 
                    break;

                case "2":
                    Display._display();
                    break;

                case "3":
                    Save._save(entries);
                    break;

                case "4":
                    Load._load();
                    break;

                case "5":
                    Quit._quit();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please enter a number between 1 and 5.");
                    break;
            }

        }
    }
}