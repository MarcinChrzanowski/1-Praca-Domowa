using System;

class Punkt
{
    private double x;
    private double y;

    public Punkt(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public void Przesun(double przesuniecieX, double przesuniecieY)
    {
        x += przesuniecieX;
        y += przesuniecieY;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Współrzędne punktu: ({x}, {y})");
    }

    public static bool CzyPunktyNaProstej(Punkt punkt1, Punkt punkt2, Punkt punkt3)
    {
        // Sprawdzenie, czy współrzędne punktów spełniają warunek, że leżą na jednej prostej
        return (punkt1.X * (punkt2.Y - punkt3.Y) + punkt2.X * (punkt3.Y - punkt1.Y) + punkt3.X * (punkt1.Y - punkt2.Y)) == 0;
    }
}

class Program
{
    static void Main()
    {
        Punkt[] punkty = new Punkt[3];

        // Inicjalizacja obiektów w tablicy
        punkty[0] = new Punkt(1, 1);
        punkty[1] = new Punkt(2, 2);
        punkty[2] = new Punkt(3, 3);

        // Wyświetlanie współrzędnych punktów
        foreach (Punkt punkt in punkty)
        {
            punkt.Wyswietl();
        }

        // Sprawdzenie czy punkty leżą na jednej prostej
        bool czyNaProstej = Punkt.CzyPunktyNaProstej(punkty[0], punkty[1], punkty[2]);

        Console.WriteLine($"Czy punkty leżą na jednej prostej: {czyNaProstej}");
    }
}
