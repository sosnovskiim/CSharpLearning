using System;

namespace CSharpLearning
{
    internal class Task1
    {
        internal static void Execute()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Чётное" : "Нечётное");
        }
    }
}
