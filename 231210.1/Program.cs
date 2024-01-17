using System;

class Program
{
    static void Main()
    {
        Car car1 = Car.CreateCar(0, "");
        Console.WriteLine($"Ilość kół: {Car.IloscKol}");

        try
        {
            int liczba1;
            int liczba2 = 10;
            int liczba3 = 0;
            liczba1 = liczba2 / liczba3;
            Console.WriteLine($"Wynik dzielenia: {liczba1}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Nie lubię dzielenia przez zero. {e.Message}");
        }
        finally
        {
            Console.WriteLine("FINALLY");
        }

        try
        {
            int[] table = new int[2];
            table[25] = 2;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Wyjątek IndexOutOfRangeException: {e.Message}");
        }
        catch
        {
            Console.WriteLine("Inny wyjątek");
        }

        try
        {
            throw new IndexOutOfRangeException();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Przechwycono wyjątek: {e.Message}");
        }
    }
}
