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
using System.Text.Json;
using Figures;
using System.Xml.Serialization;
using System.IO;
using EndSemensterProject;

namespace EndSemesterProject
{
    public partial class Form2 : Form
    {
        private Form1 fromInstance;
        private CheckTextbox textbox = new CheckTextbox();
        FigureSerializer serializer;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.fromInstance = form1;
            rectangle_Height.Text = fromInstance.Rect_Height.ToString();
            rectangle_Width.Text = fromInstance.Rect_Width.ToString();
            rectangle_outColor.Text = fromInstance.Rect_outColor;
            triangle_Side1.Text = fromInstance.Triangle_Side1.ToString();
            triangle_Side2.Text = fromInstance.Triangle_Side2.ToString();
            triangle_Side3.Text = fromInstance.Triangle_Side3.ToString();
            triangle_outColor.Text = fromInstance.Triangle_outColor;
            circle_Radius.Text = fromInstance.Circle_Radius.ToString();
            circle_outColor.Text = fromInstance.Circle_outColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromInstance.ChangeProperties(
                textbox.GiveValue(rectangle_Width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!"),
                 textbox.GiveValue(rectangle_Height, "Please enter a valid number for rectangle helight!\nA default value of 50 is set instead!"),
                 textbox.GiveValue(triangle_Side1, "Please enter a valid number for triangle side1!\nA default value of 50 is set instead!"),
                 textbox.GiveValue(triangle_Side2, "Please enter a valid number for triangle side2!\nA default value of 50 is set instead!"),
                 textbox.GiveValue(triangle_Side3, "Please enter a valid number for triangle side3!\nA default value of 50 is set instead!"),
                 textbox.GiveValue(circle_Radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!"),
                 textbox.ConvertToColor(rectangle_outColor.Text),
                 textbox.ConvertToColor(triangle_outColor.Text),
                 textbox.ConvertToColor(circle_outColor.Text));
            this.Close();
        }

        private void load_fromFile_Button_Click(object sender, EventArgs e)
        {
            serializer = new FigureSerializer();
            fromInstance.figures = serializer.LoadFigures();
            Triangle.NextID = fromInstance.figures.Count(n=> n is Triangle);
            Circle.NextID = fromInstance.figures.Count(n => n is Circle);
            Figures.Rectangle.NextID = fromInstance.figures.Count(n => n is Figures.Rectangle);
            
            this.Close();
        }

        private void save_toFile_Button_Click(object sender, EventArgs e)
        {
            serializer = new FigureSerializer();
            serializer.SaveFigures(fromInstance.figures);
            this.Close();
        }

        private void default_button_Click(object sender, EventArgs e)
        {
            fromInstance.ChangeProperties(50, 50, 50, 50, 50, 50, "black", "black", "black");
            this.Close();
        }
    }
}
