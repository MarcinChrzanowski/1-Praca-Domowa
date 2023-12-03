using System;

class Program
{
    static void Main()
    {
        int[,] macierzA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] macierzB = {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        int[,] macierzWynikowa = DodajMacierze(macierzA, macierzB);

        Console.WriteLine("Macierz A:");
        WyswietlMacierz(macierzA);

        Console.WriteLine("\nMacierz B:");
        WyswietlMacierz(macierzB);

        Console.WriteLine("\nMacierz Wynikowa (A + B):");
        WyswietlMacierz(macierzWynikowa);

        Console.ReadLine();
    }

    static int[,] DodajMacierze(int[,] macierzA, int[,] macierzB)
    {
        int rows = macierzA.GetLength(0);
        int cols = macierzA.GetLength(1);

        int[,] wynikowa = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                wynikowa[i, j] = macierzA[i, j] + macierzB[i, j];
            }
        }

        return wynikowa;
    }

    static void WyswietlMacierz(int[,] macierz)
    {
        int rows = macierz.GetLength(0);
        int cols = macierz.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{macierz[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
}
