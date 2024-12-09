using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpLearning.Task16
{
    internal class Task16
    {
        /*
         * Создать абстрактный класс Figure с методами вычисления площади и периметра,
         * а также его производные классы: Rectangle, Circle, Triangle.
         * Задать список фигур и вывести полную информацию о них на экран.
         * Реализовать сортировку фигур по площадям.
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
                            figures.Add(new Circle(int.Parse(values[0])));
                        }
                        else if (values.Length == 2)
                        {
                            figures.Add(new Rectangle(int.Parse(values[0]), int.Parse(values[1])));
                        }
                        else if (values.Length == 3)
                        {
                            figures.Add(new Triangle(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2])));
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество аргументов.");
                        }
                    }
                    figures.Sort();
                    foreach (Figure f in figures) fileOut.WriteLine(f);
                }
            }
        }
    }
}
