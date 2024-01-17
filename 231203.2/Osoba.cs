using System;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int rokUrodzenia;
    private int waga;
    private int wzrost;
    private bool okulary;
    private Plec plec;

    public enum Plec
    {
        K,
        M
    }

    public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, bool okulary, Plec plec)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
        this.waga = waga;
        this.wzrost = wzrost;
        this.okulary = okulary;
        this.plec = plec;
    }

    private int AktualnyRok => DateTime.Now.Year;

    public int ObliczWiek()
    {
        return AktualnyRok - rokUrodzenia;
    }

    private string DodajPrzedrostek()
    {
        return plec == Plec.K ? "Pani" : "Pan";
    }

    public void WyswietlDane()
    {
        Console.WriteLine($"{imie} {nazwisko} ({ObliczWiek()} lat).");
    }

    public void WyswietlDaneZPrzedrostkiem()
    {
        Console.WriteLine($"Dyrektorem jest {DodajPrzedrostek()} {imie} {nazwisko} ({ObliczWiek()} lat).");
    }

    public double ObliczBMI()
    {
        double wzrostMetry = wzrost / 100.0;
        return waga / (wzrostMetry * wzrostMetry);
    }

    public void WyswietlStanZdrowia()
    {
        double bmi = ObliczBMI();

        if (bmi < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Wartość prawidłowa");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Nadwaga");
        }
        else
        {
            Console.WriteLine("Otyłość");
        }
    }
}
