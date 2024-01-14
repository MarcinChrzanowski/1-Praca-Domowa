using System;

class Program
{
    static void Main()
    {
        int[] tablicaInt = { 1, 4, 6, 8, 2 };
        int mnoznikInt = 2;

        Console.WriteLine("Tablica przed mnożeniem (int):");
        WyswietlTablice(tablicaInt);

        int[] wynikowaTablicaInt = PomnozTablice(tablicaInt, mnoznikInt);
        Console.WriteLine("\nTablica po mnożeniu (wariant a) (int):");
        WyswietlTablice(wynikowaTablicaInt);

        PomnozTabliceWTablicy(tablicaInt, mnoznikInt);
        Console.WriteLine("\nTablica po mnożeniu (wariant b) (int):");
        WyswietlTablice(tablicaInt);


        string[] tablicaString = { "ala", "kot", "dom" };
        int mnoznikString = 2;

        Console.WriteLine("\n\nTablica przed mnożeniem (string):");
        WyswietlTablice(tablicaString);

        string[] wynikowaTablicaString = PomnozTablice(tablicaString, mnoznikString);
        Console.WriteLine("\nTablica po mnożeniu (wariant a) (string):");
        WyswietlTablice(wynikowaTablicaString);

        PomnozTabliceWTablicy(tablicaString, mnoznikString);
        Console.WriteLine("\nTablica po mnożeniu (wariant b) (string):");
        WyswietlTablice(tablicaString);
    }

    static int[] PomnozTablice(int[] tablica, int mnoznik)
    {
        int[] wynikowaTablica = new int[tablica.Length];

        for (int i = 0; i < tablica.Length; i++)
        {
            wynikowaTablica[i] = tablica[i] * mnoznik;
        }

        return wynikowaTablica;
    }

    static void PomnozTabliceWTablicy(int[] tablica, int mnoznik)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] *= mnoznik;
        }
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    static string[] PomnozTablice(string[] tablica, int mnoznik)
    {
        string[] wynikowaTablica = new string[tablica.Length];

        for (int i = 0; i < tablica.Length; i++)
        {
            wynikowaTablica[i] = PowielLancuch(tablica[i], mnoznik);
        }

        return wynikowaTablica;
    }

    static void PomnozTabliceWTablicy(string[] tablica, int mnoznik)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = PowielLancuch(tablica[i], mnoznik);
        }
    }

    static string PowielLancuch(string lancuch, int mnoznik)
    {
        return new string(lancuch.ToCharArray().SelectMany(c => Enumerable.Repeat(c, mnoznik)).ToArray());
    }

    static void WyswietlTablice(string[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}
