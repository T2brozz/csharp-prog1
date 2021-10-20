using System;

namespace Praktikum02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Betrag: ");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Laufzeit: ");
            int time = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("\nBeste Anlage: ");
            if (time >= 10 && money >= 1000) Console.WriteLine("Bundesschatzbrief"); // Laufzeit über 10 Jahre und mindstens 1000 €
            else if (time >= 5 && money >= 5000) Console.WriteLine("Bundesobligationen");   // Laufzeit über 5 Jahre und mindstens 5000 €
            else if (time >= 5 && money >= 2000) Console.WriteLine("Sparbrief"); // Laufzeit über 5 Jahre und mindstens 2000 €
            else if (money >= 5000) Console.WriteLine("Tagesgeld"); // keine Laufzeit und mindstens 5000 €
            else Console.WriteLine("Sparstrumpf"); // Der rest
        }
    }
}