class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Bicycle bicycle1 = new Bicycle();

        car1.Ride();
        bicycle1.Ride();

        Osoba osoba = new Osoba();
        osoba.Graj();
        ((IGitarzysta)osoba).Graj();
        ((ISkrzypek)osoba).Graj();
    }
}
