using System.Runtime.InteropServices.ComTypes;

namespace Artikel;

class Program
{
    static void Main(string[] args)
    {
        Artikel art1 = new(12, "Jeanshose", 89.60m, ArtTyp.Bekleidung);
        Artikel art2 = new(3, "Tasse", 23.89m, ArtTyp.Haushalt);
        Artikel art3 = new(42, "Schokoriegel", 2.90m);

        Artikel[] artikel = { art1, art2, art3 };
        
        //hier Preiserhöhung e
        for (int i = 0; i<artikel.Length; i++)
        {
            if (artikel[i].GetArtType() == ArtTyp.Sonstiges) 
            {
                decimal artPreis = artikel[i].GetPrice();
                artikel[i].SetPrice(1.1m*artPreis);
            }
        }
        //hier f
        Console.WriteLine($"{Artikel.Teuerster(artikel, out decimal preis)}: {preis} Euro");
    }
}

enum ArtTyp 
{
    Sonstiges,
    Bekleidung,
    Haushalt,
    Einrichtung
}

class Artikel
{
    private int artNr;
    private string artName;
    private decimal artPreis;

    private ArtTyp meinTyp = ArtTyp.Sonstiges;

    public Artikel(int artNr, string artName, decimal artPreis, ArtTyp welcherTyp = ArtTyp.Sonstiges)
    {
        this.artNr = artNr;
        this.artName = artName;
        SetPrice(artPreis);
        meinTyp = welcherTyp;
    }
    
    public void SetPrice(decimal artPreis)
    {
        this.artPreis = artPreis;
    }
    public string GetName()
    {
        return artName;
    }
    public decimal GetPrice()
    {
        return artPreis;
    }
    public ArtTyp GetArtType()
    {
        return meinTyp;
    }

    public static string Teuerster(Artikel[] artikel, out decimal artPrice)
    {
        string teuerster = artikel[0].GetName();

        artPrice = artikel[0].GetPrice();
        
        for (int i = 0; i < artikel.Length; i++)
        {
            if (artikel[i].GetPrice() >= artikel[0].GetPrice())
            {
                Artikel zwischenspeicher = artikel[0];
                artikel[0] = artikel[i];
                artikel[i] = zwischenspeicher;
            }
        }
        artPrice = artikel[0].GetPrice();
        return artikel[0].GetName();
    }
}