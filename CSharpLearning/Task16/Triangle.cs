using System;

namespace CSharpLearning.Task16
{
    internal class Triangle : Figure
    {
        private const string NonPositiveValue =
            "Длина стороны треугольника должна быть положительной.";
        private const string InvalidTriangle =
            "Длины сторон должны удовлятворять неравенству треугольника.";

        private int a;
        private int b;
        private int c;

        public int A
        {
            get => a; set
            {
                if (value > 0)
                {
                    if (isValidTriangle(value, b, c)) a = value;
                    else throw new InvalidTriangleException(InvalidTriangle);
                }
                else throw new NonPositiveValueException(NonPositiveValue);
            }
        }

        public int B
        {
            get => b; set
            {
                if (value > 0)
                {
                    if (isValidTriangle(a, value, c)) b = value;
                    else throw new InvalidTriangleException(InvalidTriangle);
                }
                else throw new NonPositiveValueException(NonPositiveValue);
            }
        }

        public int C
        {
            get => c; set
            {
                if (value > 0)
                {
                    if (isValidTriangle(a, b, value)) c = value;
                    else throw new InvalidTriangleException(InvalidTriangle);
                }
                else throw new NonPositiveValueException(NonPositiveValue);
            }
        }

        public Triangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Triangle(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (isValidTriangle(a, b, c))
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                }
                else throw new InvalidTriangleException(InvalidTriangle);
            }
            else throw new NonPositiveValueException(NonPositiveValue);
        }

        public Triangle(Triangle other)
        {
            a = other.a;
            b = other.b;
            c = other.c;
        }

        private bool isValidTriangle(int a, int b, int c) =>
            (a + b > c) && (b + c > a) && (c + a > b);

        private Tuple<int, int, int> sortTriangleSides(int a, int b, int c)
        {
            int[] sides = new int[3] { a, b, c };
            Array.Sort(sides);
            return Tuple.Create(sides[0], sides[1], sides[2]);
        }

        public override double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override double Perimeter => a + b + c;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Triangle) return false;
            Triangle other = (Triangle)obj;
            Tuple<int, int, int> thisSides = sortTriangleSides(a, b, c);
            Tuple<int, int, int> otherSides = sortTriangleSides(other.a, other.b, other.c);
            return thisSides.Equals(otherSides);
        }

        public override int GetHashCode()
        {
            Tuple<int, int, int> sides = sortTriangleSides(a, b, c);
            return (sides.Item1, sides.Item2, sides.Item3).GetHashCode();
        }

        public override string ToString() =>
            $"Треугольник со сторонами {a}, {b} и {c} " +
            $"имеет периметр {Perimeter} и площадь {Math.Round(Area, 2)}.";
    }
}
