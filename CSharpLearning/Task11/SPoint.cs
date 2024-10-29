using System;

namespace CSharpLearning
{
    struct SPoint
    {
        private int x, y, z;

        public SPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        override public string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
