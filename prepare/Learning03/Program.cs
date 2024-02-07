using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction0 = new Fraction();
        Console.WriteLine(fraction0.GetFractionString());
        Console.WriteLine(fraction0.GetDeciamlValue());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDeciamlValue());

        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDeciamlValue());

        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDeciamlValue());

    }
}