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

class Odcinek
{
    private Punkt punktPoczatkowy;
    private Punkt punktKoncowy;

    public Odcinek(Punkt punktPoczatkowy, Punkt punktKoncowy)
    {
        this.punktPoczatkowy = punktPoczatkowy;
        this.punktKoncowy = punktKoncowy;
    }

    public double ObliczDlugoscOdcinka()
    {
        double deltaX = punktKoncowy.X - punktPoczatkowy.X;
        double deltaY = punktKoncowy.Y - punktPoczatkowy.Y;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

class Program
{
    static void Main()
    {
        Punkt punktPoczatkowy = new Punkt(1, 1);
        Punkt punktKoncowy = new Punkt(4, 5);

        Odcinek odcinek = new Odcinek(punktPoczatkowy, punktKoncowy);

        Console.WriteLine($"Długość odcinka: {odcinek.ObliczDlugoscOdcinka()}");
    }
}
