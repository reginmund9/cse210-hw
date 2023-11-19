class Goal
{
    protected internal string _name;
    protected internal string _description;
    protected internal int _basePoints;
    protected internal int _currentProgress;

    public Goal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _currentProgress = 0;
    }

    public virtual void MarkComplete()
    {
        Console.WriteLine($"Goal '{_name}' marked as complete!");
        _currentProgress++;
    }

    public virtual int CalculatePoints()
    {
        return _basePoints;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void DisplayDetails()
    {

        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {_name} ({_description})");
        
    }
}

