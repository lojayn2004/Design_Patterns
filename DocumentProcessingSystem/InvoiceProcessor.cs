using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal class InvoiceProcessor : DocumentProcessor
    {
        public string ShopName { get; set; }

        public string Receiver { get; set; }

        public List<Tuple<string, decimal>> Items { get; set; }
        public InvoiceProcessor(string shopName, string reciever, List<Tuple<string, decimal>> items)
        {
            ShopName = shopName;
            Receiver = reciever;
            Items = items;
        }
        public override void AddHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.WriteLine($"--------- {ShopName} ------- ");
            Console.WriteLine($"Customer Name: {Receiver}   ");
            Console.WriteLine($"Date: {DateTime.Now} ");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public override void GenerateDocumnet()
        {
            Console.WriteLine("Product Name             Price ");
            decimal totalPrice = 0;
            foreach(Tuple<string, decimal> item in Items)
            {
                  Console.WriteLine(item.Item1 + "         " + item.Item2);
                  totalPrice += item.Item2;
            }

            Console.WriteLine($"Price: {totalPrice}");
            Console.WriteLine("Tax: 20% ");
            Console.WriteLine($"Total Price: {totalPrice + totalPrice * (20 / 100m)}");
        }
    }
}
