using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int silnia = ObliczSilnie(n);
        Console.WriteLine("{0}! = {1}", n, silnia);

        Console.ReadKey();
    }

    static int ObliczSilnie(int n)
    {
        if (n == 0)
            return 1;
        return n * ObliczSilnie(n - 1);
    }
}
