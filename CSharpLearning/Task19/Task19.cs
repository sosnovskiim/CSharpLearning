using System;
using Entities;
using Logic;
using Utils;

namespace CSharpLearning.Task19
{
    /*
     * Трёхуровневая архитектура, позволяющая добавлять, удалять, сортировать,
     * сохранять и загружать из файла список фигур: кругов, прямоугольников, треугольников.
     */
    internal class Task19
    {
        internal static void Execute()
        {
            IFiguresLogic figuresLogic = DependencyResolver.FiguresLogic;
            PrintFigures();

            figuresLogic.AddCircle(3);
            figuresLogic.AddRectangle(1, 2);
            figuresLogic.AddTriangle(6, 2, 7);
            figuresLogic.AddRectangle(3, 4);
            figuresLogic.AddTriangle(3, 4, 2);
            PrintFigures();

            figuresLogic.RemoveFigureById(4);
            figuresLogic.RemoveFigureById(5);
            PrintFigures();

            figuresLogic.SaveAllFigures();
        }

        private static void PrintFigures()
        {
            bool isEmpty = true;
            foreach (Figure figure in DependencyResolver.FiguresLogic.GetAllFigures())
            {
                Console.WriteLine(figure);
                if (isEmpty) isEmpty = false;
            }
            if (isEmpty) Console.WriteLine("Список фигур пуст.");
            Console.WriteLine();
        }
    }
}
