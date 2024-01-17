class Program
{
    static void Main()
    {
        Osoba osoba1 = new Osoba("Jan", "Kowalski", 1990);
        Student student1 = new Student("Anna", "Nowak", 1995, 2, "GrupaA", "123456");

        osoba1.WypiszInfo();

        student1.WypiszInfoStudenta();

        StudentPierwszegoRoku studentPierwszegoRoku = new StudentPierwszegoRoku("Marcin", "Wiśniewski", 2000, "GrupaB", "654321");
        studentPierwszegoRoku.WypiszInfoStudenta();
    }
}
