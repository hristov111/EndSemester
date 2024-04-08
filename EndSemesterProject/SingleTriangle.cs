using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndSemesterProject
{
    public partial class SingleTriangle : Form
    {
        private Triangle Instance;
        public Color Color { get; set; }
        public Color Outline { get; set; }
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_trig = new CheckTextbox();
        public SingleTriangle(Triangle instance, Color color, Color outline, int firstSide, int secondSide, int thirdSide, int id)
        {
            InitializeComponent();
            this.Instance=instance;
            Color=color;
            Outline=outline;
            FirstSide=firstSide;
            SecondSide=secondSide;
            ThirdSide=thirdSide;
            ID = id;
            current_color.Text = Color.ToString();
            current_outline.Text = outline.ToString();
            first_side.Text = firstSide.ToString();
            second_side.Text = secondSide.ToString();
            third_side.Text = thirdSide.ToString();
            triangle_groupBox.Text +=$": {ID}";

        }
        private void triangle_button_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_trig.ConvertToColor(current_color.Text);
            Instance.Figure_outColor = check_trig.ConvertToColor(current_outline.Text);
            Instance.FirstSide = check_trig.GiveValue(first_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            Instance.SecondSide = check_trig.GiveValue(second_side, "Please enter a valid number for triangle's second side!\nA default value of 50 is set instead!");
            Instance.ThirdSide = check_trig.GiveValue(third_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            Instance.ChangePos(Instance.X, Instance.Y);
            this.Close();
        }
       
        
    }
}
