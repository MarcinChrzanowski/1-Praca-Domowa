using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj datę w formacie DD-MM-RRRR: ");
        string dataTekst = Console.ReadLine();

        if (DateTime.TryParseExact(dataTekst, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
        {
            string nazwaMiesiaca = PobierzNazweMiesiaca(data.Month);

            Console.WriteLine($"Nazwa miesiąca: {nazwaMiesiaca}");
        }
        else
        {
            Console.WriteLine("Błędny format daty.");
        }

        Console.ReadLine();
    }

    static string PobierzNazweMiesiaca(int numerMiesiaca)
    {
        switch (numerMiesiaca)
        {
            case 1: return "Styczeń";
            case 2: return "Luty";
            case 3: return "Marzec";
            case 4: return "Kwiecień";
            case 5: return "Maj";
            case 6: return "Czerwiec";
            case 7: return "Lipiec";
            case 8: return "Sierpień";
            case 9: return "Wrzesień";
            case 10: return "Październik";
            case 11: return "Listopad";
            case 12: return "Grudzień";
            default: return "Nieznany miesiąc";
        }
    }
}
