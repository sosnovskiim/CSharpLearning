using System.Collections.Generic;
using Data;
using Entities;

namespace Logic
{
    public class FiguresLogic : IFiguresLogic
    {
        private IFiguresRepository figuresRepository;

        public FiguresLogic(IFiguresRepository figuresRepository)
        {
            this.figuresRepository = figuresRepository;
        }

        public void AddCircle(int r)
        {
            figuresRepository.AddFigure(new Circle(r));
        }

        public void AddRectangle(int a, int b)
        {
            figuresRepository.AddFigure(new Rectangle(a, b));
        }

        public void AddTriangle(int a, int b, int c)
        {
            figuresRepository.AddFigure(new Triangle(a, b, c));
        }

        public void RemoveFigureById(int id) => figuresRepository.RemoveFigureById(id);

        public Figure GetFigureById(int id) => figuresRepository.GetFigureById(id);

        public List<Figure> GetAllFigures() => figuresRepository.GetAllFigures();

        public List<Circle> GetAllCircles()
        {
            List<Circle> circles = new List<Circle>();
            foreach (Figure figure in figuresRepository.GetAllFigures())
            {
                if (figure is Circle) circles.Add((Circle)figure);
            }
            return circles;
        }

        public List<Rectangle> GetAllRectangles()
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            foreach (Figure figure in figuresRepository.GetAllFigures())
            {
                if (figure is Rectangle) rectangles.Add((Rectangle)figure);
            }
            return rectangles;
        }

        public List<Triangle> GetAllTriangles()
        {
            List<Triangle> triangles = new List<Triangle>();
            foreach (Figure figure in figuresRepository.GetAllFigures())
            {
                if (figure is Triangle) triangles.Add((Triangle)figure);
            }
            return triangles;
        }

        public void SaveAllFigures() => figuresRepository.SaveAllFigures();
    }
}
