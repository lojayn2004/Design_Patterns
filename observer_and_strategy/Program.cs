

using observer_and_strategy;
using System.Net.Http.Headers;

class program
{

    public static void Main()
    {
        TechnologyStock XYStock = new TechnologyStock(new AggressiveStrategy(), "XY", 100);
        TechnologyStock ABStock = new TechnologyStock(new ConservativeStrategy(), "AB", 100);

        IObserver multiSockObserver = new TechnologyStockObserver("Ali");
        IObserver XYObserver = new TechnologyStockObserver("Judy");

        XYStock.SubscribeObserver(multiSockObserver);
        ABStock.SubscribeObserver(multiSockObserver);
        XYStock.SubscribeObserver(XYObserver);

        XYStock.UpdatePrice(200);
        Console.WriteLine("\n------------------------------------------------------\n");
        ABStock.UpdatePrice(200);
        Console.WriteLine("\n------------------------------------------------------\n");
        XYStock.SetInvestmentStrategy(new ConservativeStrategy());
        XYStock.UpdatePrice(100);
    }
}