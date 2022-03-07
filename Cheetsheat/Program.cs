using System;

namespace Cheetsheat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void EinundAsugabe()
        {
            Console.WriteLine("Guten Tag!");
            Console.Write("Bitte geben Sie etwas ein: ");
            string eingabe = Console.ReadLine();
        }

        static void FormatStrings()
        {
            string anrede = "Herr";
            string name = "Meier";
            int i = 26;
            double pi = 3.14159265359;
            Console.WriteLine($"Hallo, {anrede} {name}!"); // "Hallo, Herr Meier!"
            Console.WriteLine($"{i + 1}"); // 27 (= i+1)
            Console.WriteLine($"{i,5}"); // 26 - 5-stellig mit Leerzeichen
            Console.WriteLine($"{i:d5}"); // 00026 - Dezimal, 5-stellig mit führ. Nullen
            Console.WriteLine($"{i:00000}"); // 00026 - Dezimal, 5-stellig mit führ. Nullen
            Console.WriteLine($"{pi:f}"); // 3.14 - Gleitkomma, Standard = 2 Nachkomma
            Console.WriteLine($"{pi:f1}"); // 3.1 - Gleitkomma, eine Nachkommastelle
            Console.WriteLine($"{pi:0.0}"); // 3.1 - Gleitkomma, eine Nachkommastelle
            Console.WriteLine($"{pi,7:f3}"); // 3.142 - 7-stellig gesamt mit 3 Nachkomma
            Console.WriteLine($"{pi:E}"); // 3,141593E+000 - wissenschaftlich
            Console.WriteLine($"{i:X}"); // 1A - Hexadezimal
            Console.WriteLine($"{i:x4}"); // 001a - Hex klein, 4-stellig
            Console.WriteLine($"i = {i} und pi = {pi:f4}"); // i = 26 und pi = 3,1416 
            int std = 17, min = 4, sek = 1;
            Console.WriteLine($"{std:00}:{min:00}:{sek:00}"); // 17:04:01

            //Unicode encoding
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Das kostet 5,99€"); // ansonsten wird 5,99? ausgegeben
        }

        static void switchts()
        {
            switch (value)
            {
                case "DE":
                    break;
                default:
                    break;
            }
        }

        static void schleifen()
        {
            for (int i = 0; i < UPPER; i++)
            {
                IAsyncDisposable
            }

            while ()
            {
            }

            do
            {
            } while ();
        }

        static void Funktionen()
        {
            static Rückgabewerttyp FunktionsName(int x)
            {
                return; // Beendet funktion, wenn Rückgabewerttyp void ist
                return Rückgabewert;
            }

            static void Add(params double[] werte)
            {
                //Add(3.5, 1.3);
                //Angabe von doubles , ohne davor definierte Anzahl . 
                //Beim Aufruf Kommagetrennnt
            }

            static void Add(ref int a, out int b)
            {
                //int x=5; 
                //int y;
                //Add(x, y);
                //ref und out parameter -> Call by Reference 
                //wenn a in der Funktion geändert wird, ändert sich auch x . y ist undefiniert und deswegen out parameter
            }
        }

        static int[] Arrays()
        {
            int[] v = { 1, 5, 6 };
            int[] v1 = new int[anzahlDerElemente];
            // Ausgabe eines Array 
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);

            //foreach loop
            foreach (string Element in Array)
                Console.WriteLine(Element);
        }

        static int[,] MultArrays()
        {
            int y = 3;
            int x = 2;

            //definitionsmöglichkeiten
            int[,] matrix = new int[y, x];

            int[,] intarr = new int[3, 2]
            {
                //3 und 2 in new intt[3,2] dürfen keine wariablen sein, aber constanten 
                { 4, 5 },
                { 5, 0 },
                { 3, 1 }
            };
            int[,] intarr1 = new int[,] { { 4, 5 }, { 5, 0 }, { 3, 1 } };

            //Länge von matrix 3*2 = 6
            matrix.Length;

            //ausgabe
            // loop in y Richtung
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loop inx Richtung
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]},");
                }

                Console.WriteLine();
            }


            //Ausgefranste Arrays (Jagged Arrays) 
            // Arrays aus Arrays
            int[][] m = new int[3][]; // Bei Erzeugung wird nur erste Dim. angegeben!
            m[0] = new int[4] { 3, 5, 4, 2 };
            m[1] = new int[2] { 6, 1 };
            m[2] = new int[3] { 8, 3, 7 };
            Console.WriteLine("Länge von m: " + m.Length); // == 9!
            for (int i = 0; i < m.Length; i++) // wichtig: m.Length ist hier 3!!
            {
                for (int j = 0; j < m[i].Length; j++)
                    Console.Write("{0,4}", m[i][j]);
                Console.WriteLine();
            }
        }

        static string Strings()
        {
            string s = "Yeah";
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            string s = "Ohm ist super";
            string s1 = s.ToUpper(); // liefert "PROGRAMMIEREN IST SUPER"
            int pos = s.IndexOf("ist"); // liefert 4
            string s2 = s.Substring(4, 3); // liefert "ist"
            string s3 = s.Substring(4, 3).ToUpper(); // liefer "IST"
            string s3 = s[4..7]; // Range von 4 bis 6 "ist"
            char last = s[^1]; // letztes Zeichen , d.h. s[s.Length-1]
            string s5 = s[^5..]; // letzte 5 Zeichen "super"
            string[] p = s.Split("ist");
        }

        static char Chars()
        {
            string s = "Hallo4711";
            int i = s[0] - 'A'; // 7
            int j = s[0] - 'a'; // -25  Out of Range
            int k = char.ToLower(s[0]) - 'a'; // 7
            int l = s[5] - '0'; // 4
            int m = s[4] - '0'; // 63  Out of Range

            string s = "Code: 0815";
            Console.WriteLine("String: " + s);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                    Console.WriteLine(s[i] + ": Großbuchstabe");
                else if (s[i] >= 'a' && s[i] <= 'z')
                    Console.WriteLine(s[i] + ": Kleinbuchstabe");
                else if (s[i] >= '0' && s[i] <= '9')
                    Console.WriteLine(s[i] + ": Ziffer");
                else
                    Console.WriteLine(s[i] + ": anderes Zeichen");
            }
        }

        static void Exceptions()
        {
            // Werfen ein Exception
            //throw new ArgumentException("Negatives n ist nicht erlaubt");
            try
            {
                //  Block of code to try
                bool a = false;
            }
            catch (Exception e) //catch und oder finnally muss nach dem try gegeben werden
            {
                //  Block of code to handle errors
                throw new Exception();
            }
            finally // wird danach immer ausgeführt
            {
                int b;
            }

            // Alternativ: eingebautes Exception-Handling für die Zahlenkonvertierung
            // in der TryParse-Funktion
            int zahl;
            if (!Int32.TryParse(Console.ReadLine(), out zahl))
                Console.WriteLine("Ungültige Eingabe, bitte nochmal versuchen.");
            else
                decimal;
            do
            {
                Console.Write("Zahl eingeben: ");
                if (!Int32.TryParse(Console.ReadLine(), out zahl))
                    Console.WriteLine("Ungültige Eingabe, bitte nochmal versuchen.");
                else
                    break;
            } while (true);
        }

        static void Datein()
        {
            using System.IO ;
            //lesen einer Datei
            StreamReader sr = new StreamReader("Beispieldatei.txt");
            while (!sr.EndOfStream)
            {
                zeile = sr.ReadLine();
                Console.WriteLine((++nr) + ": " + zeile);
            }

            sr.Close();
            //schreiben einer datei
            StreamWriter
                sw = new StreamWriter(dateiname); // "bool append=true" würde an Datei angehängt, statt überschrieben:
            for (int i = 10; i <= 20; i++)
                sw.WriteLine("{0,3} zum Quadrat = {1,4}", i, (i * i));
            // Schritt 3: Schließen der Datei
            sw.Close();
        }

        struct car
        {
            public int test; //sichtbar
            private string color; // nicht sichbar

            public car(int test, string color) //constructor
            {
                this.test = test;
                this.color = color;
            }

            public string Describe() //funktion
            {
                return "This car is " + test;
            }
        }

        static void structs()
        {
            //initialisierung
            car car = new car(2, "test");
            //wenn kein construcktor, dann können keine werte gleich mitübergeben werden
            car.Describe(); //methodenaufruf
            car.test = 43; //  wert des Structs ändern
        }

        enum Farbe
        {
            Schwarz,
            Rot,
            Blau
        }

        static void enums()
        {
            //enum wie struct nicht in funktionen definierbar, sondern in der Klasse  z.B Program
            Console.WriteLine(Farbe.Blau);
        }

        static void mainArgs()
        {
            //zugriff mit z.B. args[0] auf das erste command line argument 
        }

        static void SelectionSort(ref List<int> feld)
        {
            // alle Zahlen durchlaufen
            for (int i = 0; i < feld.Count; i++)
            {
                // Position min der kleinsten Zahl ab Position i suchen
                int min = i;
                for (int j = i + 1; j < feld.Count; j++)
                {
                    if (feld[j] < feld[min])
                    {
                        min = j;
                    }
                }

                // Zahl an Position i mit der kleinsten Zahl vertauschen
                int tmp = feld[min];
                feld[min] = feld[i];
                feld[i] = tmp;
            }
        }

        static int IntArrayLinearSearch(int[] data, int item)
        {
            for (int i = 0; i < data.Length; i++)
                if (data[i] == item)
                    return i;
            
             static string ToBase(string number, int start_base, int target_base)
            {
                int base10 = ToBase10(number, start_base);
                string rtn = FromBase10(base10, target_base);
                return rtn;
            }

             static int ToBase10(string number, int start_base)
            {
                if (start_base < 2 || start_base > 36)
                    return 0;
                if (start_base == 10)
                    return Convert.ToInt32(number);
                char[] chrs = number.ToCharArray();
                int m = chrs.Length - 1;
                int n = start_base;
                int x;
                int rtn = 0;
                foreach (char c in chrs)
                {
                    if (char.IsNumber(c))
                        x = int.Parse(c.ToString());
                    else
                        x = Convert.ToInt32(c) - 55;
                    rtn += x * (Convert.ToInt32(Math.Pow(n, m)));
                    m--;
                }

                return rtn;
            }

             static string FromBase10(int number, int target_base)
            {
                if (target_base < 2 || target_base > 36)
                    return "";
                if (target_base == 10)
                    return number.ToString();
                int n = target_base;
                int q = number;
                int r;
                string rtn = "";
                while (q >= n)
                {
                    r = q % n;
                    q = q / n;
                    if (r < 10)
                        rtn = r.ToString() + rtn;
                    else
                        rtn = Convert.ToChar(r + 55).ToString() + rtn;
                }

                if (q < 10)
                    rtn = q.ToString() + rtn;
                else
                    rtn = Convert.ToChar(q + 55).ToString() + rtn;
                return rtn;
            }
             static int ConvertToInt(string s)
             {
                 int number = 0;

                 for (int i = s.Length - 1, j = 1; 0 <= i; i--, j *= 10)
                     number += (s[i] - '0') * j;

                 return number;
             }
        }
        
    }
}