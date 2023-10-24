using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Liczby doskonałe w przedziale <1, {0}>:", n);

        for (int i = 1; i <= n; i++)
        {
            if (CzyDoskonala(i))
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }

    static bool CzyDoskonala(int liczba)
    {
        int sumaDzielnikow = 0;

        for (int i = 1; i < liczba; i++)
        {
            if (liczba % i == 0)
            {
                sumaDzielnikow += i;
            }
        }

        return sumaDzielnikow == liczba;
    }
}
