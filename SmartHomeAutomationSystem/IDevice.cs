using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal interface IDevice
    {

        void TurnOn();

        void TurnOff();

        void ShowState();

        void SetMode(IMode mode);

        void ApplyMode();

    }
}
