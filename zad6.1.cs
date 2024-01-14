using System;

class Prostokat
{
    private double dlugosc;
    private double szerokosc;

    public Prostokat(double dlugosc, double szerokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
    }

    private double Powierzchnia()
    {
        return dlugosc * szerokosc;
    }

    private double Obwod()
    {
        return 2 * (dlugosc + szerokosc);
    }

    public void Prezentuj()
    {
        Console.WriteLine($"Długość prostokąta: {dlugosc}");
        Console.WriteLine($"Szerokość prostokąta: {szerokosc}");
        Console.WriteLine($"Powierzchnia prostokąta: {Powierzchnia()}");
        Console.WriteLine($"Obwód prostokąta: {Obwod()}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Podaj długość prostokąta: ");
        double dlugosc = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj szerokość prostokąta: ");
        double szerokosc = Convert.ToDouble(Console.ReadLine());

        Prostokat prostokat = new Prostokat(dlugosc, szerokosc);
        prostokat.Prezentuj();
    }
}