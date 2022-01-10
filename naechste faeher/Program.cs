using System;
using System.IO;

namespace naechste_faeher
{
    class Program
    {
        static void Main(string[] args)
        {
            NeachsteFaehren("Calais", 17, 0);
        }

        static void NeachsteFaehren(string ort, int std, int min)
        {
            min += std * 60;
            int maxAusgaben = 0;
            StreamReader
                sr = new StreamReader(
                    "../../../data.txt"); // datei lesen . (relativer pfad, muss evtl angepassst werden )
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                // Verarbeite Zeile ... 
                string[]
                    zeilenangaben = zeile.Split('|'); //splitted bei | index 0 = zeit , index 1 = name ; index 2 = preis
                if (zeilenangaben[1].StartsWith(ort) && maxAusgaben < 3)
                {
                    string[] zeit = zeilenangaben[0].Split(':');
                    int minuten = Convert.ToInt32(zeit[0]) * 60 + Convert.ToInt32(zeit[1]);
                    if (minuten >= min)
                    {
                        Console.WriteLine($"Fähre von {zeilenangaben[1]}: {zeilenangaben[0]}    {zeilenangaben[2]}");
                        maxAusgaben++;
                    }
                }
            }

            if (maxAusgaben == 0)
            {
                Console.WriteLine("Keine Fähre mehr!”");
            }

            sr.Close();
        }
    }
}