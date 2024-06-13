using System;
using System.Collections.Generic;

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
           
            Console.WriteLine("Welcome to our Mindfulness Program. \n Please select from the following options:");
            Console.WriteLine("1: Breating Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("Type 'q' to quit the program.");
            Console.WriteLine("What would you like to do?");
            input = Console.ReadLine().ToLower();

            switch (input)
            {
                 case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "You have completed the Breathing Activity.");
                    breathingActivity.Start();
                    break;

                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity(
                        "Reflection Activity", 
                        "You have completed the Reflection Activity."
                    );
                    reflectionActivity.Start();
                    break;
                    
                case "3":
                    Console.WriteLine(" Listing Activity");
                    break;
                case "q":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter '1', '2', '3', or 'q'.");
                    break;
            }
        }
    }

}




