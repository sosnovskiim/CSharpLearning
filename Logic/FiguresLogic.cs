using System.Collections;
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

        public IEnumerable GetAllFigures() => figuresRepository.GetAllFigures();

        public void SaveAllFigures() => figuresRepository.SaveAllFigures();
    }
}
