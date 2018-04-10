using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class PlayWithRemotes
    {
        static void Main(string[] args)
        {
            ElectronicDevice device = TVRemote.GetDevice();

            TurnTvOn onCommand = new TurnTvOn(device);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.Press();
        }
    }
}
