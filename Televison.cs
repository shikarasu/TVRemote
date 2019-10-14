using System;

namespace TVRemote
{
    internal class Television : IElectronicDevice
    {
        private int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The Tv is off");
        }

        public void On()
        {
            Console.WriteLine("The TV is on");
        }

        public void VolumeOff()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine("The TV volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine("The TV volume is at {Volume}");
        }
    }
}