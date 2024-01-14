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
        Prostokat[] prostokaty = new Prostokat[3];

        prostokaty[0] = new Prostokat(4, 6);
        prostokaty[1] = new Prostokat(5, 8);
        prostokaty[2] = new Prostokat(3, 7);

        foreach (Prostokat prostokat in prostokaty)
        {
            prostokat.Prezentuj();
            Console.WriteLine();
        }
    }
}
