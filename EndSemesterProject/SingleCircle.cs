﻿using System;
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
    public partial class SingleCircle : Form
    {
        private Form1 Instance_form;
        private Circle Instance;
        private Red_Undo Redo_undo;
        private Circle checking_circle;
        public string Color { get; set; }
        public string Outline { get; set; }
        public int Radius { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_circle = new CheckTextbox();
        public string Color_inside = null;
        public string Color_outside = null;
        public SingleCircle(Form1 instance_form, Red_Undo redo_undo, Circle instance, string color, string outline, int radius, int id)
        {
            InitializeComponent();
            Instance_form = instance_form;
            this.Redo_undo = redo_undo;
            this.Instance=instance;
            Color=color;
            Outline=outline;
            Radius=radius;
            ID=id;

            current_color.Text = Color.ToString();
            Color_inside = current_color.Text;

            current_outline.Text = Outline.ToString();
            Color_outside = current_outline.Text;

            current_radius.Text = Radius.ToString();
            circle_edit.Text +=$": {ID}";
            checking_circle = new Circle(Instance.X, Instance.Y, Color, Outline, Radius, true);
        }

        private void circle_submit_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_circle.ConvertToColor(current_color.Text);
            Instance.Figure_outColor = check_circle.ConvertToColor(current_outline.Text);
            if (Instance.FigureColor != "black" && Instance.FigureColor != Color_inside)
            {
                Instance_form.Circle_Color = null;
            }
            if(Instance.FigureColor != Color_outside)
            {
                Instance_form.Circle_outColor = null;
            }
            if (Instance.FigureColor.Equals("black"))
            {
                Instance.FigureColor = Color_inside;
            }
            Instance.Radius = check_circle.GiveValue(current_radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!");
            Redo_undo.SetValuesEdit(checking_circle, Instance);
            this.Close();
        }
       
    }
}
