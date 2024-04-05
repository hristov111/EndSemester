using System.Drawing;

namespace EndSemesterProject
{
    public partial class Form1 : Form
    {
        // width: 1387
        //height:  686
        private List<Figure> figures = new List<Figure>();
        private Color currentColor;
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
        private Figure currentFigure;
        Point scrPos;
        Point formPos;
        private string currentMode = "Create";
        public Form1()
        {
            InitializeComponent();
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
                if(currentMode == "Create")
                {
                    figures.Add(currentFigure);
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
                else if(currentMode == "Delete")
                {

                }
            }
        }
        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            currentMode = comboBox1.Text;
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

        private void red_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            currentColor= Color.Blue;
        }

        private void green_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
        }

        public void options_button_Click(object sender, EventArgs e)
        {
            Form2 second_form = new Form2(this);
            second_form.ShowDialog();
        }
    }
}
