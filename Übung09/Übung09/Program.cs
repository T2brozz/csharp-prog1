using System;


namespace Übung09
{
    class Program
    {
        enum Farbe
        {
            Schwarz,
            Rot,
            Blau
        }

        struct Kreis
        {
            public double raduis;
            public double x;

            public double y;
            public Farbe color;
        }

        static Kreis NeuerKreis(double radius, double x, double y, Farbe color = Farbe.Schwarz)
        {
            Kreis kreis = new Kreis();
            kreis.raduis = radius;
            kreis.x = x;
            kreis.y = y;
            kreis.color = color;

            return kreis;
        }

        static double Umfang(Kreis kreis)
        {
            return 2 * Math.PI * kreis.raduis;
        }

        static void SetUmfang(ref Kreis kreis, double umfang)
        {
            kreis.raduis = umfang / (2 * Math.PI);
        }

        struct Bruch
        {
            public double zaehler;
            public double nenner;
        }

        static string BruchToString(Bruch bruch)
        {
            if (bruch.nenner == 1)
            {
                return Convert.ToString(bruch.zaehler);
            }

            return $"{bruch.zaehler}/{bruch.nenner}";
        }

        static Bruch mult(Bruch b1, Bruch b2)
        {
            double zahler = b1.zaehler * b2.zaehler;
            double nenner = b1.nenner * b2.nenner;
            Bruch b3;
            // Einzeilige Initialisierung in Tupel-Schreibweise 
            (b3.zaehler, b3.nenner) = (zahler, nenner);
            return b3;
        }

        static Bruch add(Bruch b1, Bruch b2)
        {
            double nenner = b1.nenner * b2.nenner;
            double zahler = b1.zaehler * b2.nenner + b2.zaehler * b1.nenner;
            Bruch b4;
            // Einzeilige Initialisierung in Tupel-Schreibweise 
            (b4.zaehler, b4.nenner) = (zahler, nenner);
            return b4;
        }

        static Bruch kurzen(Bruch b1)
        {
            double ggt = 0;
            double zaehler = b1.zaehler;
            double nenner = b1.nenner;
            if (zaehler == 0)
            {
                ggt = nenner;
            }
            else
            {
                while (nenner != 0)
                {
                    if (zaehler > nenner)
                    {
                        zaehler = zaehler - nenner;
                    }
                    else
                    {
                        nenner = nenner - zaehler;
                    }
                }

                ggt = zaehler;
            }

            Bruch b5;
            // Einzeilige Initialisierung in Tupel-Schreibweise 
            (b5.zaehler, b5.nenner) = (b1.zaehler / ggt, b1.nenner / ggt);
            return b5;
        }

        static void Main()
        {
            Kreis[] kreise = new Kreis[3];
            Random rand = new Random();

            for (int i = 0; i < kreise.Length; i++)
            {
                kreise[i] = NeuerKreis(rand.Next(1, 50), 40, 20);
            }

            int smallestIndex = 0;
            for (int i = 1; i < kreise.Length - 1; i++)
            {
                if (kreise[smallestIndex].raduis > kreise[i].raduis)
                {
                    smallestIndex = i;
                }
            }

            SetUmfang(ref kreise[smallestIndex], 30);
            Console.WriteLine(kreise[smallestIndex].raduis);

            Bruch b1= new Bruch() {zaehler = 4,nenner= 3};
            
            Console.WriteLine("b1 = " + BruchToString(b1));

            Bruch b2 = new Bruch() {zaehler = 3,nenner= 2};
           
            Console.WriteLine("b2 = " + BruchToString(b2));
            Console.WriteLine(BruchToString(kurzen(mult(b1, b2))));
            Console.WriteLine(BruchToString(kurzen(add(add(b1, b2), new Bruch() {zaehler = 1, nenner = 6}))));
        }
    }
}