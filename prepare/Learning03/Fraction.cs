using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

// Constructors
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    public Fraction (int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    // Methods
    // Get functions
    // public int GetNumerator()
    // {
    //     return _numerator;
    // }
    // public int GetDenominator()
    // {
    //     return _denominator;
    // }
    // Set functions
    // public void SetNumerator(int num)
    // {
    //     _numerator = num;
    // }
    // public void SetDenominator(int num)
    // {
    //     _denominator = num;
    // }
    public string GetFractionString()
    {
        string fract = $"{_numerator}/{_denominator}";
        return fract;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }
}   