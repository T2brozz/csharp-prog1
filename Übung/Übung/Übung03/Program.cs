using System;

namespace Übung03
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            Console.WriteLine("Hello World!");
            aufgabe01("Willst Du programmieren", "Klar", "Nö");
            Console.WriteLine($"MAx Wert von 3 29 3 -1 ist {max(3, 29, 3, -1)}");
            Console.WriteLine($"ist 5864 ein SChaltjahr? {schaltjahr(5864)}");
            Console.WriteLine($"QUersumme von 345 ist {quersumme(345)}");
            Console.WriteLine($"10 Fib zahl ist {fib(1,0,10)}");
            Console.WriteLine($"Durchschitt von 5 Zahlen {average(5,out test)}, SUmme der 5 Zhalen ist {test}");
        }

        static bool aufgabe01(string text, string wahr, string falsch)
        {
            while (true)
            {
                Console.WriteLine(text);
                string eingabe = Console.ReadLine();
                if (eingabe == wahr)
                {
                    return true;
                }
                else if (eingabe == falsch)
                {
                    return false;
                }
            }
        }

        static int max(int one, int two, int three, int four)
        {
            int[] num = {one, two, three, four};
            int maxval = -10000;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maxval)
                {
                    maxval = num[i];
                }
            }
            return maxval;
        }

        static bool schaltjahr(int jahr)
        {
            if (jahr % 4 == 0 && jahr % 100 != 0)
            {
                return true;
            }
            return false;
        }

        static int quersumme(int zahl)
        {
            int quer = 0;
            bool isZero = false;
            while (!isZero)
            {
                quer += zahl % 10;

                if (zahl%10==0)
                {
                    isZero = true;

                }
                zahl = zahl / 10;
            }
            return quer;
        }

        static int fib(int a, int b, int n)
        {
            if (n == 0)
            {
                return b;
            }
            return (fib(a + b, a, n - 1));
        }

        static double average(int count, out int sum )
        {
            double avg = 0;
            for (int i = 0; i < count; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                avg += (double) num / (double) count;
            }

            sum =Convert.ToInt32( avg * (double) count);
            return avg;
        }
    }
}