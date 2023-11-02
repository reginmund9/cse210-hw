class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
        }
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You've spent {_duration} seconds on {_name}.");
        ShowSpinner(5); // Pause for 5 seconds before finishing
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public virtual void PerformActivity()
    {
        // This method will be overridden in derived classes
    }
}
