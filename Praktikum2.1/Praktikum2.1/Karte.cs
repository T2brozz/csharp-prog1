using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Praktikum2._1
{
    public class Karte
    {
        private string[] karte = new string[50];
        private Vektor[] startPos = new Vektor[10];
        public Vektor ZielPos { get; private set; }
        public int AnzZeilen { get; private set; }

        /// <summary>
        /// Konstruktor der Klasse Karte
        /// </summary>
        /// <param name="Kartenpfad">Dateipfad der Karte</param>
        public Karte(string Kartenpfad)
        {
            StreamReader sr = new StreamReader(Kartenpfad);
            int line = 0;
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                int newX = zeile.IndexOf("Z");
                if (newX != -1)
                {
                    ZielPos = new Vektor(newX, line);
                }

                for (int i = 0; i < zeile.Length; i++)
                {
                    char character = zeile[i];
                    if (character >= '0' && character <= '9')
                    {
                        startPos[character - '0' - 1] = new Vektor(i, line);
                    }
                }

                karte[line] = zeile;
                line++;
            }


            AnzZeilen = line;
            sr.Close();
        }
        /// <summary>
        /// Gibt Startposition an stelle i zurück
        /// </summary>
        /// <param name="i">index</param>
        public Vektor this[int i]
        {
            get { return startPos[i]; }
        }
        /// <summary>
        /// Kopiere Stringarray in ein Stringbuilder array
        /// </summary>
        /// <returns>Stringbuilderarray</returns>
        public StringBuilder[] CloneKarteToStringBuilder()
        {
            StringBuilder[] builderKarte = new StringBuilder[50];
            for (int i = 0; i < karte.Length; i++)
            {
                builderKarte[i] = new StringBuilder(karte[i]);
            }

            return builderKarte;
        }
        /// <summary>
        /// Diese Methode scannt um ein Zentrum (die aktuelle Roboterposition) herum, ob sich in der
        /// Nähe Hindernisse befinden
        /// </summary>
        /// <param name="Zentrum">Position des Zentrums</param>
        /// <param name="Reichweite">Scanreichweite</param>
        /// <returns></returns>
        public IEnumerable<Vektor> Hindernisliste(Vektor Zentrum, int Reichweite)
        {
            for (int z = (int)(Zentrum.y - Reichweite);
                z <= (int)(Zentrum.y +
                           Reichweite);
                z++)
            {
                if (z >= 0 && z < AnzZeilen)
                {
                    string zeile = karte[z];
                    for (int x = (int)(Zentrum.x - Reichweite);
                        x <= (int)(Zentrum.x +
                                   Reichweite);
                        x++)
                    {
                        if (x >= 0 && x < zeile.Length)
                        {
                            if (zeile[x] == 'X')
                                yield return new Vektor(x, z);
                        }
                    }
                }
            }
        }
    }
}