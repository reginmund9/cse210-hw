class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
        SetDuration();
    }

    private void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
        }
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine(Description);
        Console.WriteLine($"Prepare to begin. Starting in {Duration} seconds.");
        ShowSpinner(Duration);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Console.WriteLine($"You've spent {Duration} seconds on {Name}.");
        ShowSpinner(5); // Pause for 5 seconds before finishing
        Console.WriteLine("Activity finished. Goodbye!");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    public virtual void PerformActivity()
    {
        // This method will be overridden in derived classes
    }
    
}
