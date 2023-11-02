class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name) : base(name, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void PerformActivity()
    {
        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);
        Console.WriteLine("\nConsider the following prompt:");

        // Show a single random prompt
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"\n---{prompt}---");

        // Ask the user to press enter to continue
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Display message to ponder on questions
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");

        // Display countdown timer
        Console.Write("You may begin in: ");
        ShowSpinner(5);
        Console.WriteLine();

        // Show two random questions with pauses based on the activity duration
        for (int i = 0; i < 2; i++)
        {
            string randomQuestion = reflectionQuestions[new Random().Next(reflectionQuestions.Length)];
            Console.WriteLine(randomQuestion);
            ShowSpinner(_duration / 2); // Pause for half of the activity duration
        }
    }
}
