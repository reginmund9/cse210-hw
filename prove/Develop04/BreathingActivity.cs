class BreathingActivity : Activity
{
    public BreathingActivity(string name) : base(name, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void PerformActivity()
    {
        Console.WriteLine("Get ready to start the breathing exercise.");
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
        }
    }
}


