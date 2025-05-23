using System.IO;

namespace CSharpLearning.Task21
{
    /*
     * Во входном файла в первой строке указывается количество городов.\
     * 
     * Начиная со второй строки в каждой строке через пробел указываются
     * название города и его координаты в декартовой системе координат.
     * 
     * После описания всех городов приводится матрица смежности графа,
     * описывающая схему дорог (вес ребра считается расстоянием между городами).
     * 
     * Определить, можно ли перекрыть какую-либо дорогу так, чтобы расстояние
     * между любыми городами не превышало некоторого заданного расстояния.
     */
    internal class Task21
    {
        internal static void Execute()
        {
            CityGraph cityGraph;
            int distance;

            using (StreamReader fileIn = new StreamReader("../../../Task21/input.txt"))
            {
                int n = int.Parse(fileIn.ReadLine());
                CityLocation[] cityLocations = new CityLocation[n];
                for (int i = 0; i < n; i++)
                {
                    string line = fileIn.ReadLine();
                    string[] parts = line.Split();
                    cityLocations[i] = new CityLocation(
                        parts[0], int.Parse(parts[1]), int.Parse(parts[2])
                    );
                }
                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    string line = fileIn.ReadLine();
                    string[] parts = line.Split();
                    for (int j = 0; j < n; j++) matrix[i, j] = int.Parse(parts[j]);
                }
                cityGraph = new CityGraph(cityLocations, matrix);
                distance = int.Parse(fileIn.ReadLine());
            }

            using (StreamWriter fileOut = new StreamWriter("../../../Task21/output.txt"))
            {
                fileOut.WriteLine(cityGraph.TryRemoveCityGraphEdge(distance));
            }
        }
    }
}
