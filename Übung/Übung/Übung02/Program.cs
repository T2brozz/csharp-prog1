using System;
using System.Numerics;

namespace Übung02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufgabe05();
        }

        static void Aufgabe01()
        {
            for (int i = 0; i < 1002; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void Aufgabe02()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "ja")
                {
                    Console.WriteLine("Danke ja");
                    break;
                }
                else if (input == "nein")
                {
                }
                else
                {
                    Console.WriteLine("falsche Eingabe");
                }
            }
        }

        static void Aufgabe03()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        static void Aufgabe04()
        {
            int prim = 0;

            for (int i = 2; i <= 100000; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                    prim++;
                }
                else
                {
                    bool isPrim = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i%j==0)
                        {
                            isPrim = false;
                            break;
                        }
                    }
                    if (isPrim)
                    {
                        prim++;
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("count:"+prim);
        }

        static void Aufgabe05()
        {
            BigInteger n_1 = 1;
            BigInteger n_2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(n_2);
                BigInteger tmp = n_1;
                n_1 = n_1 + n_2;
                n_2 = tmp;

            }
        }
    }
}