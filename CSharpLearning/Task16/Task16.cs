using System.IO;

namespace CSharpLearning.Task16
{
    internal class Task16
    {
        /*
         * Создать абстрактный класс Figure с методами вычисления площади и периметра,
         * а также методом, выводящим информацию о фигуре на экран.
         * Создать производные классы: Rectangle, Circle, Triangle.
         * Создать массив из N фигур и вывести полную информацию о фигурах на экран. 
         */
        internal static void Execute()
        {
            using (StreamReader fileIn = new StreamReader("../../../Task16/input.txt"))
            {
                using (StreamWriter fileOut = new StreamWriter("../../../Task16/output.txt"))
                {
                    int n = int.Parse(fileIn.ReadLine());
                    Figure[] figures = new Figure[n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] values = fileIn.ReadLine().Split();
                        if (values.Length == 2)
                        {
                            figures[i] = new Rectangle(double.Parse(values[0]), double.Parse(values[1]));
                        }
                    }
                    foreach (Figure f in figures) fileOut.WriteLine(f);
                }
            }
        }
    }
}
