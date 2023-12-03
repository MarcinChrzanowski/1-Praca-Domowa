using System;

class Program
{
    static void Main()
    {
        string[] identyfikatory = { "KOMG-2002", "BH-2010", "XYZ-2015", "ABCD-2005", "EFGH-2018" };

        Console.WriteLine("Liczba lat od zakupu dla poszczególnych środków trwałych:");

        foreach (string identyfikator in identyfikatory)
        {
            int rokZakupu = PobierzRokZakupu(identyfikator);
            int lataOdZakupu = ObliczLataOdZakupu(rokZakupu);

            Console.WriteLine($"{identyfikator}: {lataOdZakupu} lat");
        }

        Console.ReadLine();
    }

    static int PobierzRokZakupu(string identyfikator)
    {
        int indeksMyshlnika = identyfikator.IndexOf('-');
        if (indeksMyshlnika != -1 && indeksMyshlnika + 5 < identyfikator.Length)
        {
            string rokTekst = identyfikator.Substring(indeksMyshlnika + 1, 4);
            if (int.TryParse(rokTekst, out int rok))
            {
                return rok;
            }
        }

        return 0;
    }

    static int ObliczLataOdZakupu(int rokZakupu)
    {
        int obecnyRok = DateTime.Now.Year;
        return obecnyRok - rokZakupu;
    }
}
