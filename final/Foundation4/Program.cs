using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("November 20, 2023", 20, 3);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("Nov 22, 2023", 50, 15);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("November 25, 2023", 25, 20);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
