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

namespace EndSemesterProject
{
    public partial class Form2 : Form
    {
        private Form1 fromInstance;
        private CheckTextbox textbox = new CheckTextbox();
        public JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,
            Converters = { new FigureConverter(), new ColorConverter() }
        };

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.fromInstance = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromInstance.Rect_Width = textbox.GiveValue(rectangle_Width, "Please enter a valid number for rectangle width!\nA default value of 50 is set instead!");
            fromInstance.Rect_Height = textbox.GiveValue(rectangle_Height, "Please enter a valid number for rectangle helight!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side1 = textbox.GiveValue(triangle_Side1, "Please enter a valid number for triangle side1!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side2 = textbox.GiveValue(triangle_Side2, "Please enter a valid number for triangle side2!\nA default value of 50 is set instead!");
            fromInstance.Triangle_Side3 = textbox.GiveValue(triangle_Side3, "Please enter a valid number for triangle side3!\nA default value of 50 is set instead!");
            fromInstance.Circle_Radius = textbox.GiveValue(circle_Radius, "Please enter a valid number for circle radius!\nA default value of 50 is set instead!");
            fromInstance.Rect_outColor = textbox.ConvertToColor(rectangle_outColor.Text);
            fromInstance.Triangle_outColor = textbox.ConvertToColor(triangle_outColor.Text);
            fromInstance.Circle_outColor = textbox.ConvertToColor(circle_outColor.Text);
            this.Close();
        }

        private void load_fromFile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFileDialog = new OpenFileDialog();
            newFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            if (newFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = newFileDialog.FileName;
                try
                {

                    string jsonString = File.ReadAllText(filepath);
                    List<Figure> figs = JsonSerializer.Deserialize<List<Figure>>(jsonString, options);
                    foreach (Figure f in figs)
                    {
                        fromInstance.figures.Add(f);
                    }
                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occured while reading the file {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void save_toFile_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "MyFigures.txt";
            saveFileDialog.Filter = "Text Documents (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                try
                {
                    string jsonString = JsonSerializer.Serialize(fromInstance.figures, options);
                    File.WriteAllText(filepath, jsonString);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occured while saving the file: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }


    }
}
