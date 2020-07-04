using System;

namespace ClockClassLibrary
{
    public class DigitalClock
    {
        public int Ss { get => DateTime.Now.Second; }

        public int Mm { get => DateTime.Now.Minute; }

        public int Hh { get => DateTime.Now.Hour; }
    }
}
