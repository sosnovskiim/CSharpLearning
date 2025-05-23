using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task20
{
    /*
     * Во входном файле указывается количество вершин графа и матрица смежности.
     *  1. Посчитать количество вершин, смежных с данной;
     *  2. Найти все вершины графа, достижимые из данной.
     */
    internal class Task20
    {
        internal static void Execute()
        {
            Graph graph;
            int vertex;

            using (StreamReader fileIn = new StreamReader("../../../Task20/input.txt"))
            {
                int n = int.Parse(fileIn.ReadLine());
                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    string line = fileIn.ReadLine();
                    string[] parts = line.Split();
                    for (int j = 0; j < n; j++) matrix[i, j] = int.Parse(parts[j]);
                }
                graph = new Graph(matrix);
                vertex = int.Parse(fileIn.ReadLine());
            }

            int count = graph.CountAdjacentVertices(vertex);
            List<int> vertices = graph.GetReacheableVertices(vertex);

            using (StreamWriter fileOut = new StreamWriter("../../../Task20/output.txt"))
            {
                fileOut.WriteLine(count);
                fileOut.WriteLine(string.Join(" ", vertices));
            }
        }
    }
}
