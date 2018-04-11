using System;

namespace Command_Pattern
{
    class Television : ElectronicDevice
    {
        private int _volume = 0;

        public void DeviceOn()
        {
            Console.WriteLine(" Device is on");
            Console.ReadLine();
        }

        public void DeviceOff()
        {
            Console.WriteLine(" Device is off");
            Console.ReadLine();
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine(" Volume is up");
            Console.ReadLine();
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine(" Volume is down");
            Console.ReadLine();
        }
    }
}
