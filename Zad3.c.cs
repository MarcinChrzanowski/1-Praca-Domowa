using System;

class Program
{
    static void Main()
    {
        int i = 1;
        double dlug = 80, janek = 50, karol = 40, kasa = 0;
        do
        {
            kasa += 0.2 * janek + 0.2 * karol;
            Console.WriteLine("Dzien {0}: pieniadze = {1}", i++, kasa);
        } while (kasa < dlug);
        Console.ReadKey();
    }
}