public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    private bool _completed;

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._completed = false;
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{(_completed ? "X" : " ")}] {_name} ({_description})");
    }

    public virtual void MarkComplete()
    {
        _completed = true;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _completed;
    }

    public virtual void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"{GetType().Name}:{_name},{_description},{_points},{_completed}");
    }

    public string Name
    {
        get { return _name; }
    }
}


