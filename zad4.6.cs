using System;

class Program
{
    static void Main()
    {
        double[,] tablica = {
            { 1.1, 2.2, 3.3, 4.4, 5.5 },
            { 6.6, 7.7, 8.8, 9.9, 10.1 },
            { 11.1, 12.2, 13.3, 14.4, 15.5 },
            { 16.6, 17.7, 18.8, 19.9, 20.1 },
            { 21.1, 22.2, 23.3, 24.4, 25.5 }
        };

        Console.WriteLine("Elementy tablicy (wiersz po wierszu):");
        WyswietlTablice(tablica);

        double sumaPrzekatnej = SumaPrzekatnej(tablica);
        Console.WriteLine($"\nSuma elementów na głównej przekątnej: {sumaPrzekatnej}");

        Console.ReadLine();
    }

    static void WyswietlTablice(double[,] tablica)
    {
        int rows = tablica.GetLength(0);
        int cols = tablica.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{tablica[i, j],6} ");
            }
            Console.WriteLine();
        }
    }

    static double SumaPrzekatnej(double[,] tablica)
    {
        int n = Math.Min(tablica.GetLength(0), tablica.GetLength(1));
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            suma += tablica[i, i];
        }

        return suma;
    }
}
