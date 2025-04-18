using System.Collections;
using Entities;

namespace Data
{
    public interface IFiguresRepository
    {
        void AddFigure(Figure figure);
        void RemoveFigureById(int id);
        Figure GetFigureById(int id);
        IEnumerable GetAllFigures();
        void SaveAllFigures();
    }
}
