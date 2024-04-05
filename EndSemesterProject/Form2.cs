using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndSemesterProject
{
    public partial class Form2 : Form
    {
        private Form1 fromInstance;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.fromInstance = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromInstance.Rect_Width = GiveValue(rectangle_Width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
            fromInstance.Rect_Height =  GiveValue(rectangle_Height, "Please enter a valid number for rectangle helight!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side1 = GiveValue(triangle_Side1, "Please enter a valid number for triangle side1!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side2 =  GiveValue(triangle_Side2, "Please enter a valid number for triangle side2!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side3 =GiveValue(triangle_Side3, "Please enter a valid number for triangle side3!\nA default value of 50 is set instead!");
            fromInstance.Circle_Radius = GiveValue(circle_Radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!");
            fromInstance.Rect_outColor = ConvertToColor(rectangle_outColor.Text);
            fromInstance.Triangle_outColor = ConvertToColor(triangle_outColor.Text);
            fromInstance.Circle_outColor = ConvertToColor(circle_outColor.Text);
            this.Close();
        }
        private Color ConvertToColor(string color)
        {
            color = color.ToLower();
            if (color == "red") return Color.Red;
            else if (color == "blue") return Color.Blue;
            else if (color == "green") return Color.Green;
            else if (color == "yellow") return Color.Yellow;
            else return Color.Black;
            // default color
        }
        private int GiveValue(TextBox t, string message)
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
        private bool check_Text(TextBox t)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
