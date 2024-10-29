using System;
using System.Diagnostics;

namespace CSharpLearning
{
    /*
     * Сравнить итерационный алгоритм и стандартный метод возведения в степень.
     */
    internal class Task10
    {
        internal static void Execute()
        {
            double x = 12, y = 240;
            long s = 0;
            for (int i = 0; i < 1000; i++)
            {
                s += TimeIterativePow(x, y);
            }
            Console.WriteLine(s / 1000.0);
            s = 0;
            for (int i = 0; i < 1000; i++)
            {
                s += TimeStandardPow(x, y);
            }
            Console.WriteLine(s / 1000.0);
        }

        private static long TimeIterativePow(double x, double y)
        {
            double p = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < y; i++) p *= x;
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        private static long TimeStandardPow(double x, double y)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Math.Pow(x, y);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}
