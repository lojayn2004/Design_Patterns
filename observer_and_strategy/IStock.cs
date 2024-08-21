using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_and_strategy
{
    internal interface IStock
    {
        public void SubscribeObserver(IObserver observer);
        public void UnSubscribeObserver(IObserver observer);

        public void NotifyObservers();
    }
}
