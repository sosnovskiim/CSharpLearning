using System;

namespace CSharpLearning
{
    /*
     * Разработать метод, возвращающий наибольший общий делитель для заданных натуральных чисел n и m.
     * 
     * С помощью разработанного метода:
     * - найти наибольший общий делитель для двух натуральных чисел;
     * - сократить дробь вида a/b;
     * - найти наименьшее общее кратное для двух натуральных чисел;
     * - найти наибольший общий делитель для нескольких натуральных чисел.
     */
    internal class Task3
    {
        internal static void Execute()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int gcd = GCD(n, m);
            Console.WriteLine($"Наибольшой общий делитель равен {gcd}");
            Console.WriteLine($"Дробь {n}/{m} сокращается до {n / gcd}/{m / gcd}");
            Console.WriteLine($"Наименьшее общее кратное равно {n * m / gcd}");
            Console.WriteLine();

            Console.Write("Количество чисел: ");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < k; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            gcd = 0;
            for (int i = 0; i < k - 1; i++)
            {
                gcd = GCD(a[i], gcd);
            }
            Console.WriteLine($"Наибольший общий делитель для {k} чисел: {gcd}");
        }

        private static int GCD(int n, int m)
        {
            while (n > 0 && m > 0)
            {
                if (n > m)
                {
                    n = n % m;
                }
                else
                {
                    m = m % n;
                }
            }
            return n + m;
        }
    }
}
