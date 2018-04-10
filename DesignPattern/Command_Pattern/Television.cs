using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> master

namespace Command_Pattern
{
    public class Television : IEletronicDevice
    {
<<<<<<< HEAD
        private int _volume = 0;
        public void On()
        {
            Console.WriteLine(" Tv is on ");
=======
        public void On()
        {
            Console.WriteLine(" Tv on ");
>>>>>>> master
        }

        public void Off()
        {
<<<<<<< HEAD
            Console.WriteLine(" Tv is off ");
=======
            Console.WriteLine(" Tv off ");
>>>>>>> master
        }

        public void VolumeUp()
        {
<<<<<<< HEAD
            _volume++;
            Console.WriteLine(" Volume is up ");
=======
            Console.WriteLine(" Volume up ");
>>>>>>> master
        }

        public void VolumeDown()
        {
<<<<<<< HEAD
            _volume--;
            Console.WriteLine(" Volume is down ");
=======
            Console.WriteLine(" Volume down ");
>>>>>>> master
        }
    }
}
