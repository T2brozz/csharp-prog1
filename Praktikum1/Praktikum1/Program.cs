using System;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte Wert für den Radius eingeben: ");
            double radius=Convert.ToDouble(Console.ReadLine());
            double circleArea = Math.Pow(radius,2) * Math.PI;
            Console.WriteLine("Der Flächeninhalt beträgt: " + circleArea);
        }
    }
}