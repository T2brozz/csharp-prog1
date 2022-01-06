using System;


namespace Übung08
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

        static Kreis NeuerKreis(double radius,double x, double y, Farbe color= Farbe.Schwarz)
        {
            Kreis kreis= new Kreis();
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

        static void SetUmfang(Kreis kreis, double umfang)
        {
            kreis.raduis = umfang / (2 * Math.PI);
        }
        static void Main()
        {
            Kreis[] kreise = new Kreis[3];
            Random rand = new Random();

            for (int i = 0; i < kreise.Length; i++)
            {
                kreise[i].raduis = rand.Next(1, 50);
                kreise[i].x = 40;
                kreise[i].y = 20;
                kreise[i].color = Farbe.Blau;
            }

            int smallestIndex = 0;
            for (int i = 1; i < kreise.Length-1; i++)
            {
                if (kreise[smallestIndex].raduis>kreise[i].raduis)
                {
                    smallestIndex = i;
                }
            }
            SetUmfang(kreise[smallestIndex],30);
            Console.WriteLine(kreise[smallestIndex].raduis);
        }
    }
}