using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal interface ICoffeeShop
	{

		public ICoffee createCoffee();
		public IPastry createPastry();

	}
}
