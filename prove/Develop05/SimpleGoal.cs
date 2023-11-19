class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int basePoints) : base(name, description, basePoints) { }

    public override bool IsComplete()
    {
        return _currentProgress > 0;
    }
}


