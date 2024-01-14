using System;
using Internal;

class Program
{
    static void Main()
    {
        int[] tablica = { 1, 4, 6, 8, 2 };
        int mnoznik = 2;

        Console.WriteLine("Tablica przed mnożeniem:");
        WyswietlTablice(tablica);

        // Wariant a: Zastosowanie nowej tablicy wynikowej
        int[] wynikowaTablica = PomnozTablice(tablica, mnoznik);
        Console.WriteLine("\nTablica po mnożeniu (wariant a):");
        WyswietlTablice(wynikowaTablica);

        // Wariant b: Mnożenie bez tworzenia nowej tablicy wynikowej
        PomnozTabliceWTablicy(tablica, mnoznik);
        Console.WriteLine("\nTablica po mnożeniu (wariant b):");
        WyswietlTablice(tablica);
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
}
