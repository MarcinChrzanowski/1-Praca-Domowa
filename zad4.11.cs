using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Wprowadź łańcuch znaków: ");
        string tekst = Console.ReadLine();

        Dictionary<char, int> czestosci = AnalizujCzestoscZnakow(tekst);

        Console.WriteLine("Częstość występowania poszczególnych znaków:");

        foreach (var para in czestosci)
        {
            Console.WriteLine($"{para.Key} - {para.Value}");
        }

        Console.ReadLine();
    }

    static Dictionary<char, int> AnalizujCzestoscZnakow(string tekst)
    {
        Dictionary<char, int> czestosci = new Dictionary<char, int>();

        foreach (char znak in tekst)
        {
            if (czestosci.ContainsKey(znak))
            {
                czestosci[znak]++;
            }
            else
            {
                czestosci[znak] = 1;
            }
        }

        return czestosci;
    }
}
