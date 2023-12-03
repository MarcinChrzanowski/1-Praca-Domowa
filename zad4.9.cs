using System;

class Program
{
    static void Main()
    {
        Console.Write("Wprowadź łańcuch znaków: ");
        string tekst = Console.ReadLine();

        int liczbaWyrazow = ZliczWyrazy(tekst);

        Console.WriteLine($"Liczba wyrazów w tekście: {liczbaWyrazow}");

        Console.ReadLine();
    }

    static int ZliczWyrazy(string tekst)
    {
        tekst = tekst.Trim();

        if (string.IsNullOrEmpty(tekst))
        {
            return 0;
        }

        int liczbaWyrazow = 1;

        for (int i = 0; i < tekst.Length - 1; i++)
        {
            if (tekst[i] == ' ' && tekst[i + 1] != ' ')
            {
                liczbaWyrazow++;
            }
        }

        return liczbaWyrazow;
    }
}
