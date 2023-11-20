public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[{(IsCompleted() ? "X" : " ")}] {_name} ({_description}), Points: {GetPoints()} (Eternal)");
    }
}

