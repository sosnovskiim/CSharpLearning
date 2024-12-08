using System;

namespace CSharpLearning.Task16
{
    internal class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle(Triangle other)
        {
            a = other.a;
            b = other.b;
            c = other.c;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter() => a + b + c;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Triangle) return false;
            Triangle other = (Triangle)obj;
            return a == other.a && b == other.b && c == other.c;
        }

        public override int GetHashCode() => Tuple.Create(a, b, c).GetHashCode();

        public override string ToString() => $"Треугольник со сторонами {a}, {b} и {c} " +
            $"имеет площадь {Area()} и периметр {Perimeter()}.";
    }
}
