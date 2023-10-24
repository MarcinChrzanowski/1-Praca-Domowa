using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe");
        int liczba = int.Parse(Console.ReadLine());
        if(liczba % 2 == 0)
        {
            if (liczba < 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta i ujemna", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest parzysta i dodatnia", liczba);
            }
        }
        else
        {
            if (liczba < 0)
            {
                Console.WriteLine("Liczba {0} jest nieparzysta i ujemna", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest nieparzysta i dodatnia", liczba);
            }
        }
        Console.ReadKey();
    }
}