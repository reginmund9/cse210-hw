using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string studentGrade = Console.ReadLine();
        int studentAnswer = int.Parse(studentGrade);

        
        if (studentAnswer >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (studentAnswer >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (studentAnswer >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (studentAnswer >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else 
        {
            Console.WriteLine("Your grade is: F");
        }


        if (studentAnswer >= 70)
        {
            Console.WriteLine("You passed!"); 
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }

    }   
}