using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal interface InvestmentStrategy
    {
        public decimal updatePrice(decimal amount);
    }
}
