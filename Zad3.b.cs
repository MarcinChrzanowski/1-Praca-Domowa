using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj 1 liczbe:");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj 2 liczbe:");
        int liczba2 = int.Parse(Console.ReadLine());

        if (liczba1 % 2 != 0)
            liczba1++;
        if (liczba1 % 2 != 0)
            liczba2--;

        for (int i = liczba1; i<=liczba2; i=i+2)
        {
            Console.WriteLine("{0}", i);
        }
        Console.ReadKey();
    }
}