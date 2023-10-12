using System;

class Program
{
    static void Main()
    {
        double a, b, c, delta;
        Console.WriteLine("Podaj liczby całkowite:");
        Console.WriteLine("wspolczynnik a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("wspolczynnik b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("wspolczynnik c:");
        c = double.Parse(Console.ReadLine());
        delta = (b * b) - (4 * a * c);
        Console.WriteLine("Delta wynosi "+delta);
    }
}
