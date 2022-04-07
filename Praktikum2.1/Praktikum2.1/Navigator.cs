using System;
using System.Text;

namespace Praktikum2._1
{
    public class Navigator
    {
        Karte meineKarte;
        Vektor aktPosition; // aktuelle Roboterposition
        Vektor zielPosition; // Zielposition der Wegeplanung
        private int kartenIndex;

        StringBuilder[] ausgKarte; // (Ausgabe-) Karte für die Wegeplanung, in welche

        /// <summary>
        /// Konstruktor der Klasse Navigator zur Initialisierung
        /// </summary>
        /// <param name="karte"> Kartenobjekt</param>
        /// <param name="Kartenindex">index der startposition</param>
        public Navigator(Karte karte, int Kartenindex)
        {
            meineKarte = karte;
            ausgKarte = karte.CloneKarteToStringBuilder();
            aktPosition = karte[Kartenindex];
            zielPosition = karte.ZielPos;
            kartenIndex = Kartenindex;
        }

        /// <summary>
        /// Schaut ob man sich auf dem Ziel befindet
        /// </summary>
        /// <returns>bool</returns>
        public bool ZielErreicht()
        {
            return Vektor.Dist(aktPosition, zielPosition) < 1;
        }

        /// <summary>
        /// Berechnung des nächsten Navigationsschrittes 
        /// </summary>
        public void NaechsterKurs()
        {
            Vektor zielVektor = zielPosition - aktPosition;
            zielVektor.Normalisieren(6.0);
            foreach (Vektor hindernis in meineKarte.Hindernisliste(aktPosition, 3))
            {
                Vektor hindernisvektor = aktPosition - hindernis; //Operanten ueberladung
                double d = Vektor.Dist(hindernisvektor);
                hindernisvektor.Normalisieren();
                hindernisvektor = hindernisvektor * (4 - d); //Operanten ueberladung
                zielVektor = zielVektor + hindernisvektor; //Operanten ueberladung
            }

            zielVektor.Normalisieren(1.0);
            aktPosition += zielVektor; //Operanten ueberladung

            ausgKarte[(int)(aktPosition.y + 0.5)][(int)(aktPosition.x + 0.5)] = '*';
        }

        /// <summary>
        /// Printet die Karte mit den Wegpunkten
        /// </summary>
        public void KarteUndWegAusgeben()
        {
            foreach (var zeile in ausgKarte)
            {
                if (zeile.ToString().Length != 0)
                {
                    Console.WriteLine(zeile.ToString());
                }
            }
        }

        /// <summary>
        /// Sucht dewn Weg zum Ziel und gibt aus ob das Ziel erreicht wurde
        /// </summary>
        /// <returns> Ob ziel erreicht wurde</returns>
        public bool WegZumZielSuchen()
        {
            int counter = 1;
            while (counter < 300 && !ZielErreicht())
            {
                NaechsterKurs();
                counter++;
            }

            KarteUndWegAusgeben();

            Console.WriteLine($"AnzSchritte: {counter}");
            return ZielErreicht();
        }
    }
}