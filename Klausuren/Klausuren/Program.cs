using System;

namespace Klausuren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe19_20_1(3);
            Aufgabe13_3("10");
        }

        static void Aufgabe19_20_1(int eingabe)
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


        static void Aufgabe13_3(string binary)
        {
            static int twoPow(int pow)
            {
                int twoTimes = 1;
                for (int i = 0; i < pow; i++)
                {
                    twoTimes *= 2;
                }

                return twoTimes;
            }

            int dezimal = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    dezimal += twoPow(binary.Length - 1 - i);
                }
                else if (binary[i] == '0')
                {
                }
                else
                {
                    Environment.Exit(-1);
                }
            }

            Console.WriteLine(dezimal);
        }
    }
}