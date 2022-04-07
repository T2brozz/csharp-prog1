using System.Reflection.Metadata;

class Studenten
{
    public string name;
    public double note;

    public Studenten(string name, double note)
    {
        this.name = name;
        this.note = note;
    }

    public override string ToString()
    {
        return $"{name},{note}";
    }
    public static double calcNC(Studenten[])
}