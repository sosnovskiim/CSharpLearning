using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task15
{
    internal class Task15
    {
        /*
         * Создать класс Point и продемонстрировать его работу.
         */
        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task15/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task15/output.txt"))
                {
                    List<Point> points = new List<Point>();
                    string line;
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        string[] coordinates = line.Split();
                        points.Add(new Point(int.Parse(coordinates[0]), int.Parse(coordinates[1])));
                    }

                    // Конструкторы.
                    points.Add(new Point());
                    points.Add(new Point(3, -3));
                    points.Add(new Point(points[1]));

                    // Метод DistanceToOrigin
                    Point p1 = points[4];
                    fileOut.WriteLine($"Расстояние от точки {p1} до начала координат равно {p1.DistanceToOrigin()}.\n");

                    // Метод DistanceToPoint.
                    p1 = points[0];
                    Point p2 = points[3];
                    fileOut.WriteLine($"Расстояние от точки {p1} до точки {p2} равно {p1.DistanceToPoint(p2)}.\n");

                    // Метод MoveToVector и индексаторы.
                    p1 = points[0];
                    p2 = points[4];
                    fileOut.WriteLine($"Точка {p1} будет перемещена на вектор {p2}.");
                    p1.MoveToVector(p2[0], p2[1]);
                    fileOut.WriteLine($"Теперь эта точка имеет координаты {p1}.\n");

                    // Переопределенный метод Equals.
                    p1 = points[2];
                    p2 = points[3];
                    fileOut.WriteLine($"Точка {p1} {(p1.Equals(p2) ? "" : "не ")}совпадает с точкой {p2}.\n");

                    // Переопределенный метод GetHashCode.
                    p1 = points[1];
                    p2 = points[4];
                    fileOut.WriteLine($"Хэш-коды точек {p1} и {p2} {(p1.GetHashCode() == p2.GetHashCode() ? "" : "не ")}идентичны.\n");

                    // Наследованный метод GetType.
                    p1 = points[3];
                    fileOut.WriteLine($"Классом точки {p1} является {p1.GetType()}.\n");

                    // Свойства X и Y.
                    p1 = points[0];
                    string quarter = "";
                    if (p1.X > 0 && p1.Y > 0) quarter = " первой";
                    else if (p1.X < 0 && p1.Y > 0) quarter = "о второй";
                    else if (p1.X < 0 && p1.Y < 0) quarter = " третьей";
                    else quarter = " четвертой";
                    fileOut.WriteLine($"Точка {p1} находится в{quarter} четверти.\n");

                    // Свойство Multiply.
                    p1 = points[1];
                    int scalar = -2;
                    fileOut.WriteLine($"Координаты точки {p1} будут умножены на {scalar}.");
                    p1.Multiply = scalar;
                    fileOut.WriteLine($"Теперь эта точка имеет координаты {p1}.\n");

                    // Перегруженные операторы инкремента и декремента.
                    p1 = points[2];
                    p2 = points[3];
                    fileOut.WriteLine($"Точки {p1} и {p2} будут передвинуты на единицу по диагонали.");
                    p1++; p2--;
                    fileOut.WriteLine($"Теперь эти точки имеют координаты {p1} и {p2}.\n");

                    // Перегруженные операторы true и false.
                    p1 = points[0];
                    p2 = points[2];
                    fileOut.WriteLine($"Координаты точки {p1} {(p1 ? "" : "не ")}совпадают.");
                    fileOut.WriteLine($"Координаты точки {p2} {(p2 ? "" : "не ")}совпадают.\n");

                    // Перегруженные операторы суммы и разности.
                    p1 = points[3];
                    p2 = points[4];
                    int a1 = -3;
                    int a2 = 5;
                    fileOut.WriteLine($"Точки {p1} и {p2} будут передвинуты на {a1} и {a2} по диагонали соответственно.");
                    p1 += a1;
                    p2 += a2;
                    fileOut.WriteLine($"Теперь эти точки имеют координаты {p1} и {p2}.\n");

                    fileOut.WriteLine("Итоговый список точек:");
                    foreach (Point p in points) fileOut.WriteLine(p);
                }
            }
        }
    }
}
