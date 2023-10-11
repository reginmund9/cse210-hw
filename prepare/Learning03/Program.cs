using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

       // Step 3: Test getters and setters
        f1.SetTop(3);
        f1.SetBottom(4);

        Console.WriteLine($"Updated fraction: {f1.GetTop()}/{f1.GetBottom()}");

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}

