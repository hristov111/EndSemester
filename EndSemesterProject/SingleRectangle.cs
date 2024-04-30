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
using Figures;

namespace EndSemesterProject
{
    public partial class SingleRectangle : Form
    {
        private Figures.Rectangle Instance;
        private Red_Undo Redo_undo;
        private Figures.Rectangle checking_rect;
        public string Color { get; set; }
        public string Outline { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_rect = new CheckTextbox();
        public SingleRectangle(Red_Undo redo_undo,Figures.Rectangle instance, string color, string outline, int width, int height, int id)
        {
            InitializeComponent();
            this.Instance=instance;
            this.Redo_undo=redo_undo;
            Color=color;
            Outline=outline;
            Height = height;
            Width = width;
            ID = id;
            current_color.Text = Color.ToString();
            current_outline.Text = outline.ToString();
            current_height.Text = Height.ToString();
            current_width.Text = Width.ToString();
            rect_groupbox.Text +=$": {ID}";
            checking_rect = new Figures.Rectangle(Instance.X, Instance.Y,color, outline,width,height,true);
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_rect.ConvertToColor(current_color.Text);
            Instance.Figure_outColor = check_rect.ConvertToColor(current_outline.Text);
            Instance.Height = check_rect.GiveValue(current_height, "Please enter a valid number for rectangle height!\nA default value of 50 is set instead!");
            Instance.Width = check_rect.GiveValue(current_width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
            this.Redo_undo.SetValuesEdit(checking_rect, Instance);
            this.Close();
        }

       
    }
}
