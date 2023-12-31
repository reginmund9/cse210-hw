using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display activities menu
            Console.WriteLine("\nActivities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Dancing Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an activity (1-5): ");
            

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                Console.Write("Choose an activity (1-5): ");
            }

            if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Create instances of activities
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");
            ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity");
            ListingActivity listingActivity = new ListingActivity("Listing Activity");
            DancingActivity dancingActivity = new DancingActivity("Dancing Activity");

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
                case 4:
                ExecuteActivity(dancingActivity);
                    break;
                default:
                    break;
            }
        }
    }

    static void ExecuteActivity(Activity activity)
    {
        // Display common starting message
        activity.DisplayStartingMessage();

        // Set the duration for the chosen activity
        activity.SetDuration();

        // Perform the activity
        activity.PerformActivity();

        // Display common ending message
        activity.DisplayEndingMessage();
    }
}
