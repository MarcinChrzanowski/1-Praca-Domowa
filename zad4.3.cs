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

        int maxWartosc = int.MinValue;
        int minWartosc = int.MaxValue;
        int pozycjaMax = -1;
        int pozycjaMin = -1;
        int suma = 0;
        int liczbaDodatnich = 0;

        for (int i = 0; i < n; i++)
        {
            int aktualnaWartosc = tablica[i];

            if (aktualnaWartosc > maxWartosc)
            {
                maxWartosc = aktualnaWartosc;
                pozycjaMax = i;
            }

            if (aktualnaWartosc < minWartosc)
            {
                minWartosc = aktualnaWartosc;
                pozycjaMin = i;
            }

            suma += aktualnaWartosc;

            if (aktualnaWartosc > 0)
            {
                liczbaDodatnich++;
            }
        }

        double srednia = (double)suma / n;

        Console.WriteLine($"\nWartość największego elementu: {maxWartosc}, Pozycja: {pozycjaMax + 1}");
        Console.WriteLine($"Wartość najmniejszego elementu: {minWartosc}, Pozycja: {pozycjaMin + 1}");
        Console.WriteLine($"Średnia wartości wszystkich elementów: {srednia}");
        Console.WriteLine($"Liczba wartości dodatnich w tablicy: {liczbaDodatnich}");

        Console.ReadLine();
    }
}
