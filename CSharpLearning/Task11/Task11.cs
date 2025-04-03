using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task11
{
    /*
     * Решить задачу, используя структуру SPoint для хранения координат точки.
     * Найти точку в пространстве, которая наиболее удалена от начала координат.
     */
    internal class Task11
    {
        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task11/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task11/output.txt"))
                {
                    List<SPoint> maxDistancePoints = new List<SPoint>() { new SPoint(0, 0, 0) };
                    string line;
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        string[] coordinates = line.Split();
                        SPoint point = new SPoint(
                            int.Parse(coordinates[0]),
                            int.Parse(coordinates[1]),
                            int.Parse(coordinates[2])
                        );
                        double distance = point.Distance();
                        double maxDistance = maxDistancePoints[0].Distance();
                        if (distance >= maxDistance)
                        {
                            if (distance > maxDistance)
                            {
                                maxDistancePoints.Clear();
                            }
                            maxDistancePoints.Add(point);
                        }
                    }
                    foreach (SPoint maxDistancePoint in maxDistancePoints)
                    {
                        fileOut.WriteLine($"{maxDistancePoint.Distance()}, {maxDistancePoint}");
                    }
                }
            }
        }
    }
}
