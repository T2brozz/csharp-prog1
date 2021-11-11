using System;

namespace Übung05
{
    class Program
    {
        static void Main(string[] args)
        {
          aufgabe04();
        }

        static void aufgabe01()
        {
            Console.WriteLine("Hello World!");
            int ziffer = 7;
            int num = 523423;
            int numCount = ZifferAnzahl(num, ziffer);
            Console.WriteLine($"Die Zahl {num} enthält {numCount} {ziffer}");
            if (numCount == 1)
            {
                Console.WriteLine($"DIe Zahl enthählt genau 1 mal die {ziffer}");
            }
            else
            {
                Console.WriteLine($"DIe Zahl enthählt nicht genau 1 mal die {ziffer}");
            }

            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = min; i < max+1; i++)
            {
                numCount = ZifferAnzahl(i, 7);
                if (numCount==1)
                {
                    Console.WriteLine(i);
                }
            }
            
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
        }

        static void aufgabe02()
        {
            int[] wuerfel = {3, 3, 3, 3}; // true 
            // 2. Testfall 
            //int[] wuerfel = { 4, 4, 4, 2, 3 }; // false 
            if (kniffelCheck(wuerfel)) 
                Console.WriteLine("Kniffel!"); 
            else 
                Console.WriteLine("Kein Kniffel");
            
            Console.Write("Würfelzahl eingeben:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int tries = 0;
            while (true)
            {
                tries++;
                int[] row = new int[n];
                Random rand = new Random();
                for (int i = 0; i < row.Length ; i++)
                {
                    row[i] = rand.Next(6) + 1;
                }

                Console.WriteLine(tries+".  Wurf"+string.Join(',', row));
                bool kniffle = kniffelCheck(row);
                if (kniffle)
                {
                    break;
                }
                
            }
            Console.WriteLine($"Kniffel nach dem {tries}. Wurf! ");
            

            static bool kniffelCheck(int[] row)
            {
                for (int i = 1; i < row.Length-1; i++)
                {
                    if (row[i-1]!=row[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void aufgabe03()
        {
            int[] a = {5, 3, 8, 9, 8, 2}; 
            Sort(ref a); 
            Console.WriteLine(String.Join(',',a));
            static void Sort(ref int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int smallestIndex = i;
                    for (int j = i; j < arr.Length; j++)
                    {
                        
                        if (arr[smallestIndex]>arr[j])
                        {
                            smallestIndex = j;
                        }
                    }
                    int tmp = arr[i];
                    arr[i] = arr[smallestIndex];
                    arr[smallestIndex] = tmp;
                }
            }
        }

        static void aufgabe04()
        {
            Console.WriteLine(QuersummeRecursive(3521));
            static int QuersummeIterative(int num)
            {
                int quer = 0;
                while (num != 0)
                {
                    quer+=num % 10; 

                    num /= 10;
                }

                return quer;
            }

            static int QuersummeRecursive(int n)
            {
                if (n==0)
                {
                    return n;
                }

                return n % 10 + QuersummeRecursive((n / 10));
            }
        }
    }
}