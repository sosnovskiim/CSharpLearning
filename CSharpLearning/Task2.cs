using System;

namespace CSharpLearning
{
    internal class Task2
    {
        internal static void Execute()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a + a % 2; i <= b; i += 2)
            {
                Console.WriteLine(i * i);
            }
        }
    }
}
