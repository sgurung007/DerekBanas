using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekInterface
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The Tv is off.");
        }

        public void On()
        {
            Console.WriteLine("The Tv is on.");
        }

        public void VolumeDown()
        {
            Console.WriteLine("The Tv Volume is down.");
        }

        public void VolumeUp()
        {
            Console.WriteLine("The Tv Volume is up .");
        }
    }
}
