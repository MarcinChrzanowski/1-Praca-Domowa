using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź liczbę wierszy");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
