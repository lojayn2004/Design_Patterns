using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace SmartHomeAutomationSystem
{
    internal class Bulb: IDevice
    {
        private bool state;
        private IMode _mode;

        public Bulb(IMode mode) 
        {
            state = false;
            _mode = mode;
        }
        public void TurnOn()
        {
            state = true;
            Console.WriteLine("Turning On Bulb .....");
        }

        public void TurnOff()
        {
            state = false;
            Console.WriteLine("Turning Off Bulb .....");
        }

        public void ShowState()
        {
            if (state is true)
                Console.WriteLine("Bulb is On");
            else
                Console.WriteLine("Bulb is Off");
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
