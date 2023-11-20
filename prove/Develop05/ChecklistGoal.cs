public class CheckListGoal : Goal
{
    private int bonusCount;
    private int bonusPoints;

    public CheckListGoal(string name, string description, int points, int bonusCount, int bonusPoints) : base(name, description, points)
    {
        this.bonusCount = bonusCount;
        this.bonusPoints = bonusPoints;
    }

    public override void Display()
    {
        Console.WriteLine($"[{(IsCompleted() ? "X" : " ")}] {_name} ({_description}), Points: {GetPoints()}, Bonus: {bonusCount}/{bonusPoints}");
    }

    public override void MarkComplete()
    {
        base.MarkComplete();
        if (bonusCount >= bonusPoints)
        {
            Console.WriteLine($"Bonus Achieved! +{bonusPoints} points");
            _points += bonusPoints;
            
        }
        else
        {
            Console.WriteLine($"Goal Completed! +{GetPoints()} points");
        }
    }

    public void IncrementBonusCount()
    {
        bonusCount++;
    }

    public override void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"{GetType().Name}:{_name},{_description},{_points},{bonusCount},{bonusPoints},{IsCompleted()}");
    }
}
