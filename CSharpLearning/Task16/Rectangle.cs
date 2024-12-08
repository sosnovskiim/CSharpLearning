using System;

namespace CSharpLearning.Task16
{
    internal class Rectangle : Figure
    {
        private double a;
        private double b;

        public Rectangle()
        {
            a = 1;
            b = 1;
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Rectangle(Rectangle other)
        {
            a = other.a;
            b = other.b;
        }

        public override double Area() => a * b;

        public override double Perimeter() => (a + b) * 2;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Rectangle) return false;
            Rectangle other = (Rectangle)obj;
            return a == other.a && b == other.b;
        }

        public override int GetHashCode() => Tuple.Create(a, b).GetHashCode();

        public override string ToString() => $"Прямоугольник со сторонами {a} и {b} " +
            $"имеет площадь {Area()} и периметр {Perimeter()}.";
    }
}
