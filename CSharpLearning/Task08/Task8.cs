using System;

namespace CSharpLearning.Task8
{
    /*
     * Дана строка, в которой содержится осмысленное текстовое сообщение.
     * Слова сообщения разделяются пробелами и знаками препинания.
     * Вывести только те слова сообщения, которые содержат не более чем n букв.
     */
    internal class Task8
    {
        internal static void Execute()
        {
            Console.WriteLine("Введите текстовое сообщение:");
            string s = Console.ReadLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            char[] separators = { ' ', '\r', '\t', '\n', ',', '.', ';', ':', '!', '?', '—', '–', '\'', '\"' };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Слова, содержащие не более n букв:");
            foreach (string word in words)
            {
                if (word.Length <= n)
                {
                    Console.Write("{0} ", word);
                }
            }
            Console.WriteLine();
        }
    }
}
