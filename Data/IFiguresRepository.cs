using System.Collections.Generic;
using Entities;

namespace Data
{
    public interface IFiguresRepository
    {
        void AddFigure(Figure figure);
        void RemoveFigureById(int id);
        Figure GetFigureById(int id);
        List<Figure> GetAllFigures();
        void SaveAllFigures();
    }
}
