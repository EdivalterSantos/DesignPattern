using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class TurnTvOff
    {
        private ElectronicDevice _theDevice;

        public TurnTvOff(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }


        public void Execute()
        {
            _theDevice.DeviceOff();
        }

    }
}
