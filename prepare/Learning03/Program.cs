using System;

class Program
{
    static void Main(string[] args)
    {
        
       Fraction f1 = new Fraction(18);

       Console.WriteLine(f1.GetFractionString());

       Console.WriteLine(f1.GetDecimalValue());



       Fraction f2 = new Fraction(12,7);

       Console.WriteLine(f2.GetFractionString());

       Console.WriteLine(f2.GetDecimalValue());
    }
}