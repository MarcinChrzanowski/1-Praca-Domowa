using System;

class Program
{
    static void Main()
    {
        double temperaturaFahrenheit = 98.6;
        double temperaturaCelsjusza = KonwertujNaCelsjusze(temperaturaFahrenheit);

        Console.WriteLine($"{temperaturaFahrenheit} stopni Fahrenheit to {temperaturaCelsjusza} stopni Celsjusza.");
    }

    static double KonwertujNaCelsjusze(double temperaturaFahrenheit)
    {
        return (temperaturaFahrenheit - 32) * 5 / 9;
    }
}
