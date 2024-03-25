using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Fraction class using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // set values using setters
        fraction1.TopNumber = 1;
        fraction1.BottomNumber = 1;

        // Get values using getters
        int top = fraction1.TopNumber;
        int bottom = fraction1.BottomNumber;

        // Display the fraction as a string and its decimal value
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}