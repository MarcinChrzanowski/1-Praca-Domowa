using System;
using Internal;

class Program
{
    static void Main()
    {
        Console.Write("Podaj współrzędną x punktu A: ");
        double xA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu A: ");
        double yA = Convert.ToDouble(Console.ReadLine());

        double wektorX = 3;
        double wektorY = 2;

        Przesun(ref xA, ref yA, wektorX, wektorY);

        Console.WriteLine($"Współrzędne punktu A po przesunięciu o wektor [{wektorX}, {wektorY}] to ({xA}, {yA}).");
    }

    static void Przesun(ref double x, ref double y, double wektorX, double wektorY)
    {
        x += wektorX;
        y += wektorY;
    }
}
