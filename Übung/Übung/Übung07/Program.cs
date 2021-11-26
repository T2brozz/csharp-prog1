using System;
using System.Globalization;
using Microsoft.VisualBasic;


namespace Uebung
{
    class BuchstabenHistogramm
    {
        static int Index(char b)
        {
            // TODO
            if (b == 'ä') b = 'a';
            if (b == 'ü') b = 'u';
            if (b == 'ö') b = 'o';
            if (b == 'ß') b = 's';
            int pos = Char.ToUpper(b) - 'A';
            if (pos < 0 || pos > 25)
            {
                return -1;
            }

            return pos;
        }

        static void Main(string[] args)
        {
            string gedicht =
                @"Joachim Ringelnatz: Genau besehn
                  Wenn man das zierlichste Näschen
                  Von seiner liebsten Braut
                  Durch ein Vergrößerungsgläschen
                  Näher beschaut,
                  Dann zeigen sich haarige Berge,
                  Daß einem graut.";

            string satz = "Der böse Aal beißt";

            string test = "Aaboösßz ?.";
            int[] charCount = new int[26];
            foreach (char c in gedicht)
            {
                int charIndex = Index(c);
                if (charIndex != -1)
                {
                    charCount[charIndex] += 1;
                }
            }
            Console.WriteLine((int)'a');
            for (int i = 0; i < 26; i++)
            {
                
                char letter =Convert.ToChar( i + (int)'a');
                Console.WriteLine($"{letter} ({charCount[i]}) {new String('▄',charCount[i])}");
            }
            Console.WriteLine(Removechar("Er sagte: Guten Tag!", ' ', ':', '!'));
            string eingabe = "Heute gibt es Eis! Morgen gibt es Reis."; 
            Console.WriteLine(Flip(eingabe, 'e')); 
        }

        static string Removechar(string str, params char[] chars)
        {
            string output ="";
            foreach (var c in str)
            {
                bool issame = false;
                foreach (var vc in chars)
                {
                    if (c==vc)
                    {
                        issame = true;
                    }
                }
                if (!issame)
                {
                    output += c;
                }
            }

            return output;
        }

        static string Flip(string str, char ch)
        {
            string strArray = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    strArray +=Char.ToUpper(str[i]);
                }else if (str[i] == Char.ToUpper(ch))
                {
                    strArray += Char.ToLower(str[i]);

                }
                else
                {
                    strArray += str[i];
                }
            }

            return Convert.ToString(strArray);
        }
    }
}