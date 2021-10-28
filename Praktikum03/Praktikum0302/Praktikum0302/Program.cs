using System;

namespace Praktikumß3ß2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine obere Grenze an: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int random = new Random().Next(1,max);
            bool guessed = false;
            int tries = 0;
            Console.WriteLine($"Welche Zahl zwischen 1 und {max} habe ich mir ausgesucht? ");

            while (!guessed)
            {
                tries++;
                Console.Write($"{tries}. Versuch: ");

                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > random)Console.WriteLine("Zu Groß!");
                else if (guess< random)Console.WriteLine("Zu klein!");
                else if(guess == random)
                {
                    guessed = true;
                    Console.WriteLine($"Richtig! Du hast {tries} Versuche gebraucht. ");
                }
            }
        }
    }
}