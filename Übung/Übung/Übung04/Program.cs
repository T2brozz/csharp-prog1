using System;
using System.Linq;

namespace Übung04
{
    class Program
    {


        static void Main(string[] args)
        {
            // define 2 sorted integer arrays
            int[] a1 = {2, 4, 10, 20, 25};
            int[] a2 = {1, 2, 3, 7, 10, 11, 20};
 
// define a third integer array
            int[] a3 = new int[a1.Length + a2.Length];
 
// What does the rest of the code?
            for (int i1 = 0, i2 = 0, i3 = 0, e1 = a1.Length, e2 = a2.Length, e3 = e1 + e2; i3 < e3; ++i3) {
                a3 [i3] = i2 >= e2 || i1 < e1 && a1 [i1] < a2 [i2] ? a1 [i1++] : a2 [i2++];
            }
 
            Console.WriteLine (string.Join (" ", a3));
            Aufgabe01("test");
            Aufgabe02("testtset");
            Aufgabe02("ghabfbafb");
            Console.WriteLine($"10 Namen {string.Join(",",Aufgabe03())}");
            int[,]test=Aufgabe09(3);
            for (int i = 0; i < test.Rank-1; i++)
            {
                for (int j = 0; j < test.GetLength(i)-1; j++)
                {
                    Console.Write($"{test[i,j]},");

                }
                Console.WriteLine();
            }
        }

        static void Aufgabe01(string eingabe)
        {
            for (int i = eingabe.Length - 1; i > -1; i--)
            {
                Console.Write(Convert.ToString(eingabe[i]));
            }

            Console.WriteLine();
        }
        static void Aufgabe02(string eingabe)
        {
            bool ispalindrom = false;
            for (int i = 0; i < eingabe.Length / 2 - 1; i++)
            {
                if (eingabe[i] == eingabe[eingabe.Length - 1 - i])
                {
                    ispalindrom = true;
                }
                else
                {
                    ispalindrom = false;
                    i = eingabe.Length;
                }
            }

            Console.WriteLine($"ist {eingabe} ein Palindrom ? {ispalindrom}");
        }

        static string[] Aufgabe03()
        {
            return new string[] {"a","b","c"};
        }

        static int[,] Aufgabe09(int dim)
        {
            int[,] array = new int[dim,dim] ;
            for (int i = 0; i < array.Rank-1; i++)
            {
                for (int j = 0; j < array.GetLength(i)-1; j++)
                {
                    array[i, j] = i * j;
                }
            }

            return array;
        }
    }
}