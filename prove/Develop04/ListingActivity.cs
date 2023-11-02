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
        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];

        Console.WriteLine("\nList as many responses you can to the following prompt");
        Console.WriteLine($"\n---{prompt}---"); 
        Console.Write("You may begin in: ");
        ShowSpinner(5);
        

        // Simulate user listing items for the specified duration
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int linesCount = 0;

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                // User pressed enter without typing anything, so break the loop
                break;
            }
            linesCount++;
        }

        Console.WriteLine($"You listed: {linesCount} items.");
    }
}

