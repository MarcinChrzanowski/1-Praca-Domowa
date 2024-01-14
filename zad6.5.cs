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
}

class Program
{
    static void Main()
    {
        Console.Write("Podaj współrzędną x punktu: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Punkt punkt = new Punkt(x, y);

        Console.WriteLine("Aktualne współrzędne punktu:");
        punkt.Wyswietl();

        Console.Write("Podaj wartość przesunięcia dla współrzędnej x: ");
        double przesuniecieX = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość przesunięcia dla współrzędnej y: ");
        double przesuniecieY = Convert.ToDouble(Console.ReadLine());

        punkt.Przesun(przesuniecieX, przesuniecieY);

        Console.WriteLine("Aktualne współrzędne punktu po przesunięciu:");
        punkt.Wyswietl();
    }
}
