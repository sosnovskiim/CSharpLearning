using System;
using System.Collections.Generic;

namespace CSharpLearning.Task21
{
    internal class CityGraph
    {
        private class CityNode
        {
            private string[] cities;

            private int[,] matrix;

            public int this[int i, int j]
            {
                get { return matrix[i, j]; }
                set { matrix[i, j] = value; }
            }

            public int Size { get { return matrix.GetLength(0); } }

            private bool[] nov;

            public void NovSet()
            {
                for (int i = 0; i < Size; i++) nov[i] = true;
            }

            public CityNode(CityLocation[] cityLocations, int[,] matrix)
            {
                int n = cityLocations.Length;
                cities = new string[n];
                for (int i = 0; i < n; i++) cities[i] = cityLocations[i].Name;
                this.matrix = new int[n, n];
                GetMatrixWithDistances(cityLocations, matrix);
                nov = new bool[Size];
            }

            private void GetMatrixWithDistances(CityLocation[] cityLocations, int[,] matrix)
            {
                for (int i = 0; i < cityLocations.Length; i++)
                {
                    for (int j = 0; j < cityLocations.Length; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            this.matrix[i, j] = (int)Math.Sqrt(
                                Math.Pow(cityLocations[i].X - cityLocations[j].X, 2) +
                                Math.Pow(cityLocations[i].Y - cityLocations[j].Y, 2)
                            );
                        }
                    }
                }
            }

            public void DepthFirstSearch(int v)
            {
                Console.WriteLine(cities[v]);
                nov[v] = false;
                for (int u = 0; u < Size; u++)
                {
                    if (matrix[v, u] != 0 && nov[u])
                    {
                        DepthFirstSearch(u);
                    }
                }
            }

            public void BreadthFirstSearch(int v)
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(v);
                nov[v] = false;
                while (q.Count > 0)
                {
                    v = q.Dequeue();
                    Console.WriteLine(cities[v]);
                    for (int u = 0; u < Size; u++)
                    {
                        if (matrix[v, u] != 0 && nov[u])
                        {
                            q.Enqueue(u);
                            nov[u] = false;
                        }
                    }
                }
            }

            public long[,] Floyd(int[,] matrix)
            {
                long[,] distances = new long[Size, Size];

                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (i == j) distances[i, j] = 0;
                        else if (matrix[i, j] == 0) distances[i, j] = int.MaxValue;
                        else distances[i, j] = matrix[i, j];
                    }
                }

                for (int k = 0; k < Size; k++)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size; j++)
                        {
                            long distance = distances[i, k] + distances[k, j];
                            if (distances[i, j] > distance) distances[i, j] = distance;
                        }
                    }
                }

                return distances;
            }

            public long[,] GetDistancesAfterEdgeRemove(int i, int j)
            {
                int[,] matrix = this.matrix.Clone() as int[,];
                matrix[i, j] = 0;
                matrix[j, i] = 0;
                return Floyd(matrix);
            }
        }

        private CityNode cityGraph;

        private string[] cities;

        public CityGraph(CityLocation[] cityLocations, int[,] matrix)
        {
            int n = cityLocations.Length;
            cities = new string[n];
            for (int i = 0; i < n; i++) cities[i] = cityLocations[i].Name;
            cityGraph = new CityNode(cityLocations, matrix);
        }

        public void PrintMatrix()
        {
            int n = cityGraph.Size;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{cityGraph[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public void DepthFirstSearch(int v)
        {
            cityGraph.NovSet();
            cityGraph.DepthFirstSearch(v);
            Console.WriteLine();
        }

        public void BreadthFirstSearch(int v)
        {
            cityGraph.NovSet();
            cityGraph.BreadthFirstSearch(v);
            Console.WriteLine();
        }

        public string TryRemoveCityGraphEdge(int distance)
        {
            int n = cityGraph.Size;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (cityGraph[i, j] != 0)
                    {
                        long[,] distances = cityGraph.GetDistancesAfterEdgeRemove(i, j);
                        if (AreAllDistancesLessThanSpecified(distances, distance))
                        {
                            PrintDistances(distances);
                            return $"Можно перекрыть дорогу между городами {cities[i]} и {cities[j]}, " +
                                $"чтобы расстояние между городами не превышало {distance}";
                        }
                    }
                }
            }
            return $"Нельзя перекрыть какую-либо дорогу так, " +
                $"чтобы расстояние между любыми городами не превышало {distance}";
        }

        public bool AreAllDistancesLessThanSpecified(long[,] distances, int distance)
        {
            int n = cityGraph.Size;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (distances[i, j] > distance) return false;
                }
            }
            return true;
        }

        public void PrintDistances(long[,] distances)
        {
            int n = cityGraph.Size;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{distances[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
