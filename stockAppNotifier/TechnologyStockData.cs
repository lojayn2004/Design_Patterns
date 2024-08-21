using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal class TechnologyStockData
    {
        public string CompanyName { get; set; }
        public decimal CurrentPrice { get; set; }

        public TechnologyStockData(string companyName, decimal currentPrice)
        {
            CompanyName = companyName;
            CurrentPrice = currentPrice;
        }

        public void UpdatePrice(decimal newPrice)
        {
            CurrentPrice = newPrice;
        }


    }
}
