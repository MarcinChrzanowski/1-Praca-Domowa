using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj długość prostokąta: ");
        int dlugosc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj szerokość prostokąta: ");
        int szerokosc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj znak wypełnienia: ");
        char znak = Console.ReadKey().KeyChar;

        Console.WriteLine();

        Rysuj(dlugosc, szerokosc, znak);

        Console.WriteLine();

        Rysuj(szerokosc, dlugosc, znak);
    }

    static void Rysuj(int dlugosc, int szerokosc, char znak)
    {
        for (int i = 0; i < szerokosc; i++)
        {
            for (int j = 0; j < dlugosc; j++)
            {
                Console.Write(znak);
            }
            Console.WriteLine();
        }
    }
}
