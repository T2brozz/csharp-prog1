using System;

namespace AufgabeSchriftlisches_rechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("923","129"));
        }

        static string Add(string a, string b)
        {
            int uebertrag = 0;
            string output = "";
            for (int i = a.Length-1; i> -1 ; i--)
            {
                int num = (a[i]-'0') + (b[i]-'0') + uebertrag; // a[i]-'0' um die zahl rauszubekommen, weil zahl ja ein char ist 
                if (num<10)
                {
                    output = Convert.ToString(num) + output; //fügt zah vorne an den string hinzu
                    uebertrag = 0; 
                }else if (num >= 10)
                {
                    uebertrag = 1;
                    output = Convert.ToString(num-10) + output;
                }
            }

            if (uebertrag==1)
            {
                output = Convert.ToString(1) + output;
            }

            return output;
        }
    }
}