using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace EndSemesterProject
{
    public partial class SingleRectangle : Form
    {
        private Form1 Instance_form;
        private Figures.Rectangle Instance;
        private Red_Undo Redo_undo;
        private Figures.Rectangle checking_rect;
        public string Color { get; set; }
        public string Outline { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_rect = new CheckTextbox();
        public string Color_inside = null;
        public string Color_outside = "black";
        public SingleRectangle(Form1 instance_form,Red_Undo redo_undo,Figures.Rectangle instance, string color, string outline, int width, int height, int id)
        {
            InitializeComponent();
            Instance_form = instance_form;
            this.Instance=instance;
            this.Redo_undo=redo_undo;
            Color=color;
            Outline=outline;
            Height = height;
            Width = width;
            ID = id;

            current_color.Text = Color;
            Color_inside = current_color.Text;

            current_outline.Text = outline;
            Color_outside = current_outline.Text;

            current_height.Text = Height.ToString();
            current_width.Text = Width.ToString();
            rect_groupbox.Text +=$": {ID}";
            checking_rect = new Figures.Rectangle(Instance.X, Instance.Y,color, outline,width,height,true);
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_rect.ConvertToColor(current_color.Text);
            Instance.Figure_outColor = check_rect.ConvertToColor(current_outline.Text);
            if (Instance.FigureColor!= "black" && Instance.FigureColor != Color_inside)
            {
                Instance_form.Rect_Color = null;
            }
            if(Instance.Figure_outColor != Color_outside)
            {
                Instance_form.Rect_outColor = null;
            }
            if (Instance.FigureColor.Equals("black"))
            {
                Instance.FigureColor = Color_inside;
            }
            Instance.Height = check_rect.GiveValue(current_height, "Please enter a valid number for rectangle height!\nA default value of 50 is set instead!");
            Instance.Width = check_rect.GiveValue(current_width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
            this.Redo_undo.SetValuesEdit(checking_rect, Instance);
            this.Close();
        }

       
    }
}
