using System;

public class Test : ICloneable
{
    public int liczba;
    public Test2 poleTestowe;

    public object Clone()
    {
        return MemberwiseClone();
    }

    public Test()
    {
        poleTestowe = new Test2();
    }

    public Test GlebokaKopia()
    {
        Test tempTest = new Test();
        tempTest.liczba = this.liczba;
        tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
        return tempTest;
    }
}

public class Test2
{
    public string slowo;
}

class Program
{
    static void Main()
    {
        Test obiekt1 = new Test();
        Test obiekt2 = obiekt1;
        Test obiekt3 = (Test)obiekt1.Clone();
        obiekt1.liczba = 255;
        obiekt2.liczba = 255;
        obiekt3.liczba = 255;

        obiekt1.poleTestowe.slowo = "słowo";
        obiekt1.poleTestowe.slowo = "kaczka";
        obiekt2.poleTestowe.slowo = "kaczka";
        obiekt3.poleTestowe.slowo = "kaczka";
    }
}
