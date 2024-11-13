using System;

namespace CSharpLearning.Task6
{
    /*
     * Дан массив размером n x n, элементы которого целые числа.
     * Найти минимальный элемент в каждом столбце и записать данные в новый массив.
     * Примечание - для хранения массива размером n x n
     * использовать двумерный или ступенчатый массив и обосновать свой выбор.
     */
    internal class Task6
    {
        internal static void Execute()
        {
            Random random = new Random();
            int n = random.Next(4, 7);
            int[,] a = new int[n, n];
            Console.WriteLine($"Сгенерирован двумерный массив {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(10, 100);
                    Console.Write("{0} ", a[i, j]);
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
