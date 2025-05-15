using Entities;
using Logic;
using Utils;

namespace WinFormsApp
{
    public partial class FiguresForm : Form
    {
        private IFiguresLogic figuresLogic = DependencyResolver.FiguresLogic;

        private bool isFiguresSorted = false;
        private bool isCirclesSorted = false;
        private bool isRectanglesSorted = false;
        private bool isTrianglesSorted = false;

        public FiguresForm()
        {
            InitializeComponent();
        }

        private void FiguresForm_Load(object sender, EventArgs e)
        {
            FillDataGridViewFigures();
            FillDataGridViewCircles();
            FillDataGridViewRectangles();
            FillDataGridViewTriangles();
        }

        private void FillDataGridViewFigures()
        {
            DataGridViewFigures.Rows.Clear();

            List<Figure> figures = figuresLogic.GetAllFigures();
            if (isFiguresSorted) figures.Sort();

            foreach (Figure figure in figures)
            {
                DataGridViewFigures.Rows.Add(
                    false, figure.Id, figure.Area, figure.Perimeter
                );
            }
        }

        private void FillDataGridViewCircles()
        {
            DataGridViewCircles.Rows.Clear();

            List<Circle> circles = figuresLogic.GetAllCircles();
            if (isCirclesSorted) circles.Sort();

            foreach (Circle circle in circles)
            {
                DataGridViewCircles.Rows.Add(
                    false, circle.Id, circle.Area, circle.Perimeter, circle.R
                );
            }
        }

        private void FillDataGridViewRectangles()
        {
            DataGridViewRectangles.Rows.Clear();

            List<Entities.Rectangle> rectangles = figuresLogic.GetAllRectangles();
            if (isRectanglesSorted) rectangles.Sort();

            foreach (Entities.Rectangle rectangle in rectangles)
            {
                DataGridViewRectangles.Rows.Add(
                    false, rectangle.Id, rectangle.Area, rectangle.Perimeter,
                    rectangle.A, rectangle.B
                );
            }
        }

        private void FillDataGridViewTriangles()
        {
            DataGridViewTriangles.Rows.Clear();

            List<Triangle> triangles = figuresLogic.GetAllTriangles();
            if (isTrianglesSorted) triangles.Sort();

            foreach (Triangle triangle in triangles)
            {
                DataGridViewTriangles.Rows.Add(
                    false, triangle.Id, triangle.Area, triangle.Perimeter,
                    triangle.A, triangle.B, triangle.C
                );
            }
        }

        private void ButtonAddCircle_Click(object sender, EventArgs e)
        {
            int r = (int)NumericCircleRadius.Value;

            if (r != 0)
            {
                figuresLogic.AddCircle(r);
                NumericCircleRadius.Value = 0;
                FillDataGridViewCircles();
            }
            else MessageBox.Show("¬ведите радиус круга.");
        }

        private void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            int a = (int)NumericRectangleWidth.Value;
            int b = (int)NumericRectangleHeight.Value;

            if (a != 0 && b != 0)
            {
                figuresLogic.AddRectangle(a, b);

                NumericRectangleWidth.Value = 0;
                NumericRectangleHeight.Value = 0;

                FillDataGridViewRectangles();
            }
            else MessageBox.Show("¬ведите стороны пр€моугольника.");
        }

        private void ButtonAddTriangle_Click(object sender, EventArgs e)
        {
            int a = (int)NumericTriangleSideA.Value;
            int b = (int)NumericTriangleSideB.Value;
            int c = (int)NumericTriangleSideC.Value;

            if (a != 0 && b != 0 && c != 0)
            {
                figuresLogic.AddTriangle(a, b, c);

                NumericTriangleSideA.Value = 0;
                NumericTriangleSideB.Value = 0;
                NumericTriangleSideC.Value = 0;

                FillDataGridViewTriangles();
            }
            else MessageBox.Show("¬ведите стороны треугольника.");
        }

        private void ButtonDeleteFigures_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewFigures.Rows)
            {
                if (Equals(row.Cells[0].Value, true))
                {
                    figuresLogic.RemoveFigureById((int)row.Cells[1].Value);
                }
            }

            FillDataGridViewFigures();
        }

        private void ButtonDeleteCircles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewCircles.Rows)
            {
                if (Equals(row.Cells[0].Value, true))
                {
                    figuresLogic.RemoveFigureById((int)row.Cells[1].Value);
                }
            }

            FillDataGridViewCircles();
        }

        private void ButtonDeleteRectangles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewRectangles.Rows)
            {
                if (Equals(row.Cells[0].Value, true))
                {
                    figuresLogic.RemoveFigureById((int)row.Cells[1].Value);
                }
            }

            FillDataGridViewRectangles();
        }

        private void ButtonDeleteTriangles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewTriangles.Rows)
            {
                if (Equals(row.Cells[0].Value, true))
                {
                    figuresLogic.RemoveFigureById((int)row.Cells[1].Value);
                }
            }

            FillDataGridViewTriangles();
        }

        private void ButtonSortFigures_Click(object sender, EventArgs e)
        {
            isFiguresSorted = !isFiguresSorted;
            FillDataGridViewFigures();
        }

        private void ButtonSortCircles_Click(object sender, EventArgs e)
        {
            isCirclesSorted = !isCirclesSorted;
            FillDataGridViewCircles();
        }

        private void ButtonSortRectangles_Click(object sender, EventArgs e)
        {
            isRectanglesSorted = !isRectanglesSorted;
            FillDataGridViewRectangles();
        }

        private void ButtonSortTriangles_Click(object sender, EventArgs e)
        {
            isTrianglesSorted = !isTrianglesSorted;
            FillDataGridViewTriangles();
        }

        private void FiguresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            figuresLogic.SaveAllFigures();
        }

        private void TabControlFigures_Selecting(object sender, TabControlCancelEventArgs e)
        {
            FillDataGridViewFigures();
            FillDataGridViewCircles();
            FillDataGridViewRectangles();
            FillDataGridViewTriangles();
        }
    }
}
