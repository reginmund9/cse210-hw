class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int basePoints) : base(name, description, basePoints) { }

    public override int CalculatePoints()
    {
        return _basePoints * _currentProgress;
    }
}

