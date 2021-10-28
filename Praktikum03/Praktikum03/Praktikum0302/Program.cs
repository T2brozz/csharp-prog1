using System;

namespace Praktikum0302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine obere Grenze an: ");
            int max = Convert.ToInt32(Console.ReadLine());  
            int random = new Random().Next(1,max); //Zufällige Zahl
            bool guessed = false; // Bool um zu schauen ob richtig geraten wurde
            int tries = 0; // hält anzahl an versuchen
            Console.WriteLine($"Welche Zahl zwischen 1 und {max} habe ich mir ausgesucht? ");

            while (!guessed)
            {
                tries++;  
                Console.Write($"{tries}. Versuch: ");

                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > random)Console.WriteLine("Zu Groß!"); // Zahl größer als zufallszahl
                else if (guess< random)Console.WriteLine("Zu klein!"); //  Zahl kleiner als zufallszahl
                else if(guess == random)
                {
                    guessed = true; // setzt guessed zu true und wirkt dadurch als break
                    Console.WriteLine($"Richtig! Du hast {tries} Versuche gebraucht. ");
                }
            }
        }
    }
}