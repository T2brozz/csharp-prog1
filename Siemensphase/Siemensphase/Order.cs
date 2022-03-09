using System;
using System.Threading;

namespace Siemensphase
{
    public class Order
    {
        private Article article;
        private int count;
        private string buyerName;
        private string address;
        private string mail;

        public Order(Article article, int count, string buyerName, string address, string mail)
        {
            this.article = article;
            this.count = count;
            this.buyerName = buyerName;
            this.address = address;
            this.mail = mail;
        }

        public double TotalPrice()
        {
            return article.Price + count;
        }

        public string GetReceiptSavePath()
        {
            Console.Write("Desktoppfad:");
            return Console.ReadLine();
        }

        public void WriteReceipt()
        {
            Console.WriteLine(GetReceiptSavePath());
            Console.WriteLine($"{buyerName},{mail},{address}");
            Console.WriteLine($"{article.Name} : {article.Price}");
            Console.WriteLine(count);
            Console.WriteLine(TotalPrice());
        }
    }
}