using System;

public class Osoba
{
    protected string imie;
    protected string nazwisko;
    protected int rokUrodzenia;
    private string miejsceZamieszkania;

    public Osoba(string imie, string nazwisko, int rokUrodzenia)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
    }

    public void WypiszInfo()
    {
        Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Rok urodzenia: {rokUrodzenia}");
    }

    protected void ObliczWiek()
    {
        int aktualnyRok = DateTime.Now.Year;
        int wiek = aktualnyRok - rokUrodzenia;
        Console.WriteLine($"Wiek: {wiek} lat");
    }
}
