using System;

class Program
{
    static void Main()
    {
        int[] monety = { 1, 2, 5 };
        int suma = 10;

        Console.WriteLine("Możliwe kombinacje:");

        ZnajdzKombinacje(monety, suma, new int[monety.Length], 0);

        Console.ReadKey();
    }

    static void ZnajdzKombinacje(int[] monety, int suma, int[] iloscMonet, int aktualnaMoneta)
    {
        if (aktualnaMoneta >= monety.Length)
        {
            if (SumaKombinacji(iloscMonet) == suma)
            {
                WyswietlKombinacje(monety, iloscMonet);
            }
            return;
        }

        for (int i = 0; i <= suma / monety[aktualnaMoneta]; i++)
        {
            iloscMonet[aktualnaMoneta] = i;
            ZnajdzKombinacje(monety, suma, iloscMonet, aktualnaMoneta + 1);
        }
    }

    static int SumaKombinacji(int[] iloscMonet)
    {
        int suma = 0;
        for (int i = 0; i < iloscMonet.Length; i++)
        {
            suma += iloscMonet[i];
        }
        return suma;
    }

    static void WyswietlKombinacje(int[] monety, int[] iloscMonet)
    {
        for (int i = 0; i < monety.Length; i++)
        {
            Console.Write("{0} zł x {1}, ", monety[i], iloscMonet[i]);
        }
        Console.WriteLine();
    }
}
