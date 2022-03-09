using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Siemensphase
{
    class Program
    {
        public static List<Article> list = new List<Article>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Invetory();
                Selection();
            }
        }

        static void Invetory()
        {
            foreach (var arr in list)
            {
                Console.WriteLine(arr.ToString());
            }
        }

        static void Selection()
        {
            int input = helper.InputWithPromptInt("wähle\n Option 1 Verkaufen \n Option 2 wareneingang");
            if (input == 1)
            {
                Sell();
            }
            else if (input == 2)
            {
                ProductManagement.ReciveProduct(list);
            }
        }

        static void Sell()
        {
            int artnr = helper.InputWithPromptInt("Artikelnummer");
            int index = Article.GetArticleInedx(artnr, list);
            if (index == -1)
            {
                throw new ArgumentException();
            }

            Article art = list[index];
            int count = helper.InputWithPromptInt("Anzahl");
            if (!Article.CountAvailable(artnr, count, list))
            {
                Console.WriteLine("Arktikel nicht verfügbar");
                throw new Exception();
            }

            Console.WriteLine(count * art.Price);
            Order order = new Order(art, count, "Hans Meiner", "Musterstraße", "x@mail.com");
            Console.WriteLine(helper.Seperator);
            order.WriteReceipt();
            art.Count -= count;
        }
    }
}