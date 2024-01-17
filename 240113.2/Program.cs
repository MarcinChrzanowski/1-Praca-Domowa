using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Osoba
{
    private string imie;
    private int wiek;

    public Osoba() { }

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
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Queue queue = new Queue();
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");
        queue.Enqueue("E");

        List<Osoba> listaOsob = new List<Osoba>
        {
            new Osoba("Anna", 25),
            new Osoba("Bartek", 30),
            new Osoba("Celina", 22),
            new Osoba("Dariusz", 28),
            new Osoba("Ewa", 35)
        };

        foreach (var osoba in listaOsob)
        {
            Console.WriteLine($"Imię: {osoba.PobierzImie()}, Wiek: {osoba.PobierzWiek()}");
        }

        Console.WriteLine($"\nPierwszy element w Stack: {stack.Peek()}");
        Console.WriteLine($"Trzeci element w Queue: {queue.ToArray()[2]}");
        Console.WriteLine($"Ostatni element w List<Osoba>: {listaOsob[listaOsob.Count - 1].PobierzImie()}");

        Console.WriteLine($"\nLiczba elementów w Stack: {stack.Count}");
        Console.WriteLine($"Liczba elementów w Queue: {queue.Count}");
        Console.WriteLine($"Liczba elementów w List<Osoba>: {listaOsob.Count}");

        Console.WriteLine($"\nPojemność Stack: Nie dotyczy");
        Console.WriteLine($"Pojemność Queue: Nie dotyczy");
        Console.WriteLine($"Pojemność List<Osoba>: Nie dotyczy");

        listaOsob.RemoveAt(3);

        listaOsob.Reverse();

        Console.WriteLine("\nOdwrocona lista osób:");
        foreach (var osoba in listaOsob)
        {
            Console.WriteLine($"Imię: {osoba.PobierzImie()}, Wiek: {osoba.PobierzWiek()}");
        }
    }
}
