using System;

namespace Übung01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("was ist dein Name?");
            string name = Console.ReadLine();
            Console.WriteLine("wie viel geld möchtest du ausgeben?");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hast du Zeit?");
            if (!GetBoolInput())
            {
                Environment.Exit(1);
            }

            Console.WriteLine("Hast du Hunger?");
            if (GetBoolInput())
            {
                if (money < 5)
                {
                    Console.WriteLine("Besuch deine ELtern");
                }
                else if (money > 4 && money < 15)
                {
                    Console.WriteLine("Ess ein Döner?");
                }
                else if (money > 15)
                {
                    Console.WriteLine($"Studiere die Speisekarte{name}");
                }
            }
            else
            {
                Console.WriteLine("Hast du langeweile");
                if (GetBoolInput())
                {
                    if (money < 15)
                    {
                        Console.WriteLine($"Reicht für nichts {name}");

                    }else
                    {
                     Console.WriteLine("was willst du machen?");
                     string whatDo = Console.ReadLine();
                     Console.WriteLine($"Los GEhts! {name}! . JEtzt {whatDo}");
                    }
                }
                
            }
        }

        static bool GetBoolInput()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'y')
            {
                return true;
            }
            else if (input == 'n')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Falsche EIngabe");
                Environment.Exit(1);
            }

            return true;
        }
    }
}