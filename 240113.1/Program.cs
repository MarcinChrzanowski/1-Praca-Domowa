using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int a = 10, b = 0, result;

        try
        {
            result = a / b;
            Console.WriteLine("Wynik: " + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Błąd dzielenia przez zero: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Blok finally - zawsze się wykonuje.");
        }

        SprawdzWyjatki();

        try
        {
            Metoda23();
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Metoda23 nie została jeszcze zaimplementowana.");
        }

        UruchomWatek();
    }

    static void SprawdzWyjatki()
    {
        try
        {
            throw new Exception("Nasza niestandardowa sytuacja");
        }
        catch (Exception e)
        {
            Console.WriteLine("Przechwycono wyjątek: " + e.GetType().Name);
        }
    }

    static void Metoda23()
    {
        throw new NotImplementedException("Ta metoda nie została jeszcze zaimplementowana.");
    }

    static void Licz()
    {
        for (int i = 1; i <= 10000; i++)
        {
            Console.WriteLine("program1: " + i);
        }
    }

    static void Watek()
    {
        for (int i = 1; i <= 10000; i++)
        {
            Console.WriteLine("watek: " + i);
        }
    }

    static void UruchomWatek()
    {
        Thread thr = new Thread(Licz);
        thr.Start();
    }
}
