using System;
using System.Runtime.CompilerServices;

namespace Praktikum2._1
{
    public class Vektor
    {
        public double x, y;


        public Vektor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{this.x},{this.y}";
        }

        public void InitAll(double Wert)
        {
            x = y = Wert;
        }

        public static double Dist(Vektor v)
        {
            return Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2));
        }

        public static double Dist(Vektor p1, Vektor p2) // Abstand zwischen zwei Punkten
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        public static Vektor operator -(Vektor p1, Vektor p2)
        {
            return new Vektor(p1.x - p2.x, p1.y - p2.y);
        }

        public static Vektor operator +(Vektor p1, Vektor p2)
        {
            return new Vektor(p1.x + p2.x, p1.y + p2.y);
        }

        public static Vektor operator *(Vektor p, double Wert)
        {
            return new Vektor(p.x * Wert, p.y * Wert);
        } // Mult Vektor mit Skalar

        public static bool operator ==(Vektor p1, Vektor p2)
        {
            return p2 is not null && p1 is not null && p1.x == p2.x && p1.y == p2.y;
        }

        public static bool operator !=(Vektor p1, Vektor p2)
        {
            return  p1 is not null  ||p2 is not null && !(p1.x == p2.x && p1.y == p2.y);
        }

        public void Normalisieren(double n = 1.0)
        {
            double d = Math.Sqrt(x * x + y * y) / n;
            x /= d;
            y /= d;
        }
    }
}