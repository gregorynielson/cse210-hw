using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();

        fraction1.GetTop();
        fraction1.SetTop(4);
        fraction1.GetTop();
        fraction1.GetBottom();
        fraction1.SetBottom(4);
        fraction1.GetBottom();

        Fraction fraction2 = new Fraction(6);

        Fraction fraction3 = new Fraction(6, 7);
    }
}