using System;

namespace CSharpLearning
{
    /*
     * Вывести на экран квадраты всех чётных чисел из диапозона от a до b (a <= b).
     * Примечание - необходимо использовать один из операторов цикла и обосновать свой выбор.
     */
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
