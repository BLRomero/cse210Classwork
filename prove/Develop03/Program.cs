using System;

class Program
{
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
            Console.WriteLine("1: Display a single verse");
            Console.WriteLine("2: Display multiple verses");
            Console.WriteLine("Would you like to Quit the program: type q");
            Console.WriteLine("What would you like to do?");
            input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "1":
                    Scripture.LoadSingleVerse();
                    break;

                case "2":
                    Scripture.LoadMultipleVerses();
                    break;

                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please enter a number between 1 and 5.");
                    break;
            }

        }
    }
}