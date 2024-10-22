using System.IO;

namespace CSharpLearning
{
    /*
     * Дан файл f, компонентами которого являются целые числа.
     * Переписать все отрицательные числа в файл g, положительные – в файл h.
     */
    internal class Task9
    {
        internal static void Execute()
        {
            using (StreamReader f = new StreamReader("../../../Task9/f.txt"))
            {
                using (StreamWriter g = new StreamWriter("../../../Task9/g.txt"))
                {
                    using (StreamWriter h = new StreamWriter("../../../Task9/h.txt"))
                    {
                        char[] separators = { ' ', '\r', '\t', '\n' };
                        string[] s = f.ReadToEnd().Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
                        foreach (string n in s)
                        {
                            if (int.Parse(n) < 0)
                            {
                                g.WriteLine(n);
                            }
                            else
                            {
                                h.WriteLine(n);
                            }
                        }
                    }
                }
            }
        }
    }
}
