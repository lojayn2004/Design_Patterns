using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomationSystem
{
    internal abstract class NormalMode: IMode
    {
        public virtual void ApplyMode()
        {
            Console.WriteLine("Applying Normal Mode ......");

        }

    }
}
