public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.Display();
        }
    }

    public void RecordEvent(Goal goal)
    {
        goal.MarkComplete();
        _totalScore += goal.GetPoints();
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void SaveToFile(string fileName)
    {
        Console.Write("What is the filename of the goal file? ");
        string userFileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(userFileName))
        {
            foreach (Goal goal in _goals)
            {
                goal.SaveToFile(writer);
            }
            writer.WriteLine($"TotalScore,{_totalScore}");
        }
        Console.WriteLine("Goals and total score saved to file.");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string userFileName = Console.ReadLine();

        _goals.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(userFileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(':');
                    if (parts.Length > 0)
                    {
                        if (parts[0] == "TotalScore")
                        {
                            _totalScore = int.Parse(parts[1]);
                        }
                        else
                        {
                            Goal goal;
                            string[] goalParts = parts[1].Split(',');
                            if (goalParts.Length == 4)
                            {
                                goal = new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                            }
                            else if (goalParts.Length == 6)
                            {
                                goal = new CheckListGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[3]), int.Parse(goalParts[4]));
                            }
                            else
                            {
                                goal = new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                            }

                            bool completed = bool.Parse(goalParts[goalParts.Length - 1]);
                            if (!completed)
                            {
                                goal.MarkComplete();
                            }

                            _goals.Add(goal);
                        }
                    }
                }
            }
            Console.WriteLine("Goals and total score loaded from file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Creating new goals list.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
    public int TotalScore
    {
        get { return _totalScore; }
    }

    public List<Goal> Goals
    {
        get { return _goals; }
    }
    
}