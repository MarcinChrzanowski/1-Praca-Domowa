using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int liczba = 1;
        int iloscLiczb = 0;

        while (suma <= 100)
        {
            suma += liczba;
            liczba++;
            iloscLiczb++;
        }

        Console.WriteLine("Aby suma przekroczyła 100, należy dodać kolejnych {0} liczb.", iloscLiczb);

        Console.ReadKey();
    }
}
