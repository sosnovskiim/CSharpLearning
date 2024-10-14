using System;

namespace CSharpLearning
{
    /*
     * Дан ступенчатый массив размером n x m, элементы которого целые числа.
     * Удалить все столбцы, в которых первый элемент больше последнего.
     */
    internal class Task7
    {
        internal static void Execute()
        {
            Console.WriteLine($"Сгенерирован ступенчатый массив:");
            int[][] a;
            int m = GenerateArray(out a);

            bool[] isColumnsToRemove;
            SelectColumnsToRemove(out isColumnsToRemove, a, m);

            RemoveColumns(a, m, isColumnsToRemove);

            Console.WriteLine("Изменённый массив:");
            PrintArray(a);
        }

        private static int GenerateArray(out int[][] a)
        {
            Random random = new Random();
            int n = random.Next(4, 7);
            a = new int[n][];
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[random.Next(4, 10)];
                if (m < a[i].Length)
                {
                    m = a[i].Length;
                }
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = random.Next(10, 100);
                    Console.Write("{0} ", a[i][j]);
                }
                Console.WriteLine();
            }
            return m;
        }

        private static void SelectColumnsToRemove(out bool[] isColumnsToRemove, int[][] a, int m)
        {
            isColumnsToRemove = new bool[m];
            for (int i = 0; i < m; i++)
            {
                int k = 0; int fst = 0; int lst = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (i < a[j].Length)
                    {
                        if (k == 0)
                        {
                            fst = a[j][i];
                        }
                        lst = a[j][i];
                        k++;
                    }
                }
                if (fst > lst)
                {
                    isColumnsToRemove[i] = true;
                }
            }
        }

        private static void RemoveColumns(int[][] a, int m, bool[] isColumnsToRemove)
        {
            int l = 0;
            for (int i = 0; i < m; i++)
            {
                if (isColumnsToRemove[i])
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        for (int k = l; k < a[j].Length - 1; k++)
                        {
                            a[j][k] = a[j][k + 1];
                        }
                        if (l <= a[j].Length - 1 && a[j].Length > 0)
                        {
                            Array.Resize(ref a[j], a[j].Length - 1);
                        }
                    }
                }
                else
                {
                    l++;
                }
            }
        }

        private static void PrintArray(int[][] a)
        {
            foreach (int[] row in a)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
