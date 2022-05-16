namespace Übung08;

public class bruch : IComparable
{
    public int zaehler { get; set; }
    public int nenner { get; set; }


    public bruch(int zaehler, int nenner)
    {
        this.zaehler = zaehler;
        this.nenner = nenner;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            return 1;
        }
        double komma = (double) zaehler / (double) nenner;
        bruch objB = obj as bruch;
        double compKomma = (double)objB.zaehler  / (double) objB.nenner;
        if (komma > compKomma)
        {
            return 1;
        }
        else if (komma < compKomma)
        {
            return -1;
        }

        return 0;
    }

    public override string ToString()
    {
        return $"{zaehler}/{nenner}";
    }
}