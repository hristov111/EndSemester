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
    public partial class SingleCircle : Form
    {
        private Circle Instance;
        public Color Color { get; set; }
        public Color Outline { get; set; }
        public int Radius { get; set; }
        private int ID { get; set; }
        private CheckTextbox check_circle = new CheckTextbox();
        public SingleCircle(Circle instance, Color color, Color outline, int radius, int id)
        {
            InitializeComponent();
            this.Instance=instance;
            Color=color;
            Outline=outline;
            Radius=radius;
            ID=id;
            current_color.Text = Color.ToString();
            current_outline.Text = Outline.ToString();
            current_radius.Text = Radius.ToString();
            circle_edit.Text +=$": {ID}";
        }

        private void circle_submit_Click(object sender, EventArgs e)
        {
            Instance.FigureColor = check_circle.ConvertToColor(current_color.Text);
            Instance.Figure_outColor = check_circle.ConvertToColor(current_outline.Text);
            Instance.Radius = check_circle.GiveValue(current_radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!");
            this.Close();
        }
       
    }
}
