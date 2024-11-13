using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpLearning.Task13
{
    /*
     * Дана последовательность целых чисел.
     * Вывести все отрицательные числа, отсортировав их в порядке убывания.
     */
    internal class Task13
    {
        internal static void Execute()
        {
            List<int> numbers = new List<int>();
            using (StreamReader fileIn = new StreamReader("../../../Task13/input.txt"))
            {
                string line;
                while ((line = fileIn.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                }
            }
            using (StreamWriter fileOut = new StreamWriter("../../../Task13/output_queries.txt"))
            {
                var query = from x in numbers where x < 0 orderby -x select x;
                foreach (var x in query)
                {
                    fileOut.WriteLine(x);
                }
            }
            using (StreamWriter fileOut = new StreamWriter("../../../Task13/output_methods.txt"))
            {
                var query = numbers.Where(x => x < 0).OrderByDescending(x => x);
                foreach (var x in query)
                {
                    fileOut.WriteLine(x);
                }
            }
        }
    }
}
