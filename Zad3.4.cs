using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę (double): ");
        double pierwsza = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę (double): ");
        double druga = double.Parse(Console.ReadLine());

        Console.Write("Podaj operację (+, -, *, /): ");
        char operacja = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double wynik = 0.0;

        switch (operacja)
        {
            case '+':
                wynik = pierwsza + druga;
                break;
            case '-':
                wynik = pierwsza - druga;
                break;
            case '*':
                wynik = pierwsza * druga;
                break;
            case '/':
                if (druga != 0)
                {
                    wynik = pierwsza / druga;
                }
                else
                {
                    Console.WriteLine("Błąd: próba dzielenia przez zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Błąd: niepoprawna operacja.");
                return;
        }

        Console.WriteLine("Wynik: " + wynik);
        Console.ReadKey();
    }
}
