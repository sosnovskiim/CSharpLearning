﻿using System;

namespace CSharpLearning
{
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
            if (n >= m)
            {
                if (n % m == 0)
                {
                    Console.Write(m + " ");
                }
                PrintDivisors(n, m + 1);
            }
        }
    }
}