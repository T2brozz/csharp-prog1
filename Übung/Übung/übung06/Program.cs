using System;
using System.Reflection.PortableExecutable;

namespace übung06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            aufgabe02();
        }

        static void aufgabe01()
        {
            int[,] testarr = aufgabeA();
            ausgabe(testarr);
            Console.WriteLine();
            ausgabe(aufgabeC(testarr));
            testarr = aufgabeA();
            Console.WriteLine("\n");
            ausgabe(testarr);
            Console.WriteLine("-----------");
            Console.WriteLine(string.Join(",",aufgabed(testarr)));
            
            static int[,] aufgabeA()
            {
                int[,] arr = new int[3, 5];
                Random rand = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rand.Next(10);
                    }
                }

                return arr;
            }

            static void ausgabe(int[,] ausgabearr)
            {
                for (int i = 0; i < ausgabearr.GetLength(0); i++)
                {
                    for (int j = 0; j < ausgabearr.GetLength(1); j++)
                    {
                        Console.Write(ausgabearr[i, j] + ",");
                    }

                    Console.WriteLine();
                }
            }

            static int[,] aufgabeC(int[,] arr)
            {
                int[,] output = new int[arr.GetLength(1), arr.GetLength(0)];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        output[j, i] = arr[i, j];
                    }
                }

                return output;
            }

            static int[] aufgabed(int[,] arr)
            {
                int[] sum = new int[arr.GetLength(1)];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sum[j] += arr[i, j];
                    }
                }


                return sum;
            }
        }

        static void aufgabe02()
        {
            static int ZifferAnzahl(int num, int ziffer)
            {
                int numTemp = num;
                int numCount = 0;
                while (numTemp != 0)
                {
                    if (numTemp % 10 == ziffer)
                    {
                        numCount++;
                    }

                    numTemp /= 10;
                }

                return numCount;
            }
            int[] count = new int[10];
            int seats = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < seats+1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    count[j] += ZifferAnzahl(i, j);
                }
            }
            Console.WriteLine("1  2  3  4  5  6  7  8  9  0");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(count[i]+" ");
            }
        }
    }
}