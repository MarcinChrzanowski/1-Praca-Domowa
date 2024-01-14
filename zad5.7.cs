using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wartość x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wartość n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int wynik = ObliczW(x, n);

        Console.WriteLine($"W = {wynik}");
    }

    static int ObliczW(int x, int n)
    {
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += (x + i);
        }

        return suma;
    }
}
