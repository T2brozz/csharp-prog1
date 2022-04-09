using System;
using System.Runtime.CompilerServices;

namespace Praktikum2._1
{
    public class Vektor
    {
        public double x, y;

        /// <summary>
        /// Konstruktor der Klasse Vektor zur Initialisierung der Variablen
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public Vektor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Rechnet den Vektor als formatstring zurück
        /// </summary>
        /// <returns>Vektor als string</returns>
        public override string ToString()
        {
            return $"{this.x},{this.y}";
        }

        /// <summary>
        /// Setzt die x und y positionen des Vektors auf den gleichen Wert
        /// </summary>
        /// <param name="wert">x und y position</param>
        public void InitAll(double wert)
        {
            x = y = wert;
        }

        /// <summary>
        ///Kalkuliert die Länge des Vektors
        /// </summary>
        /// <param name="v">Vektor zur Berechnung</param>
        /// <returns>Länge des Vektors</returns>
        public static double Dist(Vektor v)
        {
            return Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2));
        }

        /// <summary>
        /// Abstand zwischen zwei Punkten
        /// </summary>
        /// <param name="p1">Vektor 1</param>
        /// <param name="p2">Vektor 2</param>
        /// <returns>Abstand</returns>
        public static double Dist(Vektor p1, Vektor p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        /// <summary>
        /// Subtrahiert zwei Vektoren
        /// </summary>
        /// <param name="p1">Vektor 1</param>
        /// <param name="p2">Vektor 2</param>
        /// <returns>Differenz</returns>
        public static Vektor operator -(Vektor p1, Vektor p2)
        {
            return new Vektor(p1.x - p2.x, p1.y - p2.y);
        }

        /// <summary>
        /// Addiert zwei Vektoren
        /// </summary>
        /// <param name="p1">Vektor 1</param>
        /// <param name="p2">Vektor 2</param>
        /// <returns> Summe</returns>
        public static Vektor operator +(Vektor p1, Vektor p2)
        {
            return new Vektor(p1.x + p2.x, p1.y + p2.y);
        }

        /// <summary>
        /// Skaliert einen Vektor
        /// </summary>
        /// <param name="p">Vektor</param>
        /// <param name="wert">Skalierung</param>
        /// <returns>Skalierter Vektor</returns>
        public static Vektor operator *(Vektor p, double wert)
        {
            return new Vektor(p.x * wert, p.y * wert);
        }

        /// <summary>
        /// Vergleicht zwei Vektoren
        /// </summary>
        /// <param name="p1">Vektor 1</param>
        /// <param name="p2">Vwektor 2</param>
        /// <returns>bool</returns>
        public static bool operator ==(Vektor p1, Vektor p2)
        {
            return p2 is not null && p1 is not null && p1.x == p2.x && p1.y == p2.y;
        }

        /// <summary>
        /// Vergleicht zwei Vektoren, aber verneint das Ergebnis
        /// </summary>
        /// <param name="p1">Vektor 1</param>
        /// <param name="p2">Vektor 2</param>
        /// <returns>bool</returns>
        public static bool operator !=(Vektor p1, Vektor p2)
        {
            return p1 is not null || p2 is not null && !(p1.x == p2.x && p1.y == p2.y);
        }

        /// <summary>
        /// Normalisiert den Vektor
        /// </summary>
        /// <param name="n">Länge des Vektors</param>
        public void Normalisieren(double n = 1.0)
        {
            double d = Math.Sqrt(x * x + y * y) / n;
            x /= d;
            y /= d;
        }
    }
}