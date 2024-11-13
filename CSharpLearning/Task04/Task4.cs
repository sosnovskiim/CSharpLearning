using System;

namespace CSharpLearning.Task4
{
    /*
     * Разработать рекурсивный метод, возвращающий значение для суммы от 1 до n.
     * С помощью разработанного метода для заданных натуральных чисел m и k
     * вычислить сумму сумм от 1 до m и от 1 до 2k.
     */
    internal class Task4
    {
        internal static void Execute()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма чисел от 1 до n равна {Sum(n)}");
            Console.WriteLine();

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма сумм чисел от 1 до m и от 1 до 2k равна {Sum(m) + Sum(2 * k)}");
        }

        private static int Sum(int n)
        {
            return n + ((n > 1) ? Sum(n - 1) : 0);
        }
    }
}
