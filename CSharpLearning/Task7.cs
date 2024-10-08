using System;

namespace CSharpLearning
{
    internal class Task7
    {
        internal static void Execute()
        {
            Random random = new Random();
            int n = random.Next(4, 7);
            int[][] a = new int[n][];
            Console.WriteLine($"Сгенерирована матрица {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    a[i][j] = random.Next(10, 100);
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
