using System;

namespace CSharpLearning.Task16
{
    internal class Circle : Figure
    {
        private double r;

        public Circle() { r = 1; }

        public Circle(double r) { this.r = r; }

        public Circle(Circle other) { r = other.r; }

        public override double Area() => Math.PI * r * r;

        public override double Perimeter() => 2 * Math.PI * r * r;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Circle) return false;
            Circle other = (Circle)obj;
            return r == other.r;
        }

        public override int GetHashCode() => r.GetHashCode();

        public override string ToString() => $"Круг с радиусом {r} " +
            $"имеет площадь {Area()} и длину окружности {Perimeter()}.";
    }
}
