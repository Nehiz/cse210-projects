using System;

public class Fraction
{
    private int topNumber;
    private int bottomNumber;

    // Parameterless Constructor
    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }


    // Constructor with one parameter for numerator
    public Fraction(int top)
    {
        topNumber = top;
        bottomNumber = 1;
    }

    // Constructor with two parameters for top and bottom numbers
    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

    // Getter and setter for top number
    public int TopNumber
    {
        get{ return topNumber; }
        set { topNumber = value; }
    }

    // Getter and setter for bottom number
    public int BottomNumber
    {
        get { return bottomNumber; }
        set { bottomNumber = value; }
    }

    // Method to return the fraction
    public string GetFractionString()
    {
        return $"{topNumber}/{bottomNumber}";
    }

    // method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double) topNumber / bottomNumber;
    }
}

