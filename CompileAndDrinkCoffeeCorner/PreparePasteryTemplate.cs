using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal abstract class PreparePasteryTemplate
	{
		public void PreparePastery()
		{
			PrepareDough();
			ShapePastery();
			Bake();

		}

		public void Bake()
		{
			Console.WriteLine("Baking ....");
			Thread.Sleep(1000);
		}

		public abstract void PrepareDough();
		public abstract void ShapePastery();

		
	}
}
