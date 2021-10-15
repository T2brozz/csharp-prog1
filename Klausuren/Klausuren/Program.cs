using System;

namespace Klausuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufgabe01(3);
        }

        static void Aufgabe01(int eingabe)
        {
            char eingabeString = Convert.ToChar(Convert.ToString(eingabe));
            Console.WriteLine(Convert.ToString(eingabeString));
            int anzahl = 0;
            for (int i = 100; i < 1000; i++)
            {
                if (i % eingabe == 0)
                {
                    anzahl++;
                }
                else
                {
                    string iString = Convert.ToString(i);
                
                    for (int j = 0; j < 2; j++)
                    {
                        if (iString[j] == eingabeString)
                        {
                            Console.WriteLine(iString);
                            anzahl++;
                            break;
                        }
                    }
                }
            }


            Console.WriteLine(anzahl);
        }
    }
}