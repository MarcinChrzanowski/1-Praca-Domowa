using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę naturalną x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int sumaCyfr = ObliczSumeCyfr(x);

        Console.WriteLine($"Suma cyfr liczby {x} wynosi: {sumaCyfr}");
    }

    static int ObliczSumeCyfr(int x)
    {
        int suma = 0;

        while (x > 0)
        {
            suma += x % 10;
            x /= 10;
        }

        return suma;
    }
}
