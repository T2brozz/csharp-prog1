using System;
using System.IO;
using System.Transactions;

namespace Übung08
{
    class Program
    {
// Ganz oben im Programmdatei einfügen! 

        public static void Main()
        {
            Console.WriteLine("Geben sie ISBN an");
            Ausleihinfo(Console.ReadLine());
        }

        static void Ausleihinfo(string isbn)
        {
            // Schritt 1: Öffnen der Datei zum Lesen 
            // Verwendung eines StreamReaders, um Text-Datei einfach 
            // mit ReadLine() lesen zu können 
            StreamReader sr = new StreamReader("../../../Buecher.txt");


            bool foundIsbn = false;
            while (!sr.EndOfStream && !foundIsbn)
            {
                string[] line = sr.ReadLine().Split("|");
                if (line[0] == isbn)
                {
                    foundIsbn = true;
                    if (line[1] == "ok")
                    {
                        Console.WriteLine($"{line[2]} | ausleihbar");
                    }
                    else
                    {
                        Console.WriteLine($"{line[2]} | verliehen bis: {line[1]}");
                    }
                }
            }

            if (!foundIsbn)
            {
                Console.WriteLine("ISBN nicht vorhanden");
            }


            // Schritt 3: Schließen der Datei 
            sr.Close();
        }
    }
}