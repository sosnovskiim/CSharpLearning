using System;

namespace CSharpLearning.Task11
{
    internal struct SPoint
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

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
