using System;

namespace CSharpLearning
{
    internal class Task6
    {
        internal static void Execute()
        {
            Random random = new Random();
            int n = random.Next(4, 7);
            int[,] a = new int[n, n];
            Console.WriteLine($"Сгенерирована матрица {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(10, 100);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] r = new int[n];
            for (int i = 0; i < n; i++)
            {
                int mn = a[0, i];
                for (int j = 0; j < n; j++)
                {
                    if (mn > a[j, i])
                    {
                        mn = a[j, i];
                    }
                }
                r[i] = mn;
            }
            Console.WriteLine($"Минимумы каждого столбца:\n{String.Join(" ", r)}");
        }
    }
}
