using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj numer wyrazu ciągu Fibonacciego: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int wynik = Fibonacci(n);

        Console.WriteLine($"Wartość {n}-tego wyrazu ciągu Fibonacciego to: {wynik}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int a = 0, b = 1, temp = 0;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
