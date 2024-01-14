using System;
using Internal;

class RachunekBankowy
{
    private static double rocznaStopaProcentowa;
    private double saldo;

    public RachunekBankowy(double poczatkoweOszczednosci)
    {
        saldo = poczatkoweOszczednosci;
    }

    public void ObliczMiesieczneOdsetki()
    {
        double miesieczneOdsetki = (saldo * rocznaStopaProcentowa) / 12;
        saldo += miesieczneOdsetki;
    }

    public static void SetRocznaStopaProcentowa(double nowaStopa)
    {
        rocznaStopaProcentowa = nowaStopa;
    }

    public double PobierzSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        RachunekBankowy.SetRocznaStopaProcentowa(0.04);
        RachunekBankowy server1 = new RachunekBankowy(2000.00);
        RachunekBankowy server2 = new RachunekBankowy(3000.00);

        server1.ObliczMiesieczneOdsetki();
        server2.ObliczMiesieczneOdsetki();

        Console.WriteLine(server1.PobierzSaldo());
        Console.WriteLine(server2.PobierzSaldo());

        RachunekBankowy.SetRocznaStopaProcentowa(0.05);

        server1.ObliczMiesieczneOdsetki();
        server2.ObliczMiesieczneOdsetki();

        Console.WriteLine(server1.PobierzSaldo());
        Console.WriteLine(server2.PobierzSaldo());
    }
}
