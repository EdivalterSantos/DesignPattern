using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class TurnVolumeUp
    {
        private ElectronicDevice _theDevice;

        public TurnVolumeUp(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }

        public void execute()
        {
            _theDevice.VolumeUp();
        }

    }
}
