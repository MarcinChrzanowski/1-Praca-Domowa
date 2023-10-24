using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rok: ");
        int rok = int.Parse(Console.ReadLine());

        if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
        {
            Console.WriteLine("{0} to rok przestępny.", rok);
        }
        else
        {
            Console.WriteLine("{0} to nie jest rok przestępny.", rok);
        }

        Console.ReadKey();
    }
}
