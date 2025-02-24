﻿using System;
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

            triangle_Side1.Text = fromInstance.Triangle_Side1.ToString();
            triangle_Side2.Text = fromInstance.Triangle_Side2.ToString();
            triangle_Side3.Text = fromInstance.Triangle_Side3.ToString();

            circle_Radius.Text = fromInstance.Circle_Radius.ToString();

            Check_Color(true);
            Check_Color(false);

            if(fromInstance.Circle_Color != null)
            {
                circle_color.Text = fromInstance.Circle_Color;
            }
            if(fromInstance.Rect_Color != null)
            {
                rect_color.Text = fromInstance.Rect_Color;
            }
            if(fromInstance.Triangle_Color != null)
            {
                triangle_color.Text = fromInstance.Triangle_Color;
            }
            if(fromInstance.Triangle_outColor != null)
            {
                triangle_outColor.Text= fromInstance.Triangle_outColor;
            }
            if( fromInstance.Rect_outColor != null)
            {
                rectangle_outColor.Text = fromInstance.Rect_outColor;
            }
            if(fromInstance.Circle_outColor != null)
            {
                circle_outColor.Text = fromInstance.Circle_outColor;
            }

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
                 textbox.ConvertToColor(circle_outColor.Text),
                 textbox.ConvertToColor(rect_color.Text),
                 textbox.ConvertToColor(triangle_color.Text),
                 textbox.ConvertToColor(circle_color.Text)
                 );
            this.Close();
        }
        private void Check_Color(bool isInside)
        {
            string c_color = null;
            bool circle_checked = false;
            string r_color = null;
            bool r_checked = false;
            string t_color = null;
            bool t_checked = false;
            foreach(Figure fig in fromInstance.figures)
            {
                 string main_color;
                if (isInside)
                {
                     main_color = fig.FigureColor;
                }
                else
                {
                    main_color = fig.Figure_outColor;
                }

                if (c_color != null && fig is Circle && main_color!= c_color)
                {
                    if (isInside) fromInstance.Circle_Color = null;
                    else fromInstance.Circle_outColor = null;
                    c_color = null;
                    circle_checked = true;
                }
                else if(r_color != null && fig is Figures.Rectangle && main_color != r_color)
                {
                    if (isInside) fromInstance.Rect_Color = null;
                    else fromInstance.Rect_outColor = null;
                    r_color = null;
                    r_checked = true;
                }
                else if(t_color != null && fig is Triangle &&   main_color != t_color)
                {
                    if (isInside) fromInstance.Triangle_Color= null;
                    else fromInstance.Triangle_outColor = null;
                    t_color = null;
                    t_checked = true;
                }
                if(fig is Circle && !circle_checked)
                {
                    c_color = main_color;
                }
                else if(fig is Triangle && !t_checked)
                {
                    t_color = main_color;
                }
                else if( fig is Figures.Rectangle && !r_checked)
                {
                    r_color = main_color;
                }
            }
            if(c_color != null)
            {
                if (isInside) fromInstance.Circle_Color = c_color;
                else fromInstance.Circle_outColor = c_color;
            }
            if(t_color != null)
            {
                if (isInside) fromInstance.Triangle_Color= t_color;
                else fromInstance.Triangle_outColor = t_color;
            }
            if(r_color != null)
            {
                if (isInside) fromInstance.Rect_Color= r_color;
                else fromInstance.Rect_outColor = r_color;
            }
            
        }

        private void load_fromFile_Button_Click(object sender, EventArgs e)
        {
            serializer = new FigureSerializer();
            fromInstance.figures = serializer.LoadFigures();
            Triangle.NextID = fromInstance.figures.Count(n => n is Triangle);
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
            fromInstance.SetToDefault();
            this.Close();
        }
    }
}
