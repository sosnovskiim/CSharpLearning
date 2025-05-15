using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task20
{
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
