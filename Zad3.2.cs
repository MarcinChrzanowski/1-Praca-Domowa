using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę całkowitą: ");
        int pierwszaLiczba = int.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę całkowitą: ");
        int drugaLiczba = int.Parse(Console.ReadLine());

        if (pierwszaLiczba % drugaLiczba == 0)
        {
            Console.WriteLine("{0} jest dzielnikiem {1}.", drugaLiczba, pierwszaLiczba);
        }
        else
        {
            Console.WriteLine("{0} nie jest dzielnikiem {1}.", drugaLiczba, pierwszaLiczba);
        }

        Console.ReadKey();
    }
}
