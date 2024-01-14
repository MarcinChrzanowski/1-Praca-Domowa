using System;

struct KandydatNaStudia
{
    public string Nazwisko;
    public double PunktyMatematyka;
    public double PunktyInformatyka;
    public double PunktyJezykObcy;

    public double ObliczLacznaLiczbePunktow()
    {
        return 0.6 * PunktyMatematyka + 0.5 * PunktyInformatyka + 0.2 * PunktyJezykObcy;
    }
}

class Program
{
    static void Main()
    {
        KandydatNaStudia[] kandydaci = new KandydatNaStudia[3];

        kandydaci[0] = new KandydatNaStudia { Nazwisko = "Kowalski", PunktyMatematyka = 65, PunktyInformatyka = 70, PunktyJezykObcy = 80 };
        kandydaci[1] = new KandydatNaStudia { Nazwisko = "Nowak", PunktyMatematyka = 55, PunktyInformatyka = 60, PunktyJezykObcy = 70 };
        kandydaci[2] = new KandydatNaStudia { Nazwisko = "Wiśniewski", PunktyMatematyka = 75, PunktyInformatyka = 80, PunktyJezykObcy = 90 };

        Console.WriteLine("Lista kandydatów:");

        foreach (var kandydat in kandydaci)
        {
            Console.WriteLine($"{kandydat.Nazwisko}: {kandydat.ObliczLacznaLiczbePunktow()} punktów");
        }
    }
}
