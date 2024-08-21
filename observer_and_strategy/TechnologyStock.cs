using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal class TechnologyStock: IStock
    {
        private List<IObserver> technologyStockObservers;
        TechnologyStockData data;
        InvestmentStrategy investmentStrategy;
        public TechnologyStock(InvestmentStrategy investmentStrategy, string companyName, decimal price)
        {
            this.investmentStrategy = investmentStrategy;
            data = new TechnologyStockData(companyName, price);
            technologyStockObservers = new List<IObserver>();
        }

        public void UpdatePrice(decimal price)
        {
            price = investmentStrategy.updatePrice(price);
            data.UpdatePrice(price);
            NotifyObservers();
        }

        public void SubscribeObserver(IObserver observer)
        {
            technologyStockObservers.Add(observer);

        }

        public void UnSubscribeObserver(IObserver observer) 
        {
            technologyStockObservers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in technologyStockObservers)
            {
                observer.Update(data);
            }
        }

        public void SetInvestmentStrategy(InvestmentStrategy investmentStrategy)
        {
            this.investmentStrategy = investmentStrategy;
        }


    }
}
