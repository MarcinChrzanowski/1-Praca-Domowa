﻿using System;

class Program
{
    static void Main()
    {
        int x, y = 4;
        x = (y -= 2);
        x = y++;
        x = y--;
        Console.WriteLine(x);
    }
}