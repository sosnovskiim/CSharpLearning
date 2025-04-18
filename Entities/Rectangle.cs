using System;

namespace Entities
{
    [Serializable]
    public class Rectangle : Figure
    {
        private const string NonPositiveValue =
            "Длина стороны прямоугольника должна быть положительной.";

        private int a;
        private int b;

        public int A
        {
            get => a; set
            {
                if (value > 0) a = value;
                else throw new Exception(NonPositiveValue);
            }
        }

        public int B
        {
            get => b; set
            {
                if (value > 0) b = value;
                else throw new Exception(NonPositiveValue);
            }
        }

        public Rectangle()
        {
            a = 1;
            b = 1;
        }

        public Rectangle(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                this.a = a;
                this.b = b;
            }
            else throw new Exception(NonPositiveValue);
        }

        public Rectangle(Rectangle other)
        {
            a = other.a;
            b = other.b;
        }

        public override double Area => a * b;

        public override double Perimeter => (a + b) * 2;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Rectangle) return false;
            Rectangle other = (Rectangle)obj;
            return a == other.a && b == other.b || a == other.b && b == other.a;
        }

        public override int GetHashCode() => (a ^ b).GetHashCode();

        public override string ToString() =>
            $"Прямоугольник со сторонами {a} и {b} " +
            $"имеет периметр {Perimeter} и площадь {Area}.";
    }
}
