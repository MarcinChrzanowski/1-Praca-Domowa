using System;

public class Zespolone
{
    public double Re { get; set; }
    public double Im { get; set; }

    public Zespolone(double re, double im)
    {
        Re = re;
        Im = im;
    }

    public static Zespolone Dodaj(Zespolone z1, Zespolone z2)
    {
        return new Zespolone(z1.Re + z2.Re, z1.Im + z2.Im);
    }

    public static Zespolone Odejmij(Zespolone z1, Zespolone z2)
    {
        return new Zespolone(z1.Re - z2.Re, z1.Im - z2.Im);
    }

    public static Zespolone Pomnoz(Zespolone z1, Zespolone z2)
    {
        return new Zespolone((z1.Re * z2.Re) - (z1.Im * z2.Im), (z1.Re * z2.Im) + (z1.Im * z2.Re));
    }

    public static Zespolone Podziel(Zespolone z1, Zespolone z2)
    {
        double dzielnik = (z2.Re * z2.Re) + (z2.Im * z2.Im);
        return new Zespolone(((z1.Re * z2.Re) + (z1.Im * z2.Im)) / dzielnik, ((z1.Im * z2.Re) - (z1.Re * z2.Im)) / dzielnik);
    }

    public void Wyswietl()
    {
        Console.WriteLine($"{Re} + {Im}i");
    }
}
