using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures; 

namespace EndSemesterProject
{
    public partial class SingleTriangle : Form
    {
        private Triangle Instance;
        private Red_Undo Redo_undo;
        private Triangle checking_trig;
        public string Color { get; set; }
        public string Outline { get; set; }
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_trig = new CheckTextbox();
        public string Color_inside = null;
        public SingleTriangle(Red_Undo redo_undo, Triangle instance, string color, string outline, int firstSide, int secondSide, int thirdSide, int id)
        {
            InitializeComponent();
            this.Instance=instance;
            this.Redo_undo = redo_undo;
            Color=color;
            Outline=outline;
            FirstSide=firstSide;
            SecondSide=secondSide;
            ThirdSide=thirdSide;
            ID = id;
            current_color.Text = Color.ToString();
            Color_inside = current_color.Text;
            current_outline.Text = outline.ToString();
            first_side.Text = firstSide.ToString();
            second_side.Text = secondSide.ToString();
            third_side.Text = thirdSide.ToString();
            triangle_groupBox.Text +=$": {ID}";
            checking_trig = new Triangle(Instance.X, Instance.Y,Color,Outline,FirstSide,SecondSide,ThirdSide,true);


        }
        private void triangle_button_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_trig.ConvertToColor(current_color.Text);
            if (Instance.FigureColor.Equals("black"))
            {
                Instance.FigureColor = Color_inside;
            }
            Instance.Figure_outColor = check_trig.ConvertToColor(current_outline.Text);
            Instance.FirstSide = check_trig.GiveValue(first_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            Instance.SecondSide = check_trig.GiveValue(second_side, "Please enter a valid number for triangle's second side!\nA default value of 50 is set instead!");
            Instance.ThirdSide = check_trig.GiveValue(third_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            Instance.ChangePos(Instance.X, Instance.Y);
            Redo_undo.SetValuesEdit(checking_trig, Instance);
            this.Close();
        }
       
        
    }
}
