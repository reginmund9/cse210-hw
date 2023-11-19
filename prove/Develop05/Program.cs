using System;	
using System.Collections.Generic;
using System.IO;
class Program
{
    static List<Goal> goals;
    static void Main(string[] args)
    {
        
        goals = new List<Goal>();
        
        while (true)
        {
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals to File");
            Console.WriteLine("5. Load Goals from File");
            Console.WriteLine("6. Exit");
            Console.Write("Select a choice from the menu: ");
            
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
            }

            switch (choice)
            {
                case 1:
                    AddNewGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    SaveGoalsToFile();
                    break;
                case 5:
                    LoadGoalsFromFile();
                    break;
                case 6:
                    ExitProgram();
                    break;
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nThe Goals are:");
        
        foreach (var goal in goals)
        {
            goal.DisplayDetails();
            
            
        }
        
    }

    static void AddNewGoal()
    {
        

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal (can be marked complete)");
        Console.WriteLine("2. Eternal Goal (never complete, gains points each time)");
        Console.WriteLine("3. Checklist Goal (requires multiple completions for bonus points)");
        Console.Write("Which type would you like to create? ");
        int typeChoice;
        while (!int.TryParse(Console.ReadLine(), out typeChoice) || typeChoice < 1 || typeChoice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short of description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int basePoints;
        while (!int.TryParse(Console.ReadLine(), out basePoints) || basePoints <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        Goal newGoal;

        switch (typeChoice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, basePoints);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, basePoints);
                break;
            case 3:
                Console.Write("Enter the target completions for the checklist goal: ");
                int targetCompletions;
                while (!int.TryParse(Console.ReadLine(), out targetCompletions) || targetCompletions <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }

                Console.Write("Enter the bonus points for completing the checklist goal: ");
                int bonusPoints;
                while (!int.TryParse(Console.ReadLine(), out bonusPoints) || bonusPoints <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }

                newGoal = new ChecklistGoal(name, description, basePoints, targetCompletions, bonusPoints);
                break;
            default:
                throw new NotImplementedException("Invalid choice.");
        }

        goals.Add(newGoal);
        //Console.WriteLine($"New goal '{name}' added!");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to mark as complete:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]._name}");
        }

        int goalChoice;
        while (!int.TryParse(Console.ReadLine(), out goalChoice) || goalChoice < 1 || goalChoice > goals.Count)
        {
            Console.WriteLine($"Invalid choice. Please enter a number between 1 and {goals.Count}.");
        }

        Goal selectedGoal = goals[goalChoice - 1];
        selectedGoal.MarkComplete();
        DisplayTotalScore();
    }

    static void DisplayTotalScore()
    {
        int totalScore = 0;

        foreach (var goal in goals)
        {
            totalScore += goal.CalculatePoints();
        }
        Console.WriteLine($"\nTotal Score: {totalScore} points\n");
    }

    static void SaveGoalsToFile()
    {
        
        Console.Write("Enter the name of the file to save goals: ");
        string fileName = Console.ReadLine();
    
        FileManager.SaveGoals(goals, fileName);
        Console.WriteLine($"Goals and scores saved to file '{fileName}'.");
    }

    static void LoadGoalsFromFile()
    {
        Console.Write("Enter the name of the file to load goals: ");
        string fileName = Console.ReadLine();

        goals = FileManager.LoadGoals(fileName);
        
        Console.WriteLine($"Goals and scores loaded from file '{fileName}'.");
    }
    static void ExitProgram()
    {
        Console.WriteLine("Exiting program.");
        Environment.Exit(0);
    }

}
