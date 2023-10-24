using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        while (true)
        {
            Console.Write("Podaj liczbę całkowitą (0 aby zakończyć): ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba == 0)
            {
                break;
            }

            suma += liczba;
        }

        Console.WriteLine("Suma wprowadzonych liczb wynosi: " + suma);

        Console.ReadKey();
    }
}
