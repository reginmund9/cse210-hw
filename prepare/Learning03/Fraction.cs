using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    // step4: Constructor with no parameters that initializes the number to 1/1.
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }
    // step4: Constructor that has one parameter for the top and that initializes the denominator to 1.
    //So that if you pass in the number 5, the fraction would be initialized to 5/1.

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

  // Step 3: Getters and setters for both the top and the bottom values
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        // Make sure the denominator is not zero
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}
