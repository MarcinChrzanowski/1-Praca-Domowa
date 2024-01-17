using System;
using System.Collections.Generic;

public class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
}

public class Koszyk
{
    private List<Produkt> listaTowarow = new List<Produkt>();

    public void DodajProduktDoKoszyka(Produkt produkt)
    {
        listaTowarow.Add(produkt);
        Console.WriteLine($"Dodano produkt do koszyka: {produkt.Nazwa}, Cena: {produkt.Cena}");
    }

    public void PokazIloscISume()
    {
        Console.WriteLine($"Ilość produktów w koszyku: {listaTowarow.Count}");

        double sumaCen = 0;
        foreach (var produkt in listaTowarow)
        {
            sumaCen += produkt.Cena;
        }

        Console.WriteLine($"Suma cen: {sumaCen} PLN");
    }
}
