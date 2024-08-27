using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal class Espresso : PrepareCoffeeTemplate, ICoffee
	{
		public void PrepareCoffee()
		{
			base.PrepareCoffee();
		}

		public override void AddCondiments()
		{
			Console.WriteLine("Adding Heavy Cream ...");
			Console.WriteLine("Adding Vanilla Extract ...");
			Console.WriteLine("Adding Amaretto ....");
			Thread.Sleep(1000);
		}
	}
}
