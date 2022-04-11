namespace AbendProgtut;

public class Schauspieler
{
    public string name { get; set; }
    public string rollen { get; set; }
    public string lieblingsbanane { get; set; }
    public Schauspieler nextele { get; set; }

    public Schauspieler(string name, string rollen, string lieblingsbanane, Schauspieler nextele)
    {
        this.name = name;
        this.rollen = rollen;
        this.lieblingsbanane = lieblingsbanane;
        this.nextele = nextele;
    }
   
    public  string tostring()
    {
        return name + " " + rollen + " " + lieblingsbanane;
    }
    //get whole list 
    public void getList()
    {
        Schauspieler x = this;
        while (x != null)
        {
            Console.WriteLine(x.tostring());
            x = x.nextele;
        }
    }
}

class listesch
{
    private Schauspieler last=null;
    public  Schauspieler erstelleSchauspieler(string name, string rollen, string lieblingsbanane)
    {
        
        Schauspieler x = new Schauspieler(name, rollen, lieblingsbanane, last);
        
        last = x;
        return x;
    }       
    public void getList()
    {
        Schauspieler x = last;
        while (x != null)
        {
            Console.WriteLine(x.tostring());
            x = x.nextele;
        }
    }
    
}