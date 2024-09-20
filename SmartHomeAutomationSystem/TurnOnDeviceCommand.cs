using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class TurnOnDeviceCommand : Command
    {
        private IDevice _device;

        public TurnOnDeviceCommand(IDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.TurnOn();
        }
    }
}
