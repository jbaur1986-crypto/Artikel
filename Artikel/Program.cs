namespace Artikel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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

    public ArtTyp meinTyp = ArtTyp.Sonstiges;

    public Artikel(int artNr, string artName, decimal artPreis, ArtTyp welcherTyp)
    {
        this.artNr = artNr;
        this.artName = artName;
        this.artPreis = artPreis;
        meinTyp = welcherTyp;
    }
    
    public void SetPrice()
    {
        //Setter muss noch geschrieben werden.
    }
    
    // Getter für GetPreis, Getter für GetType; außerdem d, e
}