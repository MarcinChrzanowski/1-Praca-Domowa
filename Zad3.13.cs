using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int znak = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += znak * i;
            znak = -znak;
        }

        Console.WriteLine("Suma szeregu W({0}) = {1}", n, suma);

        Console.ReadKey();
    }
}
