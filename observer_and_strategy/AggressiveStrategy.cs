using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal class AggressiveStrategy: InvestmentStrategy
    {
        public decimal updatePrice(decimal price)
        {
            return price + price * (10 / 100.0m);
        }
    }
}
