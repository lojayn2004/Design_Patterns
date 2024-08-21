using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal class ConservativeStrategy : InvestmentStrategy
    {
        public decimal updatePrice(decimal amount)
        {
            return amount + amount * (2 / 100.0m);
        }
    }
}
