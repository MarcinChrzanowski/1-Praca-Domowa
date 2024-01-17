
public class Car
{
    private string marka;
    private int rok;

    private string model;
    private int iloscDrzwi;
    private double pojemnoscSilnika;
    public double srednieSpalanie;

    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public int Rok
    {
        get { return rok; }
        set
        {
            if (value >= 1769 && value <= 2017)
            {
                rok = value;
            }
            else
            {
                Console.WriteLine("Błędny rok produkcji.");
            }
        }
    }

    public Car(string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie)
    {
        this.model = model;
        this.iloscDrzwi = iloscDrzwi;
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.srednieSpalanie = srednieSpalanie;
    }

    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return srednieSpalanie * dlugoscTrasy;
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        return spalanie * cenaPaliwa;
    }
}
