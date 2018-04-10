using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    interface IEletronicDevice
    {
        void On();

        void Off();

        void VolumeUp();

        void VolumeDown();
    }
}
