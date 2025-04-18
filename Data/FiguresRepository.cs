﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Entities;

namespace Data
{
    public class FiguresRepository : IFiguresRepository
    {
        const string filePath = "../../../Task19/figures.dat";
        BinaryFormatter formatter = new BinaryFormatter();
        Dictionary<int, Figure> figures;
        int figureId;

        public FiguresRepository()
        {
            using (FileStream streamIn = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if (streamIn.Length > 0)
                {
                    figures = (Dictionary<int, Figure>)formatter.Deserialize(streamIn);
                    ICollection keys = figures.Keys;
                    foreach (int key in keys) figureId = key;
                }
                else
                {
                    figures = new Dictionary<int, Figure>();
                    figureId = 0;
                }
            }
        }

        public void AddFigure(Figure figure)
        {
            figureId++;
            figure.id = figureId;
            figures.Add(figureId, figure);
        }

        public void RemoveFigureById(int id) => figures.Remove(id);

        public Figure GetFigureById(int id) => figures[id];

        public IEnumerable GetAllFigures() => figures.Values;

        public void SaveAllFigures()
        {
            using (FileStream streamOut = new FileStream(filePath, FileMode.Open))
            {
                formatter.Serialize(streamOut, figures);
            }
        }
    }
}
