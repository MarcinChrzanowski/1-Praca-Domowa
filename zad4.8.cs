using System;
using Internal;

class Program
{
    static void Main()
    {
        string[,] dniTygodnia;
        dniTygodnia = new string[2, 3];

        dniTygodnia[0, 0] = "poniedzialek";
        dniTygodnia[1, 0] = "wtorek";
        dniTygodnia[0, 1] = "monday";
        dniTygodnia[1, 1] = "tuesday";
        dniTygodnia[0, 2] = "montag";
        dniTygodnia[1, 2] = "dienstag";

        dniTygodnia[0, 3] = "środa";
        dniTygodnia[1, 3] = "wednesday";
        dniTygodnia[0, 4] = "donnerstag";
        dniTygodnia[1, 4] = "thursday";
        dniTygodnia[0, 5] = "piątek";
        dniTygodnia[1, 5] = "friday";
        dniTygodnia[0, 6] = "samstag";
        dniTygodnia[1, 6] = "saturday";
        dniTygodnia[0, 7] = "niedziela";
        dniTygodnia[1, 7] = "sunday";

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"{dniTygodnia[i, j],-15}");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
