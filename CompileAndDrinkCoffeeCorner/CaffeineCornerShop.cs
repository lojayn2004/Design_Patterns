using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal class CaffeineCornerShop : ICoffeeShop
	{
		public void PrepareCoffee()
		{
			ICoffee coffee = createCoffee();
			coffee.PrepareCoffee();
		}

		public void PreparePastery()
		{
			IPastry pie = createPastry();
			pie.PreparePastery();

		}

		public ICoffee createCoffee()
		{
			return new Latte();

		}

		public IPastry createPastry()
		{
			return new Pie();
		}
	}
}
