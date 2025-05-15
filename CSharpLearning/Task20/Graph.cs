using System;
using System.Collections.Generic;

namespace CSharpLearning.Task20
{
    internal class Graph
    {
        private class Node
        {
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

            public Node(int[,] matrix)
            {
                this.matrix = matrix;
                nov = new bool[Size];
            }

            public void DepthFirstSearch(int v)
            {
                Console.Write($"{v} ");
                nov[v] = false;
                for (int u = 0; u < Size; u++)
                {
                    if (matrix[v, u] != 0 && nov[u]) DepthFirstSearch(u);
                }
            }

            public void BreadthFirstSearch(int v)
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(v);
                nov[v] = false;
                while (q.Count != 0)
                {
                    v = q.Dequeue();
                    Console.Write($"{v} ");
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

            public List<int> GetReacheableVertices(int v)
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(v);
                nov[v] = false;
                while (q.Count != 0)
                {
                    v = q.Dequeue();
                    for (int u = 0; u < Size; u++)
                    {
                        if (matrix[v, u] != 0 && nov[u])
                        {
                            q.Enqueue(u);
                            nov[u] = false;
                        }
                    }
                }
                List<int> vertices = new List<int>();
                for (int i = 0; i < Size; i++)
                {
                    if (!nov[i]) vertices.Add(i);
                }
                return vertices;
            }
        }

        private Node graph;

        public Graph(int[,] matrix) => graph = new Node(matrix);

        public void PrintMatrix()
        {
            for (int i = 0; i < graph.Size; i++)
            {
                for (int j = 0; j < graph.Size; j++)
                {
                    Console.Write($"{graph[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void DepthFirstSearch(int v)
        {
            graph.NovSet();
            graph.DepthFirstSearch(v);
            Console.WriteLine();
        }

        public void BreadthFirstSearch(int v)
        {
            graph.NovSet();
            graph.BreadthFirstSearch(v);
            Console.WriteLine();
        }

        public int CountAdjacentVertices(int v)
        {
            int count = 0;
            for (int j = 0; j < graph.Size; j++)
            {
                if (graph[v, j] == 1) count++;
            }
            return count;
        }

        public List<int> GetReacheableVertices(int v)
        {
            graph.NovSet();
            return graph.GetReacheableVertices(v);
        }
    }
}
