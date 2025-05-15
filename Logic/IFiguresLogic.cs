using System.Collections.Generic;
using Entities;

namespace Logic
{
    public interface IFiguresLogic
    {
        void AddCircle(int r);
        void AddRectangle(int a, int b);
        void AddTriangle(int a, int b, int c);
        void RemoveFigureById(int id);
        Figure GetFigureById(int id);
        List<Figure> GetAllFigures();
        List<Circle> GetAllCircles();
        List<Rectangle> GetAllRectangles();
        List<Triangle> GetAllTriangles();
        void SaveAllFigures();
    }
}
