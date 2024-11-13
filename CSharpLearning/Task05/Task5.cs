using System;

namespace CSharpLearning.Task5
{
    /*
     * Разработать рекурсивный метод, не возвращающий значений
     * для вывода на экран всех делителей заданного натурального числа n.
     */
    internal class Task5
    {
        internal static void Execute()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Делители числа n: ");
            PrintDivisors(n);
            Console.WriteLine();
        }

        private static void PrintDivisors(int n, int m = 1)
        {
            if (n >= m * m)
            {
                if (n % m == 0)
                {
                    Console.Write(m + " ");
                    if (m * m != n)
                    {
                        Console.Write(n / m + " ");
                    }
                }
                PrintDivisors(n, m + 1);
            }
        }
    }
}
