using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal class SetModeCommand: Command
    {
        private IDevice _device;
        private IMode _mode;

        public SetModeCommand(IDevice device, IMode mode)
        {
            _device = device;
            _mode = mode;
        }   

        public void Execute()
        {
            _device.SetMode(_mode);
        }
    }
}
