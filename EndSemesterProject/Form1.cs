using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace EndSemesterProject
{
    public partial class Form1 : Form
    {
        // width: 1387
        //height:  686

        public List<Figure> figures = new List<Figure>();
        public Color currentColor;
        // setting default properties
        public int Rect_Width { get; set; } = 50;
        public int Rect_Height { get; set; } = 50;
        public int Triangle_Side1 { get; set; } = 50;
        public int Triangle_Side2 { get; set; } = 50;
        public int Triangle_Side3 { get; set; } = 50;
        public int Circle_Radius { get; set; } = 50;

        // black is the default outline color
        public Color Rect_outColor { get; set; } = Color.Black;
        public Color Triangle_outColor { get; set; } = Color.Black;
        public Color Circle_outColor { get; set; } = Color.Black;
        public int MouseX { get; set; }
        public int MouseY { get; set; }
        private bool left_mouseClick = true;
        public Figure currentFigure;
        Point scrPos;
        Point formPos;
        private string currentMode = "Create";
        private bool isDragging = false;
        private Figure draggingShape;
        private Point DragStart;
        private Red_Undo redo_undo;
        public int screen_remove = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Color_Button.Instance = this;
            redo_undo =  new Red_Undo(this);

        }



        private void create_circle_Click(object sender, EventArgs e)
        {

            scrPos = Cursor.Position;
            formPos = this.PointToClient(scrPos);
            if (currentColor == Color.Red)
            {
                currentFigure = new Circle(formPos.X, formPos.Y, Color.Red, Circle_outColor, Circle_Radius);
            }
            else if (currentColor == Color.Blue)
            {
                currentFigure = new Circle(formPos.X, formPos.Y, Color.Blue, Circle_outColor, Circle_Radius);
            }
            else if (currentColor == Color.Green)
            {
                currentFigure = new Circle(formPos.X, formPos.Y, Color.Green, Circle_outColor, Circle_Radius);
            }
            else if (currentColor == Color.Yellow)
            {
                currentFigure = new Circle(formPos.X, formPos.Y, Color.Yellow, Circle_outColor, Circle_Radius);
            }

        }
        private void create_Triangle_Click(object sender, EventArgs e)
        {
            scrPos = Cursor.Position;
            formPos = this.PointToClient(scrPos);
            if (currentColor == Color.Red)
            {
                currentFigure = new Triangle(formPos.X, formPos.Y, Color.Red, Triangle_outColor, Triangle_Side1, Triangle_Side2, Triangle_Side3);
            }
            else if (currentColor == Color.Blue)
            {
                currentFigure = new Triangle(formPos.X, formPos.Y, Color.Blue, Triangle_outColor, Triangle_Side1, Triangle_Side2, Triangle_Side3);
            }
            else if (currentColor == Color.Green)
            {
                currentFigure = new Triangle(formPos.X, formPos.Y, Color.Green, Triangle_outColor, Triangle_Side1, Triangle_Side2, Triangle_Side3);
            }
            else if (currentColor == Color.Yellow)
            {
                currentFigure = new Triangle(formPos.X, formPos.Y, Color.Yellow, Triangle_outColor, Triangle_Side1, Triangle_Side2, Triangle_Side3);
            }

        }
        private void create_Rectangle_Click(object sender, EventArgs e)
        {
            scrPos = Cursor.Position;
            formPos = this.PointToClient(scrPos);
            if (currentColor == Color.Red)
            {
                currentFigure = new Rectangle(formPos.X, formPos.Y, Color.Red, Rect_outColor, Rect_Width, Rect_Height);
            }
            else if (currentColor == Color.Blue)
            {
                currentFigure = new Rectangle(formPos.X, formPos.Y, Color.Blue, Rect_outColor, Rect_Width, Rect_Height);
            }
            else if (currentColor == Color.Green)
            {
                currentFigure = new Rectangle(formPos.X, formPos.Y, Color.Green, Rect_outColor, Rect_Width, Rect_Height);
            }
            else if (currentColor == Color.Yellow)
            {
                currentFigure = new Rectangle(formPos.X, formPos.Y, Color.Yellow, Rect_outColor, Rect_Width, Rect_Height);
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && currentFigure != null)
            {
                if (currentMode == "Create")
                {
                    redo_undo.undo_modes.Push("Create");
                    redo_undo.undo.Push(currentFigure);
                    figures.Add(currentFigure);
                    redo_undo.undo_indices.Push(figures.IndexOf(currentFigure));
                    this.Invalidate();
                    if (currentFigure is Rectangle)
                    {
                        create_Rectangle_Click(create_Rectangle, EventArgs.Empty);
                    }
                    else if (currentFigure is Triangle)
                    {
                        create_Triangle_Click(create_Triangle, EventArgs.Empty);
                    }
                    else if (currentFigure is Circle)
                    {
                        create_circle_Click(create_circle, EventArgs.Empty);
                    }
                }
                else if (currentMode == "Delete")
                {
                    for (int i = figures.Count -1; i>=0; i--)
                    {
                        if (figures[i].HitTest(new Point(e.X, e.Y)))
                        {
                            redo_undo.undo_modes.Push("Delete");
                            redo_undo.undo.Push(figures[i]);
                            redo_undo.undo_indices.Push(i);
                            figures.Remove(figures[i]);
                            ChangeInidces(figures[i], i,true);
                            this.Invalidate();
                            break;

                        }
                    }
                }
            }
        }
        public void ChangeInidces(Figure obj, int idx,bool deleting)
        {
            int last = 0;
            if (obj is Rectangle)
            {
                for (int i = idx; i<figures.Count; i++)
                {
                    if (figures[i] is Rectangle)
                    {
                        Rectangle rect = (Rectangle)figures[i];
                        if (deleting)
                        {
                            rect.ID--;
                        }
                        else
                        {
                            rect.ID++;
                        }
                    }
                    if (i == figures.Count -1)
                    {
                        last = i;
                    }
                }
                Rectangle.NextID = last+1;

            }
            else if (obj is Triangle)
            {
                for (int i = idx; i<figures.Count; i++)
                {
                    if (figures[i] is Triangle)
                    {
                        Triangle trig = (Triangle)figures[i];
                        if (deleting)
                        {
                            trig.ID--;
                        }
                        else
                        {
                            trig.ID++;
                        }
                    }
                    if (i == figures.Count -1)
                    {
                        last = i;
                    }
                }
                Triangle.NextID = last+1;

            }
            else if (obj is Circle)
            {
                for (int i = idx; i<figures.Count; i++)
                {
                    if (figures[i] is Circle)
                    {
                        Circle circ = (Circle)figures[i];
                        if (deleting)
                        {
                            circ.ID--;
                        }
                        else
                        {
                            circ.ID++;
                        }
                    }
                    if (i == figures.Count -1)
                    {
                        last = i;
                    }
                }
                Circle.NextID = last+1;

            }

        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            currentMode = comboBox1.Text;
            MessageBox.Show($"Mode changed to {currentMode}!", "Warning!");
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw each circle in the list
            foreach (Figure figure in figures)
            {
                figure.DrawShape(e.Graphics);
            }
        }
        public void options_button_Click(object sender, EventArgs e)
        {
            Form2 second_form = new Form2(this);
            second_form.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentMode == "Move")
            {
                for (int i = figures.Count - 1; i >= 0; i--)
                {
                    if (figures[i].HitTest(new Point(e.X, e.Y)))
                    {
                        draggingShape = figures[i];
                        DragStart = new Point(e.X - figures[i].X, e.Y - figures[i].Y);
                        break;
                    }
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingShape != null)
            {
                draggingShape.ChangePos(e.X - DragStart.X, e.Y - DragStart.Y);
                Invalidate();
            }
            foreach (Figure fig in figures)
            {
                if (fig.HitTest(new Point(e.X, e.Y)))
                {
                    if (this.Cursor != Cursors.Hand)
                    {
                        this.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        if (this.Cursor != Cursors.Default)
                        {
                            this.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draggingShape = null;
        }

        private void Form1_DoubleClick(object sender, MouseEventArgs e)
        {
            if (currentMode == "Edit")
            {
                Figure current_Fig = null;
                for (int i = figures.Count - 1; i >= 0; i--)
                {
                    if (figures[i].HitTest(new Point(e.X, e.Y)))
                    {
                        current_Fig = figures[i];
                        break;
                    }
                }
                if (current_Fig != null)
                {
                    if (current_Fig is Triangle)
                    {
                        Triangle curr_trig = current_Fig as Triangle;
                        SingleTriangle trig_edit = new SingleTriangle(curr_trig, curr_trig.FigureColor, curr_trig.Figure_outColor, curr_trig.FirstSide, curr_trig.SecondSide, curr_trig.ThirdSide, curr_trig.ID);
                        trig_edit.ShowDialog();
                        Invalidate();
                    }
                    else if (current_Fig is Rectangle)
                    {
                        Rectangle curr_rect = current_Fig as Rectangle;
                        SingleRectangle rect_edit = new SingleRectangle(curr_rect, curr_rect.FigureColor, curr_rect.Figure_outColor, curr_rect.Width, curr_rect.Height, curr_rect.ID);
                        rect_edit.ShowDialog();
                        Invalidate();
                    }
                    else if (current_Fig is Circle)
                    {
                        Circle curr_circle = current_Fig as Circle;
                        SingleCircle circle_edit = new SingleCircle(curr_circle, curr_circle.FigureColor, curr_circle.Figure_outColor, curr_circle.Radius, curr_circle.ID);
                        circle_edit.ShowDialog();
                        Invalidate();
                    }

                }
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<figures.Count; i++)
            {
                redo_undo.undo_clear.Add(figures[i]);
            }
            redo_undo.undo_modes.Push("Clear");
            redo_undo.rectangle_nextId=Rectangle.NextID;
            redo_undo.triangle_nextId=Triangle.NextID;
            redo_undo.circle_nextId=Circle.NextID;
            figures.Clear();
            Rectangle.NextID = 0;
            Triangle.NextID = 0;
            Circle.NextID = 0;
            screen_remove++;
            Invalidate();
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            redo_undo.Undo();
            Invalidate();
        }

        private void redo_button_Click(object sender, EventArgs e)
        {
            redo_undo.Redo();
            Invalidate();
        }
    }
}
