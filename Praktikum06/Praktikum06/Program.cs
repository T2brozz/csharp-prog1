using System;

namespace Praktikum06
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double d = -Math.PI; d < Math.PI; d+=0.3) 
            { 
                Console.WriteLine($"{Math.Sin(d),25} | {MySin(d),25} | {Math.Sin(d)-MySin(d),25}"); 
            }
            Console.WriteLine("-------------------------------"); 
           
            Console.WriteLine($"Wuerfeltest: längste Kette: {Wuerfeltest(10000)}"); 
            // Die Anzahl bei funktionierendem Programm erhöhen! 
 
            Console.WriteLine("-------------------------------"); 
        }

        static double MySin(double x)
        {
            double sin = 0.0;
            for (int i = 0; i < 18; i++)
            {
                sin += Math.Pow(-1, i) * (double)(Math.Pow(x, 2 * i + 1) / (double) Fac(2 * i + 1));
            }

            return sin;
        }

        static long Fac(int num)
        {
            long fac = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fac = fac * i;
            }
            
            return fac;
        }
        static int Wuerfeltest(int rounds)
        {
            int maxPasch = 0;
            Random rand = new Random();
            int num = rand.Next(6) + 1;
            for (int i = 0; i < rounds; i++)
            {
                int paschRounds = PaschAnzahl(rand, ref num);
                if ( paschRounds> maxPasch)
                {
                    maxPasch = paschRounds;
                }
            }

            return maxPasch;
        }

        static int PaschAnzahl(Random wuerfel,ref int ersterWurf)
        {
            int rand;
            int rounds = 0;
            do
            {
                rand = wuerfel.Next(6) + 1;
                rounds++;

            } while (rand==ersterWurf);

            ersterWurf = rand;
            return rounds;
        }
        
    }
    
}