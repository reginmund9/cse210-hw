class BreathingActivity : Activity
{
    public BreathingActivity(string name) : base(name, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void PerformActivity()
    {
        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);

        for (int i = 0; i < _duration; i += 2)
        {
            Console.Write("\nBreathe in...");
            ShowSpinner(5);
            
            
            Console.Write("Breathe out...");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
}