namespace UebungenOOP;

public class artikel
{
    //autoproperties artnmr, preis
    public int artnmr { get; set; }
    public float preis { get; set; }

    public artikel(int artnmr, float preis)
    {
        this.artnmr = artnmr;
        this.preis = preis;
    }

    public override string ToString()
    {
        return "Artikelnummer: " + artnmr + " Preis: " + preis;
    }
}

public class buch : artikel
{
    //autoproperties autor, titel
    public string autor { get; set; }
    public string titel { get; set; }
    public string verlag { get; set; }

    public buch(int artnmr, float preis, string autor, string titel, string verlag) : base(artnmr, preis)
    {
        this.autor = autor;
        this.titel = titel;
        this.verlag = verlag;
    }

    public override string ToString()
    {
        return base.ToString() + " \nBuch: " + titel + " von " + autor + " (" + verlag + ")";
    }
}

public class cd : artikel
{
    //autoproperties interpret, titel
    public string interpret { get; set; }
    public string titel { get; set; }
    public int titelanzahl { get; set; }

    public cd(int artnmr, float preis, string interpret, string titel, int titelanzahl) : base(artnmr, preis)
    {
        this.interpret = interpret;
        this.titel = titel;
        this.titelanzahl = titelanzahl;
    }

    public override string ToString()
    {
        return base.ToString() + " \n CD: " + interpret + " - " + titel + " (" + titelanzahl + " Titel)";
    }
}

public class video : artikel
{
    //autoproperties titel, laenge
    public string titel { get; set; }
    public string regisseur { get; set; }
    public bool dlc { get; set; }

    public video(int artnmr, float preis, string titel, string regisseur, bool dlc) : base(artnmr, preis)
    {
        this.titel = titel;
        this.regisseur = regisseur;
        this.dlc = dlc;
    }

    public override string ToString()
    {
        return base.ToString() + " \n Video: " + titel + " " + regisseur + " " + dlc;
    }
}

class warenkorb
{
    public List<artikel> artikel = new List<artikel>();

    public void add(artikel a)
    {
        artikel.Add(a);
    }

    public void remove(artikel a)
    {
        artikel.Remove(a);
    }

    public void clear()
    {
        artikel.Clear();
    }

    public double calcPreis()
    {
        double preis = 0;
        foreach (artikel a in artikel)
        {
            preis += a.preis;
        }
        return preis;
    }
    public void print()
    {
        foreach (artikel a in artikel)
        {
            Console.WriteLine(a);
            
        }
    }
}