using System;
using System.Security;

namespace Praktikum05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascalsches Dreieck:");
            int[] f = null;
            for (int i = 0; i < 8; i++)
            {
                f = PascalDreieck(f);
                Console.WriteLine(String.Join(',', f));
            }

            Console.WriteLine();
            Console.WriteLine("Primzahlen bis 20");  
            Primzahlen(20, true); 
            const int Primzahlgrenze = 750000; 
            Console.WriteLine($"Anzahl der Primzahlen bis {Primzahlgrenze}: {Primzahlen(Primzahlgrenze)}"); 
        }

        static int[] PascalDreieck(int[] f)
        {
            if (f == null) // if no if is given
            {
                return new[] {1}; //returning [1]
            }
            int[] fNext = new int[f.Length + 1]; // creates next row which in one element longer
            fNext[0] = 1; //sets first element to 1
            fNext[fNext.Length - 1] = 1; //sets last element to 1
            for (int i = 1; i < fNext.Length - 1; i++) // i =1 because i[1] is 1 
            {
                fNext[i] = f[i - 1] + f[i]; //idk TODO:FIXME
            }
            return fNext;
        }

        static int Primzahlen(int n, bool ausgabe = false)
        {
            return 0;
        }
    }
}