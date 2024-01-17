using System;
using System.Collections.Generic;

enum Karta
{
    As = 1, Dwa, Trzy, Cztery, Piec, Szesc, Siedem, Osiem, Dziewiec, Dziesiec, Walet, Dama, Krol
}

class Program
{
    static void Main()
    {
        List<Karta> talia = new List<Karta> { Karta.As, Karta.Dwa, Karta.Trzy, Karta.Cztery, Karta.Piec, Karta.Szesc, Karta.Siedem, Karta.Osiem, Karta.Dziewiec, Karta.Dziesiec, Karta.Walet, Karta.Dama, Karta.Krol };
        List<Karta> gracz1Reka = new List<Karta>();
        List<Karta> gracz2Reka = new List<Karta>();

        for (int i = 0; i < 3; i++)
        {
            gracz1Reka.Add(RozdajKarte(talia));
            gracz2Reka.Add(RozdajKarte(talia));
        }

        Console.WriteLine("Gracz 1: " + string.Join(", ", gracz1Reka));
        Console.WriteLine("Gracz 2: " + string.Join(", ", gracz2Reka));

        Dictionary<int, string> tabliczkaMnozeniaRzymska = new Dictionary<int, string> { { 1, "I" }, { 2, "II" }, { 3, "III" } };

        foreach (var kvp in tabliczkaMnozeniaRzymska)
        {
            Console.WriteLine($"{kvp.Key} * {kvp.Key} = {kvp.Value}");
        }
    }

    static Karta RozdajKarte(List<Karta> talia)
    {
        Random random = new Random();
        int indeks = random.Next(talia.Count);
        Karta karta = talia[indeks];
        talia.RemoveAt(indeks);
        return karta;
    }
}
