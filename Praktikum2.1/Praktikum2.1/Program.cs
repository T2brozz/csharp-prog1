using System;

namespace Praktikum2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Karte karte = new Karte(@"../../../feld.txt");
            for (int i = 0; i < 10; i++)
            {

                if (karte[i] != null)
                {


                    Navigator navi = new Navigator(karte, i);
                    if (navi.WegZumZielSuchen())
                        Console.WriteLine("Das Ziel wurde erreicht");
                    else
                        Console.WriteLine("Ziel nicht erreicht!");
                }
            }
        }
    }
}