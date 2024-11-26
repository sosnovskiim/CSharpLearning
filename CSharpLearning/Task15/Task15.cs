using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task15
{
    internal class Task15
    {
        /*
         * Решить задачу, разработав собственный класс Point.
         * Для хранения экземпляров класса использовать типизированную коллекцию List<>.
         * Продемонстрировать работу класса Point.
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

                    // Добавление еще нескольких точек
                    points.Add(new Point());
                    points.Add(new Point(3, -3));
                    points.Add(new Point(points[1]));

                    // Проверка работы методов
                    fileOut.WriteLine(
                        $"Расстояние от точки {points[4]} до начала координат равно {points[4].DistanceToOrigin()}."
                    );
                    fileOut.WriteLine(
                        $"Расстояние от точки {points[0]} до точки {points[3]} равно {points[0].DistanceToPoint(points[3])}."
                    );
                    fileOut.WriteLine($"Точка {points[0]} будет перемещена на вектор {points[1]}.");
                    points[0].MoveToVector(points[1][0], points[1][1]);

                    fileOut.WriteLine(
                        $"Точка {points[1]} {(points[1].Equals(points[3]) ? "" : "не ")}совпадает с точкой {points[3]}."
                    );

                    fileOut.WriteLine(
                        $"Хэш-коды точек {points[1]} и {points[4]} " +
                        $"{(points[1].GetHashCode() == points[4].GetHashCode() ? "" : "не ")}идентичны."
                    );

                    fileOut.WriteLine($"Классом точки {points[0]} является {points[0].GetType()}.");

                    fileOut.WriteLine("Итоговый список точек:");
                    foreach (Point p in points)
                    {
                        fileOut.WriteLine(p);
                    }
                }
            }
        }
    }
}
