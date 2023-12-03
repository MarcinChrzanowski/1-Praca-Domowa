using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";

        Dictionary<string, int> raport = AnalizujSlowa(tekst);

        Console.WriteLine("Raport o słowach powielonych w tekście:");

        foreach (var para in raport)
        {
            Console.WriteLine($"{para.Key} - {para.Value} razy");
        }

        Console.ReadLine();
    }

    static Dictionary<string, int> AnalizujSlowa(string tekst)
    {
        string[] slowa = tekst.Split(new char[] { ' ', ',', '.', '!', '?', '-', '–', '—', '(', ')', '”', '“', '„', '’', '‘', '…', '»', '«', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> raport = new Dictionary<string, int>();

        foreach (string slowo in slowa)
        {
            string slowoBezZnakow = UsunZnakiNiekonieczne(slowo);
            string slowoLowerCase = slowoBezZnakow.ToLower();

            if (raport.ContainsKey(slowoLowerCase))
            {
                raport[slowoLowerCase]++;
            }
            else
            {
                raport[slowoLowerCase] = 1;
            }
        }

        return raport;
    }

    static string UsunZnakiNiekonieczne(string slowo)
    {
        char[] znakiNiekonieczne = { '.', ',', '!', '?', '–', '—', '(', ')', '”', '“', '„', '’', '‘', '…', '»', '«' };
        return new string(slowo.ToCharArray().Where(c => !znakiNiekonieczne.Contains(c)).ToArray());
    }
}
