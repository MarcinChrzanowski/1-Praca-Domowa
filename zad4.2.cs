using System;

class Program
{
    static void Main()
    {
        int[] tab1 = { -2, 5, -8, 10, -3, 7, 1, -4, 6, -9 };
        int[] tab2 = new int[10];
        int indexTab2 = 0;

        for (int i = 0; i < 10; i++)
        {
            if (tab1[i] > 0)
            {
                tab2[indexTab2] = tab1[i];
                indexTab2++;
            }
        }

        Console.WriteLine("Zawartość tablicy tab1:");
        WyswietlTablice(tab1);

        Console.WriteLine("\nZawartość tablicy tab2 (tylko dodatnie wartości):");
        WyswietlTablice(tab2);

        Console.ReadLine();
    }

    static void WyswietlTablice(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine();
    }
}
