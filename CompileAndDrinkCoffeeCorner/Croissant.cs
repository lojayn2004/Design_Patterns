using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileAndDrinkCoffeeCorner
{
	internal class Croissant : PreparePasteryTemplate, IPastry
	{
		public void PreparePastery()
		{
			base.PreparePastery();
		}

		public override void PrepareDough()
		{
			Console.WriteLine("Preparing laminated dough for croissant with butter layers.");
			Thread.Sleep(1000);
		}



		public override void ShapePastery()
		{
			Console.WriteLine("Cutting and rolling the dough into crescent shapes for croissants.");
			Thread.Sleep(1000);
		}
	}
}
