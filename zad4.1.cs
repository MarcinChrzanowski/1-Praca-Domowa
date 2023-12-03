using System;
using Internal;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów tablicy: ");
        int n = int.Parse(Console.ReadLine());

        int[] tablica = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj wartość dla elementu {i + 1}: ");
            tablica[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nZawartość tablicy:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Element {i + 1}: {tablica[i]}");
        }

        Console.ReadLine();
    }
}
