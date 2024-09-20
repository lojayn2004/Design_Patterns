using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class AirConditionerAwayMode: AwayMode
    {

        public override void ApplyMode()
        {
            base.ApplyMode();
            Thread.Sleep(1000);

            int temperature = 28; 
            int fanSpeed = 1;      

            // Simulate air conditioner settings
            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Fan Speed: {fanSpeed}");
            Console.WriteLine("Power Saving Mode: Enabled");
        }
    }

}
