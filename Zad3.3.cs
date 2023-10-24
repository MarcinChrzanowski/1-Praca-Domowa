using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        int pierwsza = int.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        int druga = int.Parse(Console.ReadLine());

        Console.Write("Podaj trzecią liczbę: ");
        int trzecia = int.Parse(Console.ReadLine());

        int najwieksza = Math.Max(Math.Max(pierwsza, druga), trzecia);

        Console.WriteLine("Największa liczba to: " + najwieksza);

        Console.ReadKey();
    }
}
