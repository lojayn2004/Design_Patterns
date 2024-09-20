using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class BulbNormalMode: NormalMode
    {
        public override void ApplyMode()
        {
            base.ApplyMode();

            Console.WriteLine("Setting Brightness to 100%");
            Thread.Sleep(500); 

            Console.WriteLine("Adjusting Color Temperature to Comfortable Hue");
            Thread.Sleep(500); 

          
            Console.WriteLine("Ensuring the Bulb is On");
            Thread.Sleep(500); 
        }
    }
}
