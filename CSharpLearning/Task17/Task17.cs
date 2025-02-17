using System;
using System.IO;

namespace CSharpLearning.Task17
{
    internal class Task17
    {
        /*
         * Реализовать типизированный однонаправленный список с тремя точками доступа
         * (head, tail, temp) для хранения и обработки целых чисел.
         * Перед каждым элементом со значением х удалить один элемент.
         */
        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task17/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task17/output.txt"))
                {
                    char[] separators = { ' ', '\r', '\t', '\n', ',', '.', ';', ':', '!', '?', '—', '–', '\'', '\"' };
                    string[] data = fileIn.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    IntList intList = new IntList();
                    foreach (string item in data) intList.AddEnd(int.Parse(item));
                    fileOut.WriteLine(intList);

                    Console.Write("x = ");
                    int x = int.Parse(Console.ReadLine());

                    intList.DeleteAllPrevious(x);
                    fileOut.WriteLine(intList);
                }
            }
        }
    }
}
