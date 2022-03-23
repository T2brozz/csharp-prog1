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

// auch der Weg hineingeschrieben werden kann
        public Navigator(Karte karte, int Kartenindex)
        {
            meineKarte = karte;
            ausgKarte = karte.CloneKarteToStringBuilder();
            aktPosition = karte[Kartenindex];
            zielPosition = karte.ZielPos;
            kartenIndex = Kartenindex;
        }

        public bool ZielErreicht()
        {
            return Vektor.Dist(meineKarte[kartenIndex], zielPosition) < 1;
        }

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

        public bool WegZumZielSuchen()
        {
            int counter = 0;
            while (counter < 150 && !ZielErreicht())
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