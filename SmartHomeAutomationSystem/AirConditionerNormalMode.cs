using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class AirConditionerNormalMode: NormalMode
    {
        public override void ApplyMode()
        {
            base.ApplyMode();
            Thread.Sleep(1000);
            int temperature = 22; 
            int fanSpeed = 3;     
            
            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Fan Speed: {fanSpeed}");
            Console.WriteLine("Power Saving Mode: Disabled");
        }
    }
}
