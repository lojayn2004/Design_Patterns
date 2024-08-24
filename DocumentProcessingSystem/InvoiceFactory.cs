using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProcessingSystem
{
    internal class InvoiceFactory: DocumentFactory
    {
        public string ShopName { get; set; }

        public string Receiver { get; set; }

        public List<Tuple<string, decimal>> Items { get; set; }

        public InvoiceFactory(string shopName, string reciever, List<Tuple<string, decimal>> items)
        {
            ShopName = shopName;
            Receiver = reciever;
            Items = items;
        }
        public override DocumentProcessor createDocumnetProcessor()
        {
            return new InvoiceProcessor(ShopName, Receiver, Items); 
        }
    }
}
