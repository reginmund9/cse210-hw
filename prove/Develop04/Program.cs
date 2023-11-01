using System;
using System.Threading;

class Program
{
    static void Main(string[] args) 
    {
        // Create instances of activities
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity");
        ListingActivity listingActivity = new ListingActivity("Listing Activity");

        // Menu
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Choose an activity (1-3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            Console.Write("Choose an activity (1-3): ");
        }

        // Execute selected activity
        switch (choice)
        {
            case 1:
                ExecuteActivity(breathingActivity);
                break;
            case 2:
                ExecuteActivity(reflectionActivity);
                break;
            case 3:
                ExecuteActivity(listingActivity);
                break;
            default:
                break;
        }
    }

    static void ExecuteActivity(Activity activity)
    {
        activity.DisplayStartingMessage();
        activity.PerformActivity();
        activity.DisplayEndingMessage();
    }

}
