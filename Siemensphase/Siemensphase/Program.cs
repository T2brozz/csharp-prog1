using System;
using static Siemensphase.vector;
namespace Siemensphase
{
    class Program
    {
        struct men
        {
            
        }
        static void Main(string[] args)
        {
            /*
              int a = 1;
             
            int b = 2;
            int c = 3;
            sumMult(ref a, ref b, ref c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(prdukt(4,0));
            */
            /*
            cat cati = new cat();
            cati.age = 3;
            cati.domesticCat = false;
            cati.name = "klauis";
            cati.favfood = "none";
            cati.intro();
            cati.meow();
            */
            vector vec = new vector(3, 4);
            Console.WriteLine(vec.Length);
            
            
        }

        static void sumMult(ref int a, ref int b, ref int c)
        {
            a += 1;
            b += 2;
            c += 3;
        }

        static int prdukt(int val, int times)
        {
            if (times <= 1)
            {
                return val;
            }

            return prdukt(val, times-1) + val;

        }
        
    }

    class animal
    {
        public string name;
        public string favfood;
        public int age;

        public void intro()
        {
            Console.WriteLine($"{name},{favfood},{age}");
        }
    }

    class dog : animal
    {
        public void bark()
        {
            Console.WriteLine("bark!!");
        }
    }

    class cat : animal
    {
        public bool domesticCat;

        public void meow()
        {
            Console.WriteLine("meow!!");
        }
    }
}