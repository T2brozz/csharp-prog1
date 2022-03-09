using System;

namespace Siemensphase
{
    public class vector
    {
        private int x;
        private int y;

        public double Length
        {
            get { return Math.Sqrt(x * x + y * y); }
        }

        public vector(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.x = x;
            this.y = y;

        }
    }
}