class ChecklistGoal : Goal
{
    private int _targetCompletions;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int basePoints, int targetCompletions, int bonusPoints) : base(name, description, basePoints)
    {
        _targetCompletions = targetCompletions;
        _bonusPoints = bonusPoints;
    }

    public override void MarkComplete()
    {
        base.MarkComplete();

        if (_currentProgress >= _targetCompletions)
        {
            Console.WriteLine($"Congratulations! Bonus points earned: {_bonusPoints}");
        }
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _targetCompletions;
    }

    public override int CalculatePoints()
    {
        int regularPoints = _basePoints * _currentProgress;
        int totalPoints = IsComplete() ? regularPoints + _bonusPoints : regularPoints;
        return totalPoints;
    }

}