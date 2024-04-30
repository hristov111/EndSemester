using EndSemensterProject;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using Figures;

namespace EndSemesterProject
{
    public partial class Form1 : Form
    {
        // width: 1387
        //height:  686
        public delegate void CommandMethod();
        public List<Figures.Figure> figures = new List<Figures.Figure>();
        private List<CommandMethod> commands = new List<CommandMethod>();
        public string currentColor = null;
        // setting default properties
        public int Rect_Width { get; set; } = 50;
        public int Rect_Height { get; set; } = 50;
        public int Triangle_Side1 { get; set; } = 50;
        public int Triangle_Side2 { get; set; } = 50;
        public int Triangle_Side3 { get; set; } = 50;
        public int Circle_Radius { get; set; } = 50;

        // black is the default outline color
        public string Rect_outColor { get; set; } = "black";
        public string Triangle_outColor { get; set; } = "black";
        public string Circle_outColor { get; set; } = "black";
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
        public void ChangeInidces(Type obj, int idx,bool deleting)
        {

            // find all indices of the specified figure type
            var figureIndices = figures.Select((figure,index) => new { Figure = figure, Index = index})
                .Where(x => x.Index >=idx && x.Figure.GetType() == obj)
                .Select(x => x.Index)
                .ToList();
            int last = 0;
            foreach (var index in figureIndices)
            {
                figures[index].ID += deleting ? -1 : 1;
                last = index;
            }
            if(obj.GetProperty("NextID") != null)
            {
                obj.GetProperty("NextID").SetValue(null, last + 1);
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
                Pen.Draw_shape(e.Graphics, figure);
                
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
            redo_undo.Set_ClearList(figures, Triangle.NextID, Figures.Rectangle.NextID, Circle.NextID);
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
    }
}
