using System;

class Program
{
    static void Main()
    {
        string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                       "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                       "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                       "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                       "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

        Console.WriteLine("Zawartość łańcucha:");
        Console.WriteLine(tekst);

        int liczbaWierszy = PodajLiczbeWierszy(tekst);
        Console.WriteLine($"\nLiczba wierszy: {liczbaWierszy}");

        int[] liczbaZnakowWiersza = PodajLiczbeZnakowWiersza(tekst);
        for (int i = 0; i < liczbaZnakowWiersza.Length; i++)
        {
            Console.WriteLine($"Liczba znaków wiersza {i + 1}: {liczbaZnakowWiersza[i]}");
        }

        Console.ReadLine();
    }

    static int PodajLiczbeWierszy(string tekst)
    {
        string[] wiersze = tekst.Split('\n');
        return wiersze.Length;
    }

    static int[] PodajLiczbeZnakowWiersza(string tekst)
    {
        string[] wiersze = tekst.Split('\n');
        int[] liczbaZnakowWiersza = new int[wiersze.Length];

        for (int i = 0; i < wiersze.Length; i++)
        {
            liczbaZnakowWiersza[i] = wiersze[i].Length;
        }

        return liczbaZnakowWiersza;
    }
}
