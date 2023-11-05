class DancingActivity : Activity
{
    public DancingActivity(string name) : base(name, "This activity will help you relax and recharge energy by dancing your favorite song.") { }

    public override void PerformActivity()
    {
        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);

        // Ask the user to look up their favorite song on YouTube
        Console.Write("Look for your song on YouTube or any other place.");
        

        // Ask the user to press enter to continue
        Console.WriteLine("\nWhen you're ready, press enter to continue.");
        Console.ReadLine();

        // Display countdown timer
        Console.Write("You may begin in: ");
        ShowSpinner(5);
        

        // Simulate user dancing for the specified duration
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // Simulate dancing steps
            Console.WriteLine("Hands up!\nMove your body!\n");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second 
        }
    }

}
