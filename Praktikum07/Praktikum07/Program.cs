using System;

namespace Praktikum07
{
    class Program
    {
        static void Main(string[] args)
        {
            //ausagbe des Arrays der Funktion
            Console.WriteLine(string.Join(',',Abzaehlen(6, 5)));
        }

        static int[] Abzaehlen(int n, int m)
        {
            bool[] kinder = new Boolean [n]; // True noch drin , False ausgesieden 
            int[] ausgeschiedeneKinder = new int[n];
            int k = 0; // eine Zähler Variable um zu zählen wie viele Runden vergangen sind 
            int ausscheiden = m; //Zähler der speichert in wie vieln Runden das Nächste Kind ausscheidet
           
            //setzt alle Elemete in Kinder auf true
            for (int i = 1; i < n+1; i++)
            {
                kinder[i-1] = true;  //setzt alle Elemente auf True w 
            }

            while (true) 
            {
                if(kinder[k]) //wenn das Kind noch drin ist(wenn es drin ist)
                {
                    ausscheiden--;  // runterzählen bis zum nächsten ausscheiden eines Kindes
                }

                if (ausscheiden ==0) // wenn auscheiden 0 ist 
                {

                    kinder[k] = false; // kind scheidet aus

                    // ordnet kind in der ausgeschiedeneKinder Liste  ein um die reihenfolge ihres Ausscheidens zu erstellen
                    for (int i = 0; i < ausgeschiedeneKinder.Length; i++)  
                    {
                        if (ausgeschiedeneKinder[i]==0) // wenn element null
                        {
                            ausgeschiedeneKinder[i] = k+1; // setz element zu index von kinderliste und addiere 1
                            break;
                        }
                    }

                    // wenn das letzte Element nicht mehr 0 ist dann ist die liste voll und funktion kann beendet werden
                    if (ausgeschiedeneKinder[^1]!=0)
                    {
                        break;
                    }
                    ausscheiden = m; //ausgeschieden wird wieder auf m gesetzt um in m runden wieder ein KInd ausscheiden lassen
                }
                
                k++; //Runde wird erhöht
                if (k==n) // wenn n Runden(k) vergangen sind, dann wird k wieder zurück gesegt auf 0  
                {
                    k = 0;
                }
                

            }
   
            return ausgeschiedeneKinder; // Liste wird zurück gegeben 
        }

        
    }
}