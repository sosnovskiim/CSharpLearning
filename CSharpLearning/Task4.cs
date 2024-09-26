using System;

namespace CSharpLearning
{
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
