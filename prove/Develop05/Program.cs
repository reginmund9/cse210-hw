using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();

        int choice;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal(goalManager);
                        DisplayTotalScore(goalManager);
                        break;
                    case 2:
                        goalManager.ListGoals();
                        DisplayTotalScore(goalManager);
                        break;
                    case 3:
                        goalManager.SaveToFile("goals.txt");
                        break;
                    case 4:
                        goalManager.LoadFromFile();
                        DisplayTotalScore(goalManager);
                        break;
                    case 5:
                        RecordEvent(goalManager);
                        DisplayTotalScore(goalManager);
                        break;
                    case 6:
                        Console.WriteLine("Quitting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
            }

        } while (choice != 6);
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                switch (goalType)
                {
                    case 1:
                        goalManager.AddGoal(new SimpleGoal(name, description, points));
                        break;
                    case 2:
                        goalManager.AddGoal(new EternalGoal(name, description, points));
                        break;
                    case 3:
                        Console.Write("How many times does the goal need to be accomplished for a bonus? ");
                        if (int.TryParse(Console.ReadLine(), out int bonusCount))
                        {
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                            {
                                goalManager.AddGoal(new CheckListGoal(name, description, points, bonusCount, bonusPoints));
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Bonus points must be a number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Bonus count must be a number.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Points must be a number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }
    }

    private static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("The goals are:");
        goalManager.ListGoals();
        for (int i = 0; i < goalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. \"{goalManager.Goals[i].Name}\"");
        }

        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= goalManager.Goals.Count)
        {
            Goal selectedGoal = goalManager.Goals[goalIndex - 1];
            goalManager.RecordEvent(selectedGoal);

            Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
       
    }

    private static void DisplayTotalScore(GoalManager goalManager)
    {
        Console.WriteLine($"You have {goalManager.TotalScore} points.");
        
    }
}


