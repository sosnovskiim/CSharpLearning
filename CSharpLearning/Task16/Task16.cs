using System;
using System.Collections.Generic;
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
                    List<Figure> figures = new List<Figure>();
                    string line;
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        string[] values = line.Split();
                        if (values.Length == 1)
                        {
                            figures.Add(new Circle(double.Parse(values[0])));
                        }
                        else if (values.Length == 2)
                        {
                            figures.Add(new Rectangle(double.Parse(values[0]), double.Parse(values[1])));
                        }
                        else if (values.Length == 3)
                        {
                            figures.Add(new Triangle(double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2])));
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество параметров.");
                        }
                    }
                    figures.Sort();
                    foreach (Figure f in figures) fileOut.WriteLine(f);
                }
            }
        }
    }
}
