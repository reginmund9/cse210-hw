using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int respNumb = -1;
        while (respNumb != 0)
        {
        
            Console.Write("Enter number: ");
            respNumb = int.Parse(Console.ReadLine());
            if (respNumb != 0)
            {
                numbers.Add(respNumb);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}");

        int largest = -1;
         foreach (int number in numbers)
        {
           if (number > largest)
            {
                largest = number;
            }
            
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}