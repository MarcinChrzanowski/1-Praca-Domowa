using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy: ");
        int liczbaWierszy = int.Parse(Console.ReadLine());

        Console.WriteLine("a:");

        for (int i = 1; i <= liczbaWierszy; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("b:");

        for (int i = liczbaWierszy; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("c:");

        for (int i = 1; i <= liczbaWierszy; i++)
        {
            for (int j = 1; j <= liczbaWierszy - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("d:");

        for (int i = 1; i <= liczbaWierszy; i++)
        {
            for (int j = 1; j <= liczbaWierszy; j++)
            {
                if (i == 1 || i == liczbaWierszy || j == 1 || j == liczbaWierszy)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
