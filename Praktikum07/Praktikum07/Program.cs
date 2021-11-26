using System;

namespace Praktikum07
{
    class Program
    {
        static void Main(string[] args)
        {
            Abzaehlen(6, 5);
        }

        static int[] Abzaehlen(int n, int m)
        {
            bool[] kinder = new Boolean [n]; // True noch drin , False ausgesieden 
            int[] ausgeschiedeneKinder = new int[n];
            int k = 0; // eine Zähler Variable
            int ausscheiden = m; //Zähler der speichert in wie vieln Runden das Nächste Kind ausscheidet
            //setzt alle Elemete in Kinder auf true
            for (int i = 1; i < n+1; i++)
            {
                kinder[i-1] = true;  //setzt alle Kinder auf True -> 
            }

            while (true)
            {
                if(kinder[k])
                {
                    ausscheiden--;
                }

                if (ausscheiden ==0)
                {

                    kinder[k] = false;
                    Console.WriteLine(string.Join(',',kinder));

                    for (int i = 0; i < ausgeschiedeneKinder.Length; i++)
                    {
                        if (ausgeschiedeneKinder[i]==0)
                        {
                            ausgeschiedeneKinder[i] = k+1;
                            break;
                        }
                    }

                    if (ausgeschiedeneKinder[^1]!=0)
                    {
                        break;
                    }
                    ausscheiden = m;
                }
                
                k++;
                if (k==n)
                {
                    k = 0;
                }
                

            }
            Console.WriteLine(string.Join(',',ausgeschiedeneKinder));
            Console.WriteLine(string.Join(',',new bool[4]));

            return new int[2];
        }

        
    }
}