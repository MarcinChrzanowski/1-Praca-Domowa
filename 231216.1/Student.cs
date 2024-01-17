using System;

public class Student : Osoba
{
    protected int rok;
    protected string numerGrupy;
    protected string numerAlbumu;

    public Student(string imie, string nazwisko, int rokUrodzenia, int rok, string numerGrupy, string numerAlbumu)
        : base(imie, nazwisko, rokUrodzenia)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }

    public void WypiszInfoStudenta()
    {
        WypiszInfo();
        Console.WriteLine($"Rok: {rok}, Numer grupy: {numerGrupy}, Numer albumu: {numerAlbumu}");
    }
}
