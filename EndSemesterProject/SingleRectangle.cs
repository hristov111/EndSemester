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
    public partial class SingleRectangle : Form, ICheckTextbox
    {
        private Rectangle Instance;
        public Color Color { get; set; }
        public Color Outline { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        private int ID { get; set; }
        public SingleRectangle(Rectangle instance, Color color, Color outline, int width, int height, int id)
        {
            InitializeComponent();
            this.Instance=instance;
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

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = ConvertToColor(current_color.Text);
            Instance.Figure_outColor = ConvertToColor(current_outline.Text);
            Instance.Height = GiveValue(current_height, "Please enter a valid number for rectangle height!\nA default value of 50 is set instead!");
            Instance.Width = GiveValue(current_width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
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
