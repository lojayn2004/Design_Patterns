using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal class Latte : PrepareCoffeeTemplate, ICoffee
	{
		public void PrepareCoffee()
		{
			base.PrepareCoffee();
		}
		public override void AddCondiments()
		{
			Console.WriteLine("Steaming Milk ...");
			Console.WriteLine("Adding Steamed Milk to Coffee ...");
			Console.WriteLine("Adding Vanilla Syrup ..."); 
			Console.WriteLine("Sprinkling Cinnamon on Top ..."); 
			Thread.Sleep(1000);
		}


	}
}
