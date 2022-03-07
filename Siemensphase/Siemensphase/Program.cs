using System;

namespace Siemensphase
{
    class Program
    {
        static void Main(string[] args)
        {
            int addv;
            int multv;
            sumMult(3,4,out addv,out multv);
            Console.WriteLine(addv);
            Console.WriteLine(multv);
        }

        static void sumMult(int a, int b, out int add, out int mult)
        {
            add = a + b;
            mult = a * b;
        }
    }
}