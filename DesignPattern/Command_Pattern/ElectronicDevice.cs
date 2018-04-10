using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    interface ElectronicDevice
    {
        void DeviceOn();

        void DeviceOff();

        void VolumeUp();

        void VolumeDown();
    }
}
