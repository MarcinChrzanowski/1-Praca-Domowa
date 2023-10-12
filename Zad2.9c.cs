using System;

class Program
{
    static void Main()
    {
        int x = 1, y = 4, z = 2;
        bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
        Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
    }
}