using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Fraction Calculator!");

        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        foreach (Fraction f in new Fraction[] { f1, f2, f3, f4 })
        {
            Console.WriteLine($"Fraction: {f.GetFractionString()}");
            Console.WriteLine($"Decimal Value: {f.GetDecimalValue()}");
            Console.WriteLine();
        }
    }
}