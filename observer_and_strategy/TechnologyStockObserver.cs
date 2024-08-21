using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal class TechnologyStockObserver: IObserver
    {
        private List<TechnologyStock> _stocks = new List<TechnologyStock>();
        
        private string Name { get; }
        public TechnologyStockObserver(string Name)
        {
            this.Name = Name;
        }
        
        public void UnSubscribe(TechnologyStock stock)
        {
            if(_stocks.Contains(stock))
            {
                stock.UnSubscribeObserver(this);
                _stocks.Remove(stock);
            }
        }

        public void Update(object technologySt)
        {
            TechnologyStockData stock = (TechnologyStockData)technologySt;
            Console.WriteLine($"{Name} Received update from {stock.CompanyName}: for new Price {stock.CurrentPrice}");
        }
    }
    
}
