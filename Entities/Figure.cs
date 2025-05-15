using System;

namespace Entities
{
    [Serializable]
    public abstract class Figure : IComparable<Figure>
    {
        public int id;

        public int Id { get; set; }

        public int CompareTo(Figure other)
        {
            if (Area > other.Area) return 1;
            if (Area == other.Area) return 0;
            return -1;
        }

        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
        public abstract override string ToString();
    }
}
