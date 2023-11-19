class FileManager
{
    private const string fileName = " ";

    public static void SaveGoals(List<Goal> goals, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            int totalScore = goals.Sum(goal => goal.CalculatePoints());
            writer.WriteLine($"{totalScore}");
            
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal._name}, {goal._description}{goal._basePoints},{goal._currentProgress}");
            }
            
        }
    }
 

    public static List<Goal> LoadGoals(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                
                int totalScore;
                if (int.TryParse(reader.ReadLine(), out totalScore))
                {
                    Console.WriteLine($"Total Score: {totalScore} points");
                }
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 5)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int basePoints = int.Parse(parts[3]);
                        int currentProgress = int.Parse(parts[4]);

                        Goal goal;

                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(name, description, basePoints);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(name, description, basePoints);
                                break;
                            case nameof(ChecklistGoal):
                                goal = new ChecklistGoal(name, description, basePoints, currentProgress, 0);
                                break;
                            default:
                                throw new NotImplementedException($"Invalid goal type: {goalType}");
                        }

                        loadedGoals.Add(goal);
                    }
                }

            
            }
        }

        return loadedGoals;
    }
}


