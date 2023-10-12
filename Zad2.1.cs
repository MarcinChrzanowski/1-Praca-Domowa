using System;

class Program
{
    static void Main()
    {
        double C, F;
        Console.WriteLine("Podaj temperature w stopniach Celsjusza: ");
        C = double.Parse(Console.ReadLine());
        F = C * 9 / 5+32;
        Console.WriteLine("Temperatura w stopniach Fahrenheita: "+F);
    }
}
