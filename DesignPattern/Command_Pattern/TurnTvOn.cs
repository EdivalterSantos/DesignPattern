using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class TurnTvOn : Command
    {
        private ElectronicDevice _theDevice;
        public TurnTvOn(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }

        public void Execute()
        {
            _theDevice.DeviceOn();
        }
    }
}
