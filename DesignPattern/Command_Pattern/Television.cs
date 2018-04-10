using System;

namespace Command_Pattern
{
    public class Television : IEletronicDevice
    {
        private int _volume = 0;
        public void On()
        {
            Console.WriteLine(" Tv is on ");
        }

        public void Off()
        {
            Console.WriteLine(" Tv is off ");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine(" Volume is up ");
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine(" Volume is down ");
        }
    }
}
