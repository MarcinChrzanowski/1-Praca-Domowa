using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów tablicy: ");
        int n = int.Parse(Console.ReadLine());

        int[] tab1 = new int[n];
        int[] tab2 = new int[n];

        Console.WriteLine("Wprowadź wartości dla tablicy tab1:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            tab1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            tab2[(i + 1) % n] = tab1[i];
        }

        Console.WriteLine("\nZawartość tablicy tab1:");
        WyswietlTablice(tab1);

        Console.WriteLine("\nZawartość tablicy tab2 (z przesunięciem o jedną pozycję):");
        WyswietlTablice(tab2);

        Console.ReadLine();
    }

    static void WyswietlTablice(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine();
    }
}
