using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class BulbEcoMode: EcoMode
    {
        public override void ApplyMode()
        {
            base.ApplyMode();
            Console.WriteLine("Reducing Brightness by 30%");
            Thread.Sleep(1000);

            Console.WriteLine("Adjusting Color Temperature to Cooler Hue");
            Thread.Sleep(500); 

            Console.WriteLine("Setting Auto-Off Timer to 30 Minutes");
            Thread.Sleep(500); 

        }
    }
}
