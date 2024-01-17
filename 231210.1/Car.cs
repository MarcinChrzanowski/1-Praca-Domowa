using System;

public class Car
{
    private double pojemnoscSilnika;
    private string marka;
    private static int iloscKol;

    static Car()
    {
        iloscKol = 4;
    }

    private Car()
    {
        Console.WriteLine("Konstruktor domyślny");
    }

    private Car(double pojemnoscSilnika, string marka) : this()
    {
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;
    }

    public static Car CreateCar(double pojemnoscSilnika, string marka)
    {
        return new Car(pojemnoscSilnika, marka);
    }

    public static int IloscKol
    {
        get { return iloscKol; }
    }

    ~Car()
    {
        Console.WriteLine("Zwalniam pamięć");
    }
}
