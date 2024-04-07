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
    public partial class SingleTriangle : Form, ICheckTextbox
    {
        private Triangle Instance;
        public Color Color { get; set; }
        public Color Outline { get; set; }
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        private int ID { get; set; }
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
            Instance.FigureColor = ConvertToColor(current_color.Text);
            Instance.Figure_outColor = ConvertToColor(current_outline.Text);
            Instance.FirstSide = GiveValue(first_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            Instance.SecondSide = GiveValue(second_side, "Please enter a valid number for triangle's second side!\nA default value of 50 is set instead!");
            Instance.ThirdSide = GiveValue(third_side, "Please enter a valid number for triangle's first side!\nA default value of 50 is set instead!");
            this.Close();
        }
        public Color ConvertToColor(string color)
        {
            color = color.ToLower();
            if (color == "red") return Color.Red;
            else if (color == "blue") return Color.Blue;
            else if (color == "green") return Color.Green;
            else if (color == "yellow") return Color.Yellow;
            return Color.Aqua;
            //default color if no color is given
        }

        public int GiveValue(TextBox t, string message)
        {
            if (!check_Text(t))
            {
                MessageBox.Show(message, "Error!");
                t.Text = "";
                //default value if there is a error
                return 50;
            }
            if (t.Text != "")
            {
                int num = Convert.ToInt32(t.Text);
                t.Text = "";
                return num;
            }
            else
            {
                MessageBox.Show("No argument given! Default value of 50 set", "Error!");
                return 50;
            }
        }

        public bool check_Text(TextBox t)
        {
            string text = t.Text;
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
