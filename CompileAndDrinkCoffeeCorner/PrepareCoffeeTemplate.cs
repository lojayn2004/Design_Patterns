using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal abstract class PrepareCoffeeTemplate
	{
		public void PrepareCoffee()
		{
			BoilWater();
			AddCondiments();
			PourInCup();

		}

		public void BoilWater()
		{
			Console.WriteLine("Boiling Water To Prepare Coffee ....");
			Thread.Sleep(1000);
		}
		public void PourInCup()
		{
			Console.WriteLine("Pouring Coffee in Cup ....");
			Thread.Sleep(1000);
		}

		public abstract void AddCondiments();
	}
}
