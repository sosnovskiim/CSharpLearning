using System;

namespace CSharpLearning
{
    /*
     * Написать программу, определяющую чётность заданного целого числа.
     * Примечание - необходимо использовать тернарную операцию.
     */
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
