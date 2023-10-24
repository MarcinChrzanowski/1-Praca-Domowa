using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego (a, b, c).");

        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            Console.WriteLine("Równanie ma dwa różne pierwiastki rzeczywiste.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty.");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }

        Console.ReadKey();
    }
}
