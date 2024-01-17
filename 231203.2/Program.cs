using System;

class Program
{
    static void Main()
    {
        OpiszTyp();
        OpiszTyp("Tekst");
        OpiszTyp(42);
        OpiszTyp(3.14);

        Osoba osoba = new Osoba("Alina", "Kowalska", 1980, 70, 170, false, Osoba.Plec.K);
        osoba.WyswietlDane();

        osoba.WyswietlDaneZPrzedrostkiem();

        Console.WriteLine($"Obecny rok: {DateTime.Now.Year}");

        Osoba pacjent = new Osoba("Jan", "Nowak", 1995, 80, 180, false, Osoba.Plec.M);
        double bmi = pacjent.ObliczBMI();
        Console.WriteLine($"BMI pacjenta: {bmi}");
        pacjent.WyswietlStanZdrowia();
    }

    static void OpiszTyp()
    {
        Console.WriteLine("Brak argumentów - metoda przeciążona");
    }

    static void OpiszTyp(string tekst)
    {
        Console.WriteLine($"Tekst: {tekst}");
    }

    static void OpiszTyp(int liczba)
    {
        Console.WriteLine($"Liczba całkowita: {liczba}");
    }

    static void OpiszTyp(double liczbaZmiennoprzecinkowa)
    {
        Console.WriteLine($"Liczba zmiennoprzecinkowa: {liczbaZmiennoprzecinkowa}");
    }
}
