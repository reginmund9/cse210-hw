public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[{(IsCompleted() ? "X" : " ")}] {_name} ({_description}), Points: {GetPoints()}");
    }
}