using System;

class Program
{
    static void Main()
    {
        try
        {
            Obliczenia kalkulator = new Obliczenia(10, 5);

            Console.WriteLine($"Dodawanie: {kalkulator.Dodawanie()}");
            Console.WriteLine($"Odejmowanie: {kalkulator.Odejmowanie()}");
            Console.WriteLine($"Mnożenie: {kalkulator.Mnozenie()}");
            Console.WriteLine($"Dzielenie: {kalkulator.Dzielenie()}");
            Console.WriteLine($"Potęgowanie: {kalkulator.Potegowanie()}");
            Console.WriteLine($"Pierwiastkowanie: {kalkulator.Pierwiastkowanie()}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Błąd: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Koniec programu.");
        }

        // Zadanie dodatkowe: Tworzenie własnego wyjątku
        try
        {
            throw new MojeWlasneException("To jest mój własny wyjątek!");
        }
        catch (MojeWlasneException e)
        {
            Console.WriteLine($"Przechwycono własny wyjątek: {e.Message}");
        }
    }
}

public class MojeWlasneException : Exception
{
    public MojeWlasneException(string message) : base(message)
    {
    }
}
