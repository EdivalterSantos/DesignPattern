using System;

namespace Command_Pattern
{
    public class Television : IEletronicDevice
    {
        public void On()
        {
            Console.WriteLine(" Tv on ");
        }

        public void Off()
        {
            Console.WriteLine(" Tv off ");
        }

        public void VolumeUp()
        {
            Console.WriteLine(" Volume up ");
        }

        public void VolumeDown()
        {
            Console.WriteLine(" Volume down ");
        }
    }
}
