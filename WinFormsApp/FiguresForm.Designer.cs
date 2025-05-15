namespace WinFormsApp
{
    partial class FiguresForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControlFigures = new TabControl();
            TabPageFigures = new TabPage();
            DataGridViewFigures = new DataGridView();
            ColumnFigureCheckBox = new DataGridViewCheckBoxColumn();
            ColumnFigureId = new DataGridViewTextBoxColumn();
            ColumnFigureArea = new DataGridViewTextBoxColumn();
            ColumnFigurePerimeter = new DataGridViewTextBoxColumn();
            ButtonSortFigures = new Button();
            ButtonDeleteFigures = new Button();
            TabPageCircles = new TabPage();
            NumericCircleRadius = new NumericUpDown();
            DataGridViewCircles = new DataGridView();
            ColumnCircleCheckBox = new DataGridViewCheckBoxColumn();
            ColumnCircleId = new DataGridViewTextBoxColumn();
            ColumnCircleArea = new DataGridViewTextBoxColumn();
            ColumnCirclePerimeter = new DataGridViewTextBoxColumn();
            ColumnCircleRadius = new DataGridViewTextBoxColumn();
            ButtonSortCircles = new Button();
            ButtonDeleteCircles = new Button();
            ButtonAddCircle = new Button();
            TabPageRectangles = new TabPage();
            NumericRectangleHeight = new NumericUpDown();
            NumericRectangleWidth = new NumericUpDown();
            DataGridViewRectangles = new DataGridView();
            ColumnRectangleCheckBox = new DataGridViewCheckBoxColumn();
            ColumnRectangleId = new DataGridViewTextBoxColumn();
            ColumnRectangleArea = new DataGridViewTextBoxColumn();
            ColumnRectanglePerimeter = new DataGridViewTextBoxColumn();
            ColumnRectangleWidth = new DataGridViewTextBoxColumn();
            ColumnRectangleHeight = new DataGridViewTextBoxColumn();
            ButtonDeleteRectangles = new Button();
            ButtonSortRectangles = new Button();
            ButtonAddRectangle = new Button();
            TabPageTriangles = new TabPage();
            NumericTriangleSideC = new NumericUpDown();
            NumericTriangleSideB = new NumericUpDown();
            NumericTriangleSideA = new NumericUpDown();
            ButtonDeleteTriangles = new Button();
            ButtonSortTriangles = new Button();
            ButtonAddTriangle = new Button();
            DataGridViewTriangles = new DataGridView();
            ColumnTriangleCheckBox = new DataGridViewCheckBoxColumn();
            ColumnTriangleId = new DataGridViewTextBoxColumn();
            ColumnTriangleArea = new DataGridViewTextBoxColumn();
            ColumnTrianglePerimeter = new DataGridViewTextBoxColumn();
            ColumnTriangleSideA = new DataGridViewTextBoxColumn();
            ColumnTriangleSideB = new DataGridViewTextBoxColumn();
            ColumnTriangleSideC = new DataGridViewTextBoxColumn();
            TabControlFigures.SuspendLayout();
            TabPageFigures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFigures).BeginInit();
            TabPageCircles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCircleRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCircles).BeginInit();
            TabPageRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRectangleHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericRectangleWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRectangles).BeginInit();
            TabPageTriangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTriangles).BeginInit();
            SuspendLayout();
            // 
            // TabControlFigures
            // 
            TabControlFigures.Controls.Add(TabPageFigures);
            TabControlFigures.Controls.Add(TabPageCircles);
            TabControlFigures.Controls.Add(TabPageRectangles);
            TabControlFigures.Controls.Add(TabPageTriangles);
            TabControlFigures.Location = new Point(12, 12);
            TabControlFigures.Name = "TabControlFigures";
            TabControlFigures.SelectedIndex = 0;
            TabControlFigures.Size = new Size(776, 426);
            TabControlFigures.TabIndex = 0;
            // 
            // TabPageFigures
            // 
            TabPageFigures.Controls.Add(DataGridViewFigures);
            TabPageFigures.Controls.Add(ButtonSortFigures);
            TabPageFigures.Controls.Add(ButtonDeleteFigures);
            TabPageFigures.Location = new Point(4, 29);
            TabPageFigures.Name = "TabPageFigures";
            TabPageFigures.Padding = new Padding(3);
            TabPageFigures.Size = new Size(768, 393);
            TabPageFigures.TabIndex = 0;
            TabPageFigures.Text = "Figures";
            TabPageFigures.UseVisualStyleBackColor = true;
            // 
            // DataGridViewFigures
            // 
            DataGridViewFigures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFigures.Columns.AddRange(new DataGridViewColumn[] { ColumnFigureCheckBox, ColumnFigureId, ColumnFigureArea, ColumnFigurePerimeter });
            DataGridViewFigures.Location = new Point(6, 39);
            DataGridViewFigures.Name = "DataGridViewFigures";
            DataGridViewFigures.RowHeadersWidth = 51;
            DataGridViewFigures.Size = new Size(756, 348);
            DataGridViewFigures.TabIndex = 3;
            // 
            // ColumnFigureCheckBox
            // 
            ColumnFigureCheckBox.HeaderText = "";
            ColumnFigureCheckBox.MinimumWidth = 6;
            ColumnFigureCheckBox.Name = "ColumnFigureCheckBox";
            ColumnFigureCheckBox.Width = 65;
            // 
            // ColumnFigureId
            // 
            ColumnFigureId.HeaderText = "Номер";
            ColumnFigureId.MinimumWidth = 6;
            ColumnFigureId.Name = "ColumnFigureId";
            ColumnFigureId.ReadOnly = true;
            ColumnFigureId.Width = 65;
            // 
            // ColumnFigureArea
            // 
            ColumnFigureArea.HeaderText = "Площадь";
            ColumnFigureArea.MinimumWidth = 6;
            ColumnFigureArea.Name = "ColumnFigureArea";
            ColumnFigureArea.ReadOnly = true;
            ColumnFigureArea.Width = 110;
            // 
            // ColumnFigurePerimeter
            // 
            ColumnFigurePerimeter.HeaderText = "Периметр";
            ColumnFigurePerimeter.MinimumWidth = 6;
            ColumnFigurePerimeter.Name = "ColumnFigurePerimeter";
            ColumnFigurePerimeter.ReadOnly = true;
            ColumnFigurePerimeter.Width = 110;
            // 
            // ButtonSortFigures
            // 
            ButtonSortFigures.Location = new Point(655, 6);
            ButtonSortFigures.Name = "ButtonSortFigures";
            ButtonSortFigures.Size = new Size(107, 29);
            ButtonSortFigures.TabIndex = 2;
            ButtonSortFigures.Text = "Сортировать";
            ButtonSortFigures.UseVisualStyleBackColor = true;
            ButtonSortFigures.Click += ButtonSortFigures_Click;
            // 
            // ButtonDeleteFigures
            // 
            ButtonDeleteFigures.Location = new Point(524, 6);
            ButtonDeleteFigures.Name = "ButtonDeleteFigures";
            ButtonDeleteFigures.Size = new Size(125, 29);
            ButtonDeleteFigures.TabIndex = 1;
            ButtonDeleteFigures.Text = "Удалить помеч.";
            ButtonDeleteFigures.UseVisualStyleBackColor = true;
            ButtonDeleteFigures.Click += ButtonDeleteFigures_Click;
            // 
            // TabPageCircles
            // 
            TabPageCircles.Controls.Add(NumericCircleRadius);
            TabPageCircles.Controls.Add(DataGridViewCircles);
            TabPageCircles.Controls.Add(ButtonSortCircles);
            TabPageCircles.Controls.Add(ButtonDeleteCircles);
            TabPageCircles.Controls.Add(ButtonAddCircle);
            TabPageCircles.Location = new Point(4, 29);
            TabPageCircles.Name = "TabPageCircles";
            TabPageCircles.Padding = new Padding(3);
            TabPageCircles.Size = new Size(768, 393);
            TabPageCircles.TabIndex = 1;
            TabPageCircles.Text = "Circles";
            TabPageCircles.UseVisualStyleBackColor = true;
            // 
            // NumericCircleRadius
            // 
            NumericCircleRadius.Location = new Point(6, 6);
            NumericCircleRadius.Name = "NumericCircleRadius";
            NumericCircleRadius.Size = new Size(80, 27);
            NumericCircleRadius.TabIndex = 6;
            // 
            // DataGridViewCircles
            // 
            DataGridViewCircles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCircles.Columns.AddRange(new DataGridViewColumn[] { ColumnCircleCheckBox, ColumnCircleId, ColumnCircleArea, ColumnCirclePerimeter, ColumnCircleRadius });
            DataGridViewCircles.Location = new Point(6, 39);
            DataGridViewCircles.Name = "DataGridViewCircles";
            DataGridViewCircles.RowHeadersWidth = 51;
            DataGridViewCircles.Size = new Size(756, 348);
            DataGridViewCircles.TabIndex = 5;
            // 
            // ColumnCircleCheckBox
            // 
            ColumnCircleCheckBox.HeaderText = "";
            ColumnCircleCheckBox.MinimumWidth = 6;
            ColumnCircleCheckBox.Name = "ColumnCircleCheckBox";
            ColumnCircleCheckBox.Width = 65;
            // 
            // ColumnCircleId
            // 
            ColumnCircleId.HeaderText = "Номер";
            ColumnCircleId.MinimumWidth = 6;
            ColumnCircleId.Name = "ColumnCircleId";
            ColumnCircleId.ReadOnly = true;
            ColumnCircleId.Width = 65;
            // 
            // ColumnCircleArea
            // 
            ColumnCircleArea.HeaderText = "Площадь";
            ColumnCircleArea.MinimumWidth = 6;
            ColumnCircleArea.Name = "ColumnCircleArea";
            ColumnCircleArea.ReadOnly = true;
            ColumnCircleArea.Width = 110;
            // 
            // ColumnCirclePerimeter
            // 
            ColumnCirclePerimeter.HeaderText = "Периметр";
            ColumnCirclePerimeter.MinimumWidth = 6;
            ColumnCirclePerimeter.Name = "ColumnCirclePerimeter";
            ColumnCirclePerimeter.ReadOnly = true;
            ColumnCirclePerimeter.Width = 110;
            // 
            // ColumnCircleRadius
            // 
            ColumnCircleRadius.HeaderText = "Радиус";
            ColumnCircleRadius.MinimumWidth = 6;
            ColumnCircleRadius.Name = "ColumnCircleRadius";
            ColumnCircleRadius.ReadOnly = true;
            ColumnCircleRadius.Width = 110;
            // 
            // ButtonSortCircles
            // 
            ButtonSortCircles.Location = new Point(655, 6);
            ButtonSortCircles.Name = "ButtonSortCircles";
            ButtonSortCircles.Size = new Size(107, 29);
            ButtonSortCircles.TabIndex = 4;
            ButtonSortCircles.Text = "Сортировать";
            ButtonSortCircles.UseVisualStyleBackColor = true;
            ButtonSortCircles.Click += ButtonSortCircles_Click;
            // 
            // ButtonDeleteCircles
            // 
            ButtonDeleteCircles.Location = new Point(524, 6);
            ButtonDeleteCircles.Name = "ButtonDeleteCircles";
            ButtonDeleteCircles.Size = new Size(125, 29);
            ButtonDeleteCircles.TabIndex = 3;
            ButtonDeleteCircles.Text = "Удалить помеч.";
            ButtonDeleteCircles.UseVisualStyleBackColor = true;
            ButtonDeleteCircles.Click += ButtonDeleteCircles_Click;
            // 
            // ButtonAddCircle
            // 
            ButtonAddCircle.Location = new Point(92, 6);
            ButtonAddCircle.Name = "ButtonAddCircle";
            ButtonAddCircle.Size = new Size(84, 29);
            ButtonAddCircle.TabIndex = 1;
            ButtonAddCircle.Text = "Добавить";
            ButtonAddCircle.UseVisualStyleBackColor = true;
            ButtonAddCircle.Click += ButtonAddCircle_Click;
            // 
            // TabPageRectangles
            // 
            TabPageRectangles.Controls.Add(NumericRectangleHeight);
            TabPageRectangles.Controls.Add(NumericRectangleWidth);
            TabPageRectangles.Controls.Add(DataGridViewRectangles);
            TabPageRectangles.Controls.Add(ButtonDeleteRectangles);
            TabPageRectangles.Controls.Add(ButtonSortRectangles);
            TabPageRectangles.Controls.Add(ButtonAddRectangle);
            TabPageRectangles.Location = new Point(4, 29);
            TabPageRectangles.Name = "TabPageRectangles";
            TabPageRectangles.Size = new Size(768, 393);
            TabPageRectangles.TabIndex = 2;
            TabPageRectangles.Text = "Rectangles";
            TabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // NumericRectangleHeight
            // 
            NumericRectangleHeight.Location = new Point(92, 6);
            NumericRectangleHeight.Name = "NumericRectangleHeight";
            NumericRectangleHeight.Size = new Size(80, 27);
            NumericRectangleHeight.TabIndex = 9;
            // 
            // NumericRectangleWidth
            // 
            NumericRectangleWidth.Location = new Point(6, 6);
            NumericRectangleWidth.Name = "NumericRectangleWidth";
            NumericRectangleWidth.Size = new Size(80, 27);
            NumericRectangleWidth.TabIndex = 8;
            // 
            // DataGridViewRectangles
            // 
            DataGridViewRectangles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRectangles.Columns.AddRange(new DataGridViewColumn[] { ColumnRectangleCheckBox, ColumnRectangleId, ColumnRectangleArea, ColumnRectanglePerimeter, ColumnRectangleWidth, ColumnRectangleHeight });
            DataGridViewRectangles.Location = new Point(6, 39);
            DataGridViewRectangles.Name = "DataGridViewRectangles";
            DataGridViewRectangles.RowHeadersWidth = 51;
            DataGridViewRectangles.Size = new Size(756, 348);
            DataGridViewRectangles.TabIndex = 7;
            // 
            // ColumnRectangleCheckBox
            // 
            ColumnRectangleCheckBox.HeaderText = "";
            ColumnRectangleCheckBox.MinimumWidth = 6;
            ColumnRectangleCheckBox.Name = "ColumnRectangleCheckBox";
            ColumnRectangleCheckBox.Width = 65;
            // 
            // ColumnRectangleId
            // 
            ColumnRectangleId.HeaderText = "Номер";
            ColumnRectangleId.MinimumWidth = 6;
            ColumnRectangleId.Name = "ColumnRectangleId";
            ColumnRectangleId.ReadOnly = true;
            ColumnRectangleId.Width = 65;
            // 
            // ColumnRectangleArea
            // 
            ColumnRectangleArea.HeaderText = "Площадь";
            ColumnRectangleArea.MinimumWidth = 6;
            ColumnRectangleArea.Name = "ColumnRectangleArea";
            ColumnRectangleArea.ReadOnly = true;
            ColumnRectangleArea.Width = 110;
            // 
            // ColumnRectanglePerimeter
            // 
            ColumnRectanglePerimeter.HeaderText = "Периметр";
            ColumnRectanglePerimeter.MinimumWidth = 6;
            ColumnRectanglePerimeter.Name = "ColumnRectanglePerimeter";
            ColumnRectanglePerimeter.ReadOnly = true;
            ColumnRectanglePerimeter.Width = 110;
            // 
            // ColumnRectangleWidth
            // 
            ColumnRectangleWidth.HeaderText = "Ширина";
            ColumnRectangleWidth.MinimumWidth = 6;
            ColumnRectangleWidth.Name = "ColumnRectangleWidth";
            ColumnRectangleWidth.ReadOnly = true;
            ColumnRectangleWidth.Width = 110;
            // 
            // ColumnRectangleHeight
            // 
            ColumnRectangleHeight.HeaderText = "Высота";
            ColumnRectangleHeight.MinimumWidth = 6;
            ColumnRectangleHeight.Name = "ColumnRectangleHeight";
            ColumnRectangleHeight.ReadOnly = true;
            ColumnRectangleHeight.Width = 110;
            // 
            // ButtonDeleteRectangles
            // 
            ButtonDeleteRectangles.Location = new Point(524, 6);
            ButtonDeleteRectangles.Name = "ButtonDeleteRectangles";
            ButtonDeleteRectangles.Size = new Size(125, 29);
            ButtonDeleteRectangles.TabIndex = 5;
            ButtonDeleteRectangles.Text = "Удалить помеч.";
            ButtonDeleteRectangles.UseVisualStyleBackColor = true;
            ButtonDeleteRectangles.Click += ButtonDeleteRectangles_Click;
            // 
            // ButtonSortRectangles
            // 
            ButtonSortRectangles.Location = new Point(655, 6);
            ButtonSortRectangles.Name = "ButtonSortRectangles";
            ButtonSortRectangles.Size = new Size(107, 29);
            ButtonSortRectangles.TabIndex = 3;
            ButtonSortRectangles.Text = "Сортировать";
            ButtonSortRectangles.UseVisualStyleBackColor = true;
            ButtonSortRectangles.Click += ButtonSortRectangles_Click;
            // 
            // ButtonAddRectangle
            // 
            ButtonAddRectangle.Location = new Point(178, 6);
            ButtonAddRectangle.Name = "ButtonAddRectangle";
            ButtonAddRectangle.Size = new Size(84, 29);
            ButtonAddRectangle.TabIndex = 2;
            ButtonAddRectangle.Text = "Добавить";
            ButtonAddRectangle.UseVisualStyleBackColor = true;
            ButtonAddRectangle.Click += ButtonAddRectangle_Click;
            // 
            // TabPageTriangles
            // 
            TabPageTriangles.Controls.Add(NumericTriangleSideC);
            TabPageTriangles.Controls.Add(NumericTriangleSideB);
            TabPageTriangles.Controls.Add(NumericTriangleSideA);
            TabPageTriangles.Controls.Add(ButtonDeleteTriangles);
            TabPageTriangles.Controls.Add(ButtonSortTriangles);
            TabPageTriangles.Controls.Add(ButtonAddTriangle);
            TabPageTriangles.Controls.Add(DataGridViewTriangles);
            TabPageTriangles.Location = new Point(4, 29);
            TabPageTriangles.Name = "TabPageTriangles";
            TabPageTriangles.Size = new Size(768, 393);
            TabPageTriangles.TabIndex = 3;
            TabPageTriangles.Text = "Triangles";
            TabPageTriangles.UseVisualStyleBackColor = true;
            // 
            // NumericTriangleSideC
            // 
            NumericTriangleSideC.Location = new Point(178, 6);
            NumericTriangleSideC.Name = "NumericTriangleSideC";
            NumericTriangleSideC.Size = new Size(80, 27);
            NumericTriangleSideC.TabIndex = 10;
            // 
            // NumericTriangleSideB
            // 
            NumericTriangleSideB.Location = new Point(92, 6);
            NumericTriangleSideB.Name = "NumericTriangleSideB";
            NumericTriangleSideB.Size = new Size(80, 27);
            NumericTriangleSideB.TabIndex = 9;
            // 
            // NumericTriangleSideA
            // 
            NumericTriangleSideA.Location = new Point(6, 6);
            NumericTriangleSideA.Name = "NumericTriangleSideA";
            NumericTriangleSideA.Size = new Size(80, 27);
            NumericTriangleSideA.TabIndex = 8;
            // 
            // ButtonDeleteTriangles
            // 
            ButtonDeleteTriangles.Location = new Point(524, 6);
            ButtonDeleteTriangles.Name = "ButtonDeleteTriangles";
            ButtonDeleteTriangles.Size = new Size(125, 29);
            ButtonDeleteTriangles.TabIndex = 7;
            ButtonDeleteTriangles.Text = "Удалить помеч.";
            ButtonDeleteTriangles.UseVisualStyleBackColor = true;
            ButtonDeleteTriangles.Click += ButtonDeleteTriangles_Click;
            // 
            // ButtonSortTriangles
            // 
            ButtonSortTriangles.Location = new Point(655, 6);
            ButtonSortTriangles.Name = "ButtonSortTriangles";
            ButtonSortTriangles.Size = new Size(107, 29);
            ButtonSortTriangles.TabIndex = 5;
            ButtonSortTriangles.Text = "Сортировать";
            ButtonSortTriangles.UseVisualStyleBackColor = true;
            ButtonSortTriangles.Click += ButtonSortTriangles_Click;
            // 
            // ButtonAddTriangle
            // 
            ButtonAddTriangle.Location = new Point(264, 6);
            ButtonAddTriangle.Name = "ButtonAddTriangle";
            ButtonAddTriangle.Size = new Size(84, 29);
            ButtonAddTriangle.TabIndex = 4;
            ButtonAddTriangle.Text = "Добавить";
            ButtonAddTriangle.UseVisualStyleBackColor = true;
            ButtonAddTriangle.Click += ButtonAddTriangle_Click;
            // 
            // DataGridViewTriangles
            // 
            DataGridViewTriangles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTriangles.Columns.AddRange(new DataGridViewColumn[] { ColumnTriangleCheckBox, ColumnTriangleId, ColumnTriangleArea, ColumnTrianglePerimeter, ColumnTriangleSideA, ColumnTriangleSideB, ColumnTriangleSideC });
            DataGridViewTriangles.Location = new Point(6, 39);
            DataGridViewTriangles.Name = "DataGridViewTriangles";
            DataGridViewTriangles.RowHeadersWidth = 51;
            DataGridViewTriangles.Size = new Size(756, 348);
            DataGridViewTriangles.TabIndex = 0;
            // 
            // ColumnTriangleCheckBox
            // 
            ColumnTriangleCheckBox.HeaderText = "";
            ColumnTriangleCheckBox.MinimumWidth = 6;
            ColumnTriangleCheckBox.Name = "ColumnTriangleCheckBox";
            ColumnTriangleCheckBox.Width = 65;
            // 
            // ColumnTriangleId
            // 
            ColumnTriangleId.HeaderText = "Номер";
            ColumnTriangleId.MinimumWidth = 6;
            ColumnTriangleId.Name = "ColumnTriangleId";
            ColumnTriangleId.ReadOnly = true;
            ColumnTriangleId.Width = 65;
            // 
            // ColumnTriangleArea
            // 
            ColumnTriangleArea.HeaderText = "Площадь";
            ColumnTriangleArea.MinimumWidth = 6;
            ColumnTriangleArea.Name = "ColumnTriangleArea";
            ColumnTriangleArea.ReadOnly = true;
            ColumnTriangleArea.Width = 110;
            // 
            // ColumnTrianglePerimeter
            // 
            ColumnTrianglePerimeter.HeaderText = "Периметр";
            ColumnTrianglePerimeter.MinimumWidth = 6;
            ColumnTrianglePerimeter.Name = "ColumnTrianglePerimeter";
            ColumnTrianglePerimeter.ReadOnly = true;
            ColumnTrianglePerimeter.Width = 110;
            // 
            // ColumnTriangleSideA
            // 
            ColumnTriangleSideA.HeaderText = "Сторона A";
            ColumnTriangleSideA.MinimumWidth = 6;
            ColumnTriangleSideA.Name = "ColumnTriangleSideA";
            ColumnTriangleSideA.ReadOnly = true;
            ColumnTriangleSideA.Width = 110;
            // 
            // ColumnTriangleSideB
            // 
            ColumnTriangleSideB.HeaderText = "Сторона B";
            ColumnTriangleSideB.MinimumWidth = 6;
            ColumnTriangleSideB.Name = "ColumnTriangleSideB";
            ColumnTriangleSideB.ReadOnly = true;
            ColumnTriangleSideB.Width = 110;
            // 
            // ColumnTriangleSideC
            // 
            ColumnTriangleSideC.HeaderText = "Сторона C";
            ColumnTriangleSideC.MinimumWidth = 6;
            ColumnTriangleSideC.Name = "ColumnTriangleSideC";
            ColumnTriangleSideC.ReadOnly = true;
            ColumnTriangleSideC.Width = 110;
            // 
            // FiguresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlFigures);
            Name = "FiguresForm";
            Text = "FiguresForm";
            Load += FiguresForm_Load;
            FormClosing += FiguresForm_FormClosing;
            TabControlFigures.Selecting += TabControlFigures_Selecting;
            TabControlFigures.ResumeLayout(false);
            TabPageFigures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewFigures).EndInit();
            TabPageCircles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumericCircleRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCircles).EndInit();
            TabPageRectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumericRectangleHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericRectangleWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRectangles).EndInit();
            TabPageTriangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideC).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideB).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericTriangleSideA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTriangles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlFigures;
        private TabPage TabPageFigures;
        private TabPage TabPageCircles;
        private TabPage TabPageRectangles;
        private TabPage TabPageTriangles;
        private DataGridView DataGridViewTriangles;
        private Button ButtonAddTriangle;
        private Button ButtonSortTriangles;
        private Button ButtonDeleteTriangles;
        private Button ButtonAddRectangle;
        private Button ButtonDeleteRectangles;
        private Button ButtonSortRectangles;
        private DataGridView DataGridViewRectangles;
        private Button ButtonSortCircles;
        private Button ButtonDeleteCircles;
        private Button ButtonAddCircle;
        private DataGridView DataGridViewCircles;
        private DataGridView DataGridViewFigures;
        private Button ButtonSortFigures;
        private Button ButtonDeleteFigures;
        private DataGridViewCheckBoxColumn ColumnFigureCheckBox;
        private DataGridViewTextBoxColumn ColumnFigureId;
        private DataGridViewTextBoxColumn ColumnFigureArea;
        private DataGridViewTextBoxColumn ColumnFigurePerimeter;
        private DataGridViewCheckBoxColumn ColumnCircleCheckBox;
        private DataGridViewTextBoxColumn ColumnCircleId;
        private DataGridViewTextBoxColumn ColumnCircleArea;
        private DataGridViewTextBoxColumn ColumnCirclePerimeter;
        private DataGridViewTextBoxColumn ColumnCircleRadius;
        private DataGridViewCheckBoxColumn ColumnRectangleCheckBox;
        private DataGridViewTextBoxColumn ColumnRectangleId;
        private DataGridViewTextBoxColumn ColumnRectangleArea;
        private DataGridViewTextBoxColumn ColumnRectanglePerimeter;
        private DataGridViewTextBoxColumn ColumnRectangleWidth;
        private DataGridViewTextBoxColumn ColumnRectangleHeight;
        private DataGridViewCheckBoxColumn ColumnTriangleCheckBox;
        private DataGridViewTextBoxColumn ColumnTriangleId;
        private DataGridViewTextBoxColumn ColumnTriangleArea;
        private DataGridViewTextBoxColumn ColumnTrianglePerimeter;
        private DataGridViewTextBoxColumn ColumnTriangleSideA;
        private DataGridViewTextBoxColumn ColumnTriangleSideB;
        private DataGridViewTextBoxColumn ColumnTriangleSideC;
        private NumericUpDown NumericCircleRadius;
        private NumericUpDown NumericRectangleHeight;
        private NumericUpDown NumericRectangleWidth;
        private NumericUpDown NumericTriangleSideC;
        private NumericUpDown NumericTriangleSideB;
        private NumericUpDown NumericTriangleSideA;
    }
}
