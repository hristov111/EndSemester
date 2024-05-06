using EndSemensterProject;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Figures;
using System.Timers;

namespace EndSemesterProject
{
    public partial class Form1 : Form
    {
        private int MINWIDTH = 990;
        private int MINHEIGHT = 265;
        public int WIDTH = 1387;
        public int HEIGHT = 686;
        // width: 1387
        //height:  686
        public delegate void CommandMethod();
        public List<Figures.Figure> figures = new List<Figures.Figure>();
        private List<CommandMethod> commands = new List<CommandMethod>();
        public List<string> colors = new List<string>();
        public List<string> outline_colors = new List<string>();
        private int SAVED_C = 0;
        public string currentColor = null;
        public string currentOutColor = null;
        // setting default properties
        public int Rect_Width { get; set; } = 50;
        public int Rect_Height { get; set; } = 50;
        public int Triangle_Side1 { get; set; } = 50;
        public int Triangle_Side2 { get; set; } = 50;
        public int Triangle_Side3 { get; set; } = 50;
        public int Circle_Radius { get; set; } = 50;

        // black is the default outline color
        public string Rect_outColor { get; set; } = null;
        public string Triangle_outColor { get; set; } = null;
        public string Circle_outColor { get; set; } = null;

        public string Rect_Color { get; set; } = null;
        public string Triangle_Color { get; set; } = null;

        public string Circle_Color { get; set; } = null;

        public int MouseX { get; set; }
        public int MouseY { get; set; }
        public Figure currentFigure = null;
        public string current_option;
        Point scrPos;
        Point formPos;
        public string currentMode = "Create";
        public Figure draggingShape = null;
        public Point DragStart;
        public Red_Undo redo_undo;
        public int screen_remove = 0;

        private CreateMember CREATE_figure;
        private DeleteMember DELETE_figure;
        private MoveMember MOVE_figure;
        private EditMember EDIT_figure;

        Draw Pen = new Draw();
        Form2 second_form;
        private bool isAlive_ = false;
        private System.Timers.Timer animationTimer;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Color_Button.Instance = this;
            redo_undo = new Red_Undo(this);
            CREATE_figure = new CreateMember(this);
            DELETE_figure = new DeleteMember(this);
            MOVE_figure = new MoveMember(this);
            EDIT_figure = new EditMember(this);
            Color_Button.Instance2 = CREATE_figure;
        }



        public void create_circle_Click(object sender, EventArgs e)
        {
            current_option = "Circle";

        }
        public void create_Triangle_Click(object sender, EventArgs e)
        {
            current_option = "Triangle";
        }
        public void create_Rectangle_Click(object sender, EventArgs e)
        {
            current_option = "Rectangle";
        }
        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && current_option != null)
            {
                CREATE_figure.Execute(e);
                DELETE_figure.Execute(e);
            }
        }
        public void ChangeInidces(Type obj, int idx, bool deleting)
        {

            // find all indices of the specified figure type
            var figureIndices = figures.Select((figure, index) => new { Figure = figure, Index = index })
                .Where(x => x.Index >= idx && x.Figure.GetType() == obj)
                .Select(x => x.Index)
                .ToList();
            int last = 0;
            foreach (var index in figureIndices)
            {
                figures[index].ID += deleting ? -1 : 1;
                last = index;
            }
            if (obj.GetProperty("NextID") != null)
            {
                obj.GetProperty("NextID").SetValue(null, last + 1);
            }

        }
        private void Alive_button()
        {
            isAlive_ = true;

            animationTimer = new System.Timers.Timer();
            animationTimer.Interval = 50;
            animationTimer.Elapsed += Animation;

            stop_Alive_button.Visible = true;
            undo_button.Visible = false;
            redo_button.Visible = false;
            comboBox1.Visible = false;
            mode1.Visible = false;
            Invalidate();

            animationTimer.Start();
        }
        private void Animation(object sender, ElapsedEventArgs e)
        {
            if (!isAlive_)
            {
                animationTimer.Stop();
                return;
            }
            foreach (Figure fig in figures)
            {
                if (fig is Figures.Rectangle)
                {
                    Figures.Rectangle rect = (Figures.Rectangle)fig;
                    rect.MoveMember(rect.IsAtRight(), rect.IsAtLeft(), rect.IsAtTop(), rect.IsAtBottom());
                    rect.ChangePos(rect.X, rect.Y);
                }
                if (fig is Triangle)
                {
                    Triangle trig = (Triangle)fig;
                    trig.MoveMember(trig.IsAtRight(), trig.IsAtLeft(), trig.IsAtTop(), trig.IsAtBottom());
                    trig.ChangePos(trig.X, trig.Y);
                }
                else if (fig is Circle)
                {
                    Circle circle = (Circle)fig;
                    circle.MoveMember(circle.IsAtRight(), circle.IsAtLeft(), circle.IsAtTop(), circle.IsAtBottom());
                }
            }
            Invalidate();
        }
        private void stop_Alive_button_Click(object sender, EventArgs e)
        {
            isAlive_ = false;
            stop_Alive_button.Visible = false;
            undo_button.Visible = true;
            redo_button.Visible = true;
            comboBox1.Visible = true;
            mode1.Visible = true;
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            currentMode = comboBox1.Text;
            MessageBox.Show($"Mode changed to {currentMode}!", "Warning!");
            if (currentMode == "Alive")
            {
                currentMode = "Create";
                Alive_button();
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw each circle in the list
            foreach (Figure figure in figures)
            {
                Pen.Draw_shape(e.Graphics, figure);

            }
        }
        public void options_button_Click(object sender, EventArgs e)
        {
            second_form = new Form2(this);
            second_form.ShowDialog();
            Invalidate();
        }
        public void ChangeProperties(int rect_width, int rect_height, int trig_1, int trig_2,
            int trig_3, int circle_radisus, string rect_out, string trig_out, string circle_out, string rect_color, string trig_color, string circle_color)
        {
            Rect_Width = rect_width;
            Rect_Height = rect_height;

            Triangle_Side1 = trig_1;
            Triangle_Side2 = trig_2;
            Triangle_Side3 = trig_3;

            Circle_Radius = circle_radisus;

            //Rect_outColor = rect_out;
            //Triangle_outColor = trig_out;
            //Circle_outColor = circle_out;
            if (rect_out != null)
            {
                Rect_outColor = rect_out;
            }
            if (trig_out != null)
            {
                Triangle_outColor = trig_out;
            }
            if (circle_out != null)
            {
                Circle_outColor = circle_out;
            }
            if (rect_color != null)
            {
                Rect_Color = rect_color;
            }
            if (trig_color != null)
            {
                Triangle_Color = trig_color;
            }
            if (circle_color != null)
            {
                Circle_Color = circle_color;
            }
            foreach (Figure figure in figures)
            {
                if (SAVED_C == 0)
                {
                    colors.Add(figure.FigureColor);
                    outline_colors.Add(figure.Figure_outColor);
                }
                if (figure is Figures.Rectangle)
                {
                    Figures.Rectangle rect = (Figures.Rectangle)figure;
                    rect.Height = rect_height;
                    rect.Width = rect_width;
                    if (rect_out != null)
                    {
                        rect.Figure_outColor = rect_out;
                    }
                    if (rect_color != null)
                    {
                        rect.FigureColor = Rect_Color;
                    }
                }
                else if (figure is Triangle)
                {
                    Triangle triangle = (Triangle)figure;
                    triangle.FirstSide = trig_1;
                    triangle.SecondSide = trig_2;
                    triangle.ThirdSide = trig_3;
                    if (trig_out != null)
                    {
                        triangle.Figure_outColor = trig_out;
                    }
                    if (trig_color != null)
                    {
                        triangle.FigureColor = Triangle_Color;
                    }
                    triangle.ChangePos(triangle.X, triangle.Y);

                }
                else if (figure is Circle)
                {
                    Circle circle = (Circle)figure;
                    circle.Radius = circle_radisus;
                    if (circle_color != null)
                    {
                        circle.FigureColor = Circle_Color;
                    }
                    if (circle_out != null)
                    {
                        circle.Figure_outColor = circle_out;
                    }
                }
            }
            SAVED_C++;
        }


        public void SetToDefault()
        {
            try
            {
                for (int i = 0; i < figures.Count; ++i)
                {
                    if (colors.Count > 0)
                    {
                        figures[i].FigureColor = colors[i];
                        figures[i].Figure_outColor = outline_colors[i];
                    }
                    if (figures[i] is Figures.Rectangle)
                    {
                        Figures.Rectangle rect = (Figures.Rectangle)figures[i];
                        rect.Height = 50;
                        rect.Width = 50;
                    }
                    else if (figures[i] is Triangle)
                    {
                        Triangle triangle = (Triangle)figures[i];
                        triangle.FirstSide = 50;
                        triangle.SecondSide = 50;
                        triangle.ThirdSide = 50;
                        triangle.ChangePos(triangle.X, triangle.Y);
                    }
                    else if (figures[i] is Circle)
                    {
                        Circle circle = (Circle)figures[i];
                        circle.Radius = 50;
                    }
                }
                colors.Clear();
                outline_colors.Clear();
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            Rect_Width = 50;
            Rect_Height = 50;
            Triangle_Side1 = 50;
            Triangle_Side2 = 50;
            Triangle_Side3 = 50;
            Circle_Radius = 50;
            SAVED_C = 0;





        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MOVE_figure.StartMove(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MOVE_figure.Execute(e);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draggingShape = null;
        }

        private void Form1_DoubleClick(object sender, MouseEventArgs e)
        {
            EDIT_figure.Execute(e);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            int trig = Triangle.NextID;
            int rect = Figures.Rectangle.NextID;
            int circle = Circle.NextID;
            colors.Clear();
            outline_colors.Clear();
            redo_undo.Set_ClearList(figures, trig, rect, circle);
            figures.Clear();
            Figures.Rectangle.NextID = 0;
            Triangle.NextID = 0;
            Circle.NextID = 0;
            screen_remove++;
            Invalidate();
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            redo_undo.DetermineUndo_Method();
            Invalidate();
        }

        private void redo_button_Click(object sender, EventArgs e)
        {
            redo_undo.DetermineRedo_Method();
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            WIDTH = this.Width;
            HEIGHT = this.Height;
            ScreenBoundaryHelper.WIDTH = WIDTH;
            ScreenBoundaryHelper.HEIGHT = HEIGHT;
            if(this.Width <= MINWIDTH)
            {
                this.Width = MINWIDTH;
            }
            if(this.Height <= MINHEIGHT)
            {
                this.Height = MINHEIGHT;
            }
            options_button.Location = new Point(this.ClientSize.Width - 82, 12);
            comboBox1.Location = new Point(this.ClientSize.Width - 210, 12);
            mode1.Location = new Point(this.ClientSize.Width - 256, 16);
            clear_button.Location = new Point(this.ClientSize.Width - 75, 39);
            undo_button.Location = new Point(this.ClientSize.Width / 2, 13);
            redo_button.Location = new Point(this.ClientSize.Width / 2 + 97, 13);
            // 990, 265

        }
    }
}
