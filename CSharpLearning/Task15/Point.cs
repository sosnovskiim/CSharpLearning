﻿using System;

namespace CSharpLearning.Task15
{
    internal class Point
    {
        private int x;
        private int y;

        public Point() { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double DistanceToPoint(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }

        public void MoveToVector(int a, int b)
        {
            x += a;
            y += b;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Multiply { set { x *= value; y *= value; } }

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                if (i == 1) return y;
                Console.WriteLine("Недопустимый индекс");
                return 0;
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else Console.WriteLine("Недопустимый индекс");
            }
        }

        public static Point operator ++(Point p) => new Point(p.x + 1, p.y + 1);

        public static Point operator --(Point p) => new Point(p.x - 1, p.y - 1);

        public static bool operator true(Point p) => p.x == p.y;

        public static bool operator false(Point p) => p.x == p.y;

        public static Point operator +(Point p, int a) => new Point(p.x + a, p.y + a);

        public static Point operator +(int a, Point p) => p + a;

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not Point) return false;
            Point p = (Point)obj;
            return x == p.x && y == p.y;
        }

        public override int GetHashCode() => Tuple.Create(x, y).GetHashCode();

        public override string ToString() => $"({x}, {y})";
    }
}
