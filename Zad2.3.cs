using System;

class Program
{
    static void Main()
    {
        double kg, m, bmi;
        Console.WriteLine("Podaj mase ciala w kg:");
        kg = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wzrost w metrach:");
        m = double.Parse(Console.ReadLine());
        bmi = kg/(m*m);
        Console.WriteLine("BMI wynosi: " + bmi);

    }
}
