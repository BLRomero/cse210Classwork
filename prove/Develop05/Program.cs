using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private const string filePath = "goals.txt";

    public void DisplayMenu()
    {
        Console.WriteLine("Eternal Quest Program");
        Console.WriteLine("1: Create a new Goal");
        Console.WriteLine("2: Record Event");
        Console.WriteLine("3: Show Goals");
        Console.WriteLine("4: Display Score");
        Console.WriteLine("5: Save Goals");
        Console.WriteLine("6: Load Goals");
        Console.WriteLine("7: Exit");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    RecordEvent();
                    break;

                case "3":
                    ShowGoals();
                    break;

                case "4":
                    DisplayScore();
                    break;

                case "5":
                    SaveGoals();
                    break;

                case "6":
                    LoadGoals();
                    break;

                case "7":
                    SaveGoals();
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type: \n1. Simple \n2. Eternal \n3. Checklist");
        string goalType = Console.ReadLine();
        Console.WriteLine("Enter Goal Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Points:");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.WriteLine("Enter Required Count:");
                int requiredCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Bonus Points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, requiredCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter Goal Index to Record Event:");
        int index = int.Parse(Console.ReadLine());
        if (index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].GetPoints(); // Ensure GetPoints() returns an int

            // If it is a ChecklistGoal, check for completion and add bonus points if applicable
            if (goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                score += checklistGoal.BonusPoints;
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].GetStatus()} {goals[i].GetName()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists(filePath))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(filePath);
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                Goal goal = null;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal("", 0);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal("", 0);
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal("", 0, 0, 0);
                        break;
                }
                goal.Deserialize(lines[i]);
                goals.Add(goal);
            }
        }
        else
        {
            Console.WriteLine("No save file found.");
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}
