using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main()
    {
        string carName = "Mój samochód";
        Console.WriteLine(carName);

        Car car1 = new Car("Fiat", 4, 1.6, 6.5);
        car1.Marka = "Toyota";
        car1.Rok = 2020;
        Console.WriteLine($"Marka: {car1.Marka}, Rok produkcji: {car1.Rok}");

        Car car2 = new Car("BMW", 2, 2.0, 8.0);
        Console.WriteLine($"Marka: {car2.Marka}, Rok produkcji: {car2.Rok}");

        Console.WriteLine("Podaj rok produkcji dla nowego samochodu:");
        int nowyRok = int.Parse(Console.ReadLine());

        Car nowySamochod = new Car("Opel", 5, 1.8, 7.0);
        nowySamochod.Rok = nowyRok;
        Console.WriteLine($"Marka: {nowySamochod.Marka}, Rok produkcji: {nowySamochod.Rok}");

        Console.WriteLine("Podaj długość trasy (km):");
        double dlugoscTrasy = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj cenę paliwa za litr:");
        double cenaPaliwa = double.Parse(Console.ReadLine());

        double kosztPrzejazdu = nowySamochod.ObliczKosztPrzejazdu(dlugoscTrasy, cenaPaliwa);
        Console.WriteLine($"Koszt przejazdu: {kosztPrzejazdu} PLN");
    }
}
