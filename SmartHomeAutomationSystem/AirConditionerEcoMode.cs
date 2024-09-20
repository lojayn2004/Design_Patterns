using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class AirConditionerEcoMode: EcoMode
    {
        public override void ApplyMode()
        {
            base.ApplyMode();
            Thread.Sleep(500);
            int temperature = 25; 
            int fanSpeed = 2;    
            
            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Fan Speed: {fanSpeed}");
            Console.WriteLine("Power Saving Mode: Enabled");
        }
    }
}
