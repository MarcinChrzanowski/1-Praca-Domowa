using System;

class LicznikEnergetyczny
{
    private double poczatkowyStanLicznika;
    private double biezacyStanLicznika;

    public LicznikEnergetyczny(double poczatkowyStanLicznika)
    {
        this.poczatkowyStanLicznika = poczatkowyStanLicznika;
        this.biezacyStanLicznika = poczatkowyStanLicznika;
    }

    public void RejestracjaPoczatkowegoStanu(double poczatkowyStan)
    {
        poczatkowyStanLicznika = poczatkowyStan;
        biezacyStanLicznika = poczatkowyStan;
    }

    public void RejestracjaBiezacegoStanu(double biezacyStan)
    {
        biezacyStanLicznika = biezacyStan;
    }

    public double PobierzPoczatkowyStan()
    {
        return poczatkowyStanLicznika;
    }

    public double PobierzBiezacyStan()
    {
        return biezacyStanLicznika;
    }

    public double ObliczZuzycieEnergii()
    {
        return biezacyStanLicznika - poczatkowyStanLicznika;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Podaj początkowy stan licznika energii: ");
        double poczatkowyStan = Convert.ToDouble(Console.ReadLine());

        LicznikEnergetyczny licznik = new LicznikEnergetyczny(poczatkowyStan);

        Console.Write("Podaj bieżący stan licznika energii: ");
        double biezacyStan = Convert.ToDouble(Console.ReadLine());

        licznik.RejestracjaBiezacegoStanu(biezacyStan);

        Console.WriteLine($"Początkowy stan licznika: {licznik.PobierzPoczatkowyStan()}");
        Console.WriteLine($"Bieżący stan licznika: {licznik.PobierzBiezacyStan()}");
        Console.WriteLine($"Zużycie energii: {licznik.ObliczZuzycieEnergii()}");
    }
}
