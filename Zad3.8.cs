using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj średnią ocen: ");
        double srednia = double.Parse(Console.ReadLine());

        if (srednia >= 2.00 && srednia <= 3.99)
        {
            Console.WriteLine("Przysługuje stypendium w wysokości: 0,00 zł");
        }
        else if (srednia >= 4.00 && srednia <= 4.79)
        {
            Console.WriteLine("Przysługuje stypendium w wysokości: 350,00 zł");
        }
        else if (srednia >= 4.80 && srednia <= 5.00)
        {
            Console.WriteLine("Przysługuje stypendium w wysokości: 550,00 zł");
        }
        else
        {
            Console.WriteLine("Błędna średnia ocen.");
        }

        Console.ReadKey();
    }
}
