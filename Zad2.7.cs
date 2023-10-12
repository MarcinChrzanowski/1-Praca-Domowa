using System;

class Program
{
    static void Main()
    {
        int x, y = 5;
        x = ++y * 2;
        x = y++;
        x = y--;
        Console.WriteLine(++y);
    }
}