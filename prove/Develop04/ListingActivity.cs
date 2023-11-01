class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name) : base(name, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void PerformActivity()
    {
        Console.WriteLine("Get ready to start the listing activity.");
        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];

        Console.WriteLine(prompt);
        ShowSpinner(5); // Pause for 5 seconds before prompting to list items

        Console.WriteLine("Start listing items...");

        // Simulate user listing items for the specified duration
        ShowSpinner(Duration);

        Console.WriteLine($"You've listed {random.Next(5, 15)} items.");
    }
}
