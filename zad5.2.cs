using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę rzeczywistą (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę rzeczywistą (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj trzecią liczbę rzeczywistą (x): ");
        double x = Convert.ToDouble(Console.ReadLine());

        bool czyNalezyDoPrzedzialu = SprawdzPrzedzial(a, b, x);

        if (czyNalezyDoPrzedzialu)
            Console.WriteLine($"{x} należy do przedziału obustronnie otwartego ({a}, {b}).");
        else
            Console.WriteLine($"{x} nie należy do przedziału obustronnie otwartego ({a}, {b}).");
    }

    static bool SprawdzPrzedzial(double a, double b, double x)
    {
        return x > a && x < b;
    }
}
