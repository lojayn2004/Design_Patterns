using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal class Pie : PreparePasteryTemplate, IPastry
	{

		public override void PrepareDough()
		{
			Console.WriteLine("Preparing shortcrust pastry dough for pie.");
			Thread.Sleep(1000);
		}

		public void PreparePastery()
		{
			base.PreparePastery();
		}

		public override void ShapePastery()
		{
			Console.WriteLine("Rolling out the dough and shaping it into a pie crust.");
			Thread.Sleep(1000);
		}
	}
}
