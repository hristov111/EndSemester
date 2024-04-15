using EndSemensterProject;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace EndSemesterProject
{
    public partial class Form1 : Form
    {
        // width: 1387
        //height:  686
        public delegate void CommandMethod();
        public List<Figure> figures = new List<Figure>();
        private List<CommandMethod> commands = new List<CommandMethod>();
        public Color currentColor = Color.Empty;
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
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Color_Button.Instance = this;
            redo_undo =  new Red_Undo(this);
            CREATE_figure = new CreateMember(this);
            DELETE_figure = new DeleteMember(this);
            MOVE_figure = new MoveMember(this);
            EDIT_figure = new EditMember(this);
            Color_Button.Instance2  = CREATE_figure;
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

            // OPtional:
            //foreach (var command in commands)
            //{
            //    command();
            //}
        }
        public void options_button_Click(object sender, EventArgs e)
        {
            Form2 second_form = new Form2(this);
            second_form.ShowDialog();
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MOVE_figure.StartMove(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MOVE_figure.Execute(e);

            // Optional:
            //commands.Add(() => MOVE_figure.Execute(e));
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draggingShape = null;
        }

        private void Form1_DoubleClick(object sender, MouseEventArgs e)
        {
            EDIT_figure.Execute(e);

            // Optional:
            //commands.Add(() => EDIT_figure.Execute(e));
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            redo_undo.Set_ClearList(figures, Triangle.NextID, Rectangle.NextID, Circle.NextID);
            figures.Clear();
            Rectangle.NextID = 0;
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
    }
}
