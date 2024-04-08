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
        private CheckTextbox textbox = new CheckTextbox();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.fromInstance = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromInstance.Rect_Width = textbox.GiveValue(rectangle_Width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
            fromInstance.Rect_Height =  textbox.GiveValue(rectangle_Height, "Please enter a valid number for rectangle helight!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side1 = textbox.GiveValue(triangle_Side1, "Please enter a valid number for triangle side1!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side2 =  textbox.GiveValue(triangle_Side2, "Please enter a valid number for triangle side2!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side3 =textbox.GiveValue(triangle_Side3, "Please enter a valid number for triangle side3!\nA default value of 50 is set instead!");
            fromInstance.Circle_Radius = textbox.GiveValue(circle_Radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!");
            fromInstance.Rect_outColor = textbox.ConvertToColor(rectangle_outColor.Text);
            fromInstance.Triangle_outColor = textbox.ConvertToColor(triangle_outColor.Text);
            fromInstance.Circle_outColor = textbox.ConvertToColor(circle_outColor.Text);
            this.Close();
        }
    
    }
}
