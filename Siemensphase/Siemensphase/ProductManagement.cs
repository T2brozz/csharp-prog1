using System;
using System.Collections.Generic;
using System.Threading;

namespace Siemensphase
{
    public class ProductManagement
    {
        public static void ReciveProduct(List<Article> liste)
        {
            Console.WriteLine(helper.Seperator);
            int input = helper.InputWithPromptInt("wähle\n Option 1 (neuer Artikel) \n Option 2 bestehender Artikel");
            if (input == 1)
            {
                NewProduct(liste);
            }
            else if (input == 2)
            {
                ExistingProduct(liste);
            }
        }

        public static void NewProduct(List<Article> liste)
        {
            Console.WriteLine(helper.Seperator);
            while (true)
            {
                int input = helper.InputWithPromptInt("wähle\n 1. Keine Kategorie \n 2. Elektronik");
                if (input == 1)
                {
                    GetProperties(out string name, out int count, out double price);
                    liste.Add(new Article(name, count, price));
                    break;
                }
                else if (input == 2)
                {
                    GetProperties(out string name, out int count, out double price,out int power);
                    liste.Add(new Electronic(power,name, count, price));
                    break;
                }
            }
        }
        public static void ExistingProduct(List<Article> liste)
        {
        }

        public static void GetProperties(out string name, out int count, out double price)
        {
            name = helper.InputWithPrompt("Produktname");
            count = helper.InputWithPromptInt("anzahl");
            price = Convert.ToDouble(helper.InputWithPrompt("price"));
        }

        public static void GetProperties(out string name, out int count, out double price, out int power)
        {
            name = helper.InputWithPrompt("Produktname");
            count = helper.InputWithPromptInt("Anzahl");
            price = Convert.ToDouble(helper.InputWithPrompt("Price"));
            power = helper.InputWithPromptInt("Power");
        }


       
    }
}