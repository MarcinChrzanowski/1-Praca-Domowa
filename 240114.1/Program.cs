using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

class Osoba
{
    private string imie;
    private int wiek;

    public Osoba()
    {
    }

    public Osoba(string imie, int wiek)
    {
        this.imie = imie;
        this.wiek = wiek;
    }

    public void UstawImie(string imie)
    {
        this.imie = imie;
    }

    public void UstawWiek(int wiek)
    {
        this.wiek = wiek;
    }

    public string PobierzImie()
    {
        return imie;
    }

    public int PobierzWiek()
    {
        return wiek;
    }
}

class Program
{
    static void Main()
    {
        List<int> listaLiczb = new List<int> { 1, 2, 3, 4, 5 };
        Stack<string> stosStringow = new Stack<string>();
        Dictionary<string, Osoba> slownikOsob = new Dictionary<string, Osoba>();

        stosStringow.Push("Element1");
        stosStringow.Push("Element2");
        stosStringow.Push("Element3");

        slownikOsob.Add("Osoba1", new Osoba("Jan", 25));
        slownikOsob.Add("Osoba2", new Osoba("Anna", 30));
        slownikOsob.Add("Osoba3", new Osoba("Marek", 22));
        slownikOsob.Add("Osoba4", new Osoba("Kasia", 28));
        slownikOsob.Add("Osoba5", new Osoba("Piotr", 35));

        Console.WriteLine("Lista Liczb:");
        foreach (var liczba in listaLiczb)
        {
            Console.WriteLine(liczba);
        }

        Console.WriteLine("\nStos Stringów:");
        foreach (var element in stosStringow)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nSlownik Osób:");
        foreach (var kvp in slownikOsob)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value.PobierzImie()}, {kvp.Value.PobierzWiek()} lat");
        }

        int pierwszyElementListy = listaLiczb.First();
        string pierwszyElementStosu = stosStringow.First();
        Osoba pierwszaOsoba = slownikOsob.First().Value;

        listaLiczb.Sort();
        stosStringow = new Stack<string>(stosStringow.OrderBy(s => s));
        slownikOsob = slownikOsob.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        Console.WriteLine("\nPosortowana Lista Liczb:");
        foreach (var liczba in listaLiczb)
        {
            Console.WriteLine(liczba);
        }

        Console.WriteLine("\nPosortowany Stos Stringów:");
        foreach (var element in stosStringow)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nPosortowany Slownik Osób:");
        foreach (var kvp in slownikOsob)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value.PobierzImie()}, {kvp.Value.PobierzWiek()} lat");
        }

        Console.WriteLine($"\nLiczba elementów w Liście Liczb: {listaLiczb.Count}");
        Console.WriteLine($"Pojemność Listy Liczb: {((List<int>)listaLiczb).Capacity}");

        Console.WriteLine($"Liczba elementów w Stosie Stringów: {stosStringow.Count}");
        Console.WriteLine($"Pojemność Stosu Stringów: Niedostępne dla Stack<T>");

        Console.WriteLine($"Liczba elementów w Slowniku Osób: {slownikOsob.Count}");
        Console.WriteLine($"Pojemność Slownika Osób: Niedostępne dla Dictionary<TKey, TValue>");

        listaLiczb.RemoveAt(3);
        stosStringow.Pop(); 
        slownikOsob.Remove("Osoba4");

        listaLiczb.Reverse();
        stosStringow = new Stack<string>(stosStringow.Reverse());
        slownikOsob = slownikOsob.OrderByDescending(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        Console.WriteLine("\nLista Liczb po usunięciu i odwróceniu:");
        foreach (var liczba in listaLiczb)
        {
            Console.WriteLine(liczba);
        }

        Console.WriteLine("\nStos Stringów po usunięciu i odwróceniu:");
        foreach (var element in stosStringow)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nSlownik Osób po usunięciu i odwróceniu:");
        foreach (var kvp in slownikOsob)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value.PobierzImie()}, {kvp.Value.PobierzWiek()} lat");
        }
    }
}
