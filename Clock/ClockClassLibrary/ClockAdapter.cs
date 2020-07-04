using System;

namespace ClockClassLibrary
{
    public class ClockAdapter
    {
        private DigitalClock DigitalClock { get; }

        // constant stores angle between minutes segments
        private const int MINUTE_ANGLE = 6;

        // constant stores angle between hours segments
        private const int HOUR_ANGLE = 30;

        // constant stores hour hand offset per minute
        private const double HOUR_OFFSET = 0.5;

        private const double RADIAN = Math.PI / 180;

        public ClockAdapter(DigitalClock digitalClock)
        {
            DigitalClock = digitalClock ?? throw new ArgumentNullException(nameof(digitalClock));
        }

        public double[] GetSsHandPosition()
        {
            int degr = DigitalClock.Ss * MINUTE_ANGLE;

            return GetRotation(degr);
        }

        public double[] GetMmHandPosition()
        {
            int degr = DigitalClock.Mm * MINUTE_ANGLE;

            return GetRotation(degr);
        }

        public double[] GetHhHandPosition()
        {
            int degr = (int)(DigitalClock.Hh % 12 * HOUR_ANGLE + DigitalClock.Mm * HOUR_OFFSET);

            return GetRotation(degr);
        }

        private double[] GetRotation(int degree)
        {
            double[] rotation = new double[2];

            rotation[0] = Math.Sin(RADIAN * degree);
            rotation[1] = Math.Cos(RADIAN * degree);
            return rotation;
        }
    }
}
