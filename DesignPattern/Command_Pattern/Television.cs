using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
