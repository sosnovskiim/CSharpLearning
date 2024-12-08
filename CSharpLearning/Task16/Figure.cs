using System;

namespace CSharpLearning.Task16
{
    abstract internal class Figure : IComparable<Figure>
    {
        public int CompareTo(Figure other)
        {
            if (Area() > other.Area()) return 1;
            if (Area() == other.Area()) return 0;
            return -1;
        }

        abstract public double Area();
        abstract public double Perimeter();
        abstract public override bool Equals(object obj);
        abstract public override int GetHashCode();
        abstract public override string ToString();
    }
}
