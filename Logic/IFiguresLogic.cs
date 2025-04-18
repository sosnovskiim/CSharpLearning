﻿using System.Collections;
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
        IEnumerable GetAllFigures();
        void SaveAllFigures();
    }
}
