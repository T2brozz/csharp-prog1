using System;

namespace Praktikum0301
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe
            Console.WriteLine("Geben sei den Min Wert!");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("den Max Wert an");
            int max = Convert.ToInt32(Console.ReadLine());
            
            for (int i = min + 1; i < max; i++)
            {
                if (i % 7 == 0) Console.Write(i +" "); //Wenn Zahl / 7 Rest 0 hat -> ausgabe
            }
            Console.WriteLine();
            Console.WriteLine("Geben Sie eine Positive Zahl an");
            int num = Convert.ToInt32(Convert.ToUInt32(Console.ReadLine())); 
            //Conver.unit32 um bei negativen zahlen error ruaszuwerfen
            
            for (int i = num; i > 0; i--)
            {
                string output ="";
                if ((num - i) % 5 == 0) output += "\n"; //alle 5 zahlen ein newline
                if (i<10) output+=" "; // leerzeichen wenn einstellig
                Console.Write($"\t{output}{i}"); //ausgabe
            }
        }
    }
}