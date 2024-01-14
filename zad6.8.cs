using System;

class Prostopadloscian
{
    private double dlugosc;
    private double szerokosc;
    private double wysokosc;

    public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
        this.wysokosc = wysokosc;
    }

    public double Dlugosc
    {
        get { return dlugosc; }
        set { dlugosc = value; }
    }

    public double Szerokosc
    {
        get { return szerokosc; }
        set { szerokosc = value; }
    }

    public double Wysokosc
    {
        get { return wysokosc; }
        set { wysokosc = value; }
    }

    public double ObliczObjetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }

    public static bool PorownajObjetosci(Prostopadloscian prostopadloscian1, Prostopadloscian prostopadloscian2)
    {
        return prostopadloscian1.ObliczObjetosc() == prostopadloscian2.ObliczObjetosc();
    }
}

class Program
{
    static void Main()
    {
        Prostopadloscian prostopadloscian1 = new Prostopadloscian(3, 4, 5);
        Prostopadloscian prostopadloscian2 = new Prostopadloscian(2, 5, 6);

        Console.WriteLine($"Objętość prostopadłościanu 1: {prostopadloscian1.ObliczObjetosc()}");
        Console.WriteLine($"Objętość prostopadłościanu 2: {prostopadloscian2.ObliczObjetosc()}");

        bool czyRowne = Prostopadloscian.PorownajObjetosci(prostopadloscian1, prostopadloscian2);

        Console.WriteLine($"Czy objętości są równe: {czyRowne}");
    }
}
