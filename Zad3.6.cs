using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wage (w kg): ");
        double waga = double.Parse(Console.ReadLine());

        Console.Write("Podaj wzrost (w metrach): ");
        double wzrost = double.Parse(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);

        Console.WriteLine("Twoje BMI wynosi: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi >= 18.5 && bmi <= 24.99)
        {
            Console.WriteLine("Wartosc prawidlowa");
        }
        else if (bmi >= 25.0 && bmi < 30.0)
        {
            Console.WriteLine("Nadwaga");
        }
        else if (bmi >= 30.0 && bmi < 35.0)
        {
            Console.WriteLine("Otylosc I stopnia");
        }
        else if (bmi >= 35.0 && bmi < 40.0)
        {
            Console.WriteLine("Otylosc II stopnia");
        }
        else if (bmi >= 40.0)
        {
            Console.WriteLine("Otylosc skrajna");
        }

        Console.ReadKey();
    }
}
