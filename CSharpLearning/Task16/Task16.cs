using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            const string filePath = "../../../Task16/figures.dat";
            List<Figure> figures;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream streamIn = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (streamIn.Length > 0)
                {
                    figures = (List<Figure>)formatter.Deserialize(streamIn);
                    foreach (Figure figure in figures) Console.WriteLine(figure);
                }
                else
                {
                    figures = new List<Figure>();
                    Console.WriteLine("Список фигур пуст.");
                }
            }
            Console.WriteLine();

            if (figures.Count == 0)
            {
                figures.Add(new Circle(3));
                figures.Add(new Rectangle(1, 2));
                figures.Add(new Rectangle(3, 4));
                figures.Add(new Triangle(6, 2, 7));
                figures.Add(new Triangle(3, 4, 2));
            }
            else
            {
                figures.Add(new Circle(1));
                figures.Add(new Triangle(2, 3, 4));
                figures.Add(new Rectangle(9, 5));
            }

            figures.Sort();
            foreach (Figure figure in figures) Console.WriteLine(figure);
            Console.WriteLine();

            using (FileStream streamOut = new FileStream(filePath, FileMode.Open))
            {
                formatter.Serialize(streamOut, figures);
            }
            Console.WriteLine("Список фигур сериализован.");
        }
    }
}
