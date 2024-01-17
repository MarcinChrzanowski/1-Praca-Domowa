using System;

public class Obliczenia
{
    private double liczba1;
    private double liczba2;

    public Obliczenia(double liczba1, double liczba2)
    {
        this.liczba1 = liczba1;
        this.liczba2 = liczba2;
    }

    public double Dodawanie()
    {
        return liczba1 + liczba2;
    }

    public double Odejmowanie()
    {
        return liczba1 - liczba2;
    }

    public double Mnozenie()
    {
        return liczba1 * liczba2;
    }

    public double Dzielenie()
    {
        if (liczba2 == 0)
            throw new ArgumentException("Nie można dzielić przez zero.");

        return liczba1 / liczba2;
    }

    public double Potegowanie()
    {
        return Math.Pow(liczba1, liczba2);
    }

    public double Pierwiastkowanie()
    {
        if (liczba1 < 0)
            throw new ArgumentException("Nie można pierwiastkować z liczby ujemnej.");

        return Math.Sqrt(liczba1);
    }
}
