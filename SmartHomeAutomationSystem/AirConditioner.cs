using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class AirConditioner : IDevice
    {
        private bool state;
        private IMode _mode;

        public AirConditioner(IMode mode)
        {
            state = false;
            _mode = mode;
        }
        public void TurnOn()
        {
           
            Console.WriteLine("Turning On AirConditioner .....");
            state = true;
        }

        public void TurnOff()
        {
            state = false;
            Console.WriteLine("Turning Off AirConditioner .....");
        }

        public void ShowState()
        {
            if (state is true)
                Console.WriteLine("AirConditioner is On");
            else
                Console.WriteLine("AirConditioner is Off");
        }

        public void SetMode(IMode mode)
        {
            if (mode is not null)
                _mode = mode;

        }

        public void ApplyMode()
        {

            _mode.ApplyMode();
        }
    }

}

