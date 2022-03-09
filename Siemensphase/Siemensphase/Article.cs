using System;
using System.Collections.Generic;

namespace Siemensphase
{
    public class Article
    {
        public int ID { get; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Article(string name, int count = default, double price = default)
        {
            Name = name;
            Count = count;
            Price = price;
            ID = getID();
        }

        private int getID()
        {
            return new Random().Next(10000);
        }

        public static bool GetArtFromNr(int nr, List<Article> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].ID == nr)
                {
                    return true;
                }
            }

            return false;
        }

        public static int GetArticleInedx(int nr, List<Article> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].ID == nr)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool CountAvailable(int sellArtNr, int sellCount, List<Article> list)
        {
            if (list[GetArticleInedx(sellArtNr, list)].Count >= sellCount)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{ID},{Name},{Count},{Price}";
        }
    }
}