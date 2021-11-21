using System;

namespace Praktikum06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Code wie angegeben
            for (double d = -Math.PI; d < Math.PI; d+=0.3) 
            { 
                Console.WriteLine($"{Math.Sin(d),25} | {MySin(d),25} | {Math.Sin(d)-MySin(d),25}"); 
            }
            Console.WriteLine("-------------------------------"); 
           
            Console.WriteLine($"Wuerfeltest: längste Kette: {Wuerfeltest(10000)}"); 
            
 
            Console.WriteLine("---------------------- ---------"); 
            int a = 5, b = 3; 
            SortSwap(/* ... */ ref a, /* ... */ ref b); 
            Console.WriteLine($"Sort-Swap: {a} - {b}"); 
            SortSwap(/* ... */ ref a, /* ... */ ref b); 
            Console.WriteLine($"Sort-Swap: {a} - {b}");
            Console.WriteLine("-------------------------------"); 
            double g, f; 
            DoubleSplit(3.14, /* ... */  out g, /* ... */  out f); 
            Console.WriteLine($"Double-Split: {g}|{f}");
        }

        //Übergabe durch return da aufgabe einen RückgabeWert angibt
        static double MySin(double x)
        {
            //sinus Wert
            double sin = 0;
            //Tylor Reihe itteration
            for (int i = 0; i < 18; i++)
            {
                //Formel für Berechung jedes Gliedes und addiere es zum Sinuswert
                sin += Math.Pow(-1, i) *(Math.Pow(x, 2 * i + 1) / Fak(2 * i + 1));
            }

            return sin;
        }

    
        //gibt falkultät von num zurück
        static double Fak(int num)
        {
            //zwischenspeicher von num
            double fac = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fac = fac * i; // multipliziert elment auf fac
            }
            
            return fac; 
        }
        //  return , weil in aufgabe angegeben und  funktioniert für test main 
        static int Wuerfeltest(int rounds)
        {
            //speichert längsten Pasch
            int maxPasch = 0;
            //speichert rand für wiederbenutzung
            Random rand = new Random();
            //generiert 1 zahl ziwschen 1 und 6 
            int num = rand.Next(6) + 1;
            for (int i = 0; i < rounds; i++)
            {
                //bekommt paschlänge in diesem versuch
                int paschRounds = PaschAnzahl(rand, ref num);
                if ( paschRounds> maxPasch) //schaut ob paschlänge größer als der längste pasch ist
                {
                    maxPasch = paschRounds; // überschreibt diesen
                }
            }

            return maxPasch;
        }

        //es sollen 2 werte zurückgegeben werden. Einer durch return und der andere als ref 
        static int PaschAnzahl(Random wuerfel,ref int ersterWurf)
        {
            int rand; //zufällige Zhal
            int rounds = 0; // counter der die runden speichert
            do
            {
                rand = wuerfel.Next(6) + 1; // generiert neue Zahl
                rounds++; 

            } while (rand==ersterWurf); // wiederholt solange bis nichtmer num gewürfelt wurde

            ersterWurf = rand; 
            return rounds;
        }

        // nutzung von ref , weil a und b in der main schon initalisiert sind 

        static void SortSwap(ref int a, ref int b)
        {
            //wenn a > b dann müssen beide werte getaust werden
            if (a>b)
            {
                int tmp = a; // tmp variable speichert a
                a = b; //a bekommt den wert von b 
                b = tmp; // b bekommt den wert von der in tmp gespeicht ist
            }
        }

        //nutzt out,da die variablen in der main noch keine werte zugewiesen bekommen haben
        static void DoubleSplit(double d, out double beforeKomma, out double afterKomma)
        {
            beforeKomma = (int)d; // nimmt teil vor dem komma durchs casten
            afterKomma = d-beforeKomma; // zieht ganzzahligen teil ab um die komma zahl zu bekommen 
        }
    }
    
}