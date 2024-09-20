using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class BulbAwayMode: AwayMode
    {
        public override void ApplyMode()
        {
            base.ApplyMode();

            Console.WriteLine("Turning Off the Bulb");
            Thread.Sleep(500); 

            Console.WriteLine("Setting Auto-On Timer for Random Intervals");
            Thread.Sleep(500); 

            Console.WriteLine("Simulating Presence with Random Light Blinking");
            Thread.Sleep(1000); 
        }
    }
}
