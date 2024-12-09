using System;

namespace CSharpLearning.Task16
{
    internal class Circle : Figure
    {
        private const string NonPositiveValue =
            "Радиус круга должен быть положительным.";

        private int r;

        public int R
        {
            get => r; set
            {
                if (value > 0) r = value;
                else throw new NonPositiveValueException(NonPositiveValue);
            }
        }

        public Circle() { r = 1; }

        public Circle(int r)
        {
            if (r > 0) this.r = r;
            else throw new NonPositiveValueException(NonPositiveValue);
        }

        public Circle(Circle other) { r = other.r; }

        public override double Area => Math.PI * r * r;

        public override double Perimeter => 2 * Math.PI * r * r;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Circle) return false;
            Circle other = (Circle)obj;
            return r == other.r;
        }

        public override int GetHashCode() => r.GetHashCode();

        public override string ToString() =>
            $"Круг радиусом {r} имеет длину окружности {Math.Round(Perimeter, 2)} " +
            $"и площадь {Math.Round(Area, 2)}.";
    }
}
