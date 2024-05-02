namespace EndSemesterProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectangle_Width = new TextBox();
            label4 = new Label();
            label5 = new Label();
            rectangle_Height = new TextBox();
            circle_Radius = new TextBox();
            triangle_Side1 = new TextBox();
            triangle_Side2 = new TextBox();
            triangle_Side3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            triangle_outColor = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            rectangle_outColor = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            circle_outColor = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox4 = new GroupBox();
            save_toFile_Button = new Button();
            load_fromFile_Button = new Button();
            label13 = new Label();
            default_button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // rectangle_Width
            // 
            rectangle_Width.Location = new Point(100, 37);
            rectangle_Width.Name = "rectangle_Width";
            rectangle_Width.Size = new Size(100, 23);
            rectangle_Width.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 40);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 95);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "Height";
            // 
            // rectangle_Height
            // 
            rectangle_Height.Location = new Point(100, 95);
            rectangle_Height.Name = "rectangle_Height";
            rectangle_Height.Size = new Size(100, 23);
            rectangle_Height.TabIndex = 1;
            // 
            // circle_Radius
            // 
            circle_Radius.Location = new Point(88, 66);
            circle_Radius.Name = "circle_Radius";
            circle_Radius.Size = new Size(100, 23);
            circle_Radius.TabIndex = 1;
            // 
            // triangle_Side1
            // 
            triangle_Side1.Location = new Point(87, 22);
            triangle_Side1.Name = "triangle_Side1";
            triangle_Side1.Size = new Size(100, 23);
            triangle_Side1.TabIndex = 1;
            // 
            // triangle_Side2
            // 
            triangle_Side2.Location = new Point(87, 79);
            triangle_Side2.Name = "triangle_Side2";
            triangle_Side2.Size = new Size(100, 23);
            triangle_Side2.TabIndex = 1;
            // 
            // triangle_Side3
            // 
            triangle_Side3.Location = new Point(87, 134);
            triangle_Side3.Name = "triangle_Side3";
            triangle_Side3.Size = new Size(100, 23);
            triangle_Side3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 30);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 0;
            label6.Text = "Side1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 87);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 0;
            label7.Text = "Side2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 142);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 0;
            label8.Text = "Side3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 69);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "Radius";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(triangle_Side1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(triangle_Side2);
            groupBox1.Controls.Add(triangle_outColor);
            groupBox1.Controls.Add(triangle_Side3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(249, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 229);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangle";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 206);
            label11.Name = "label11";
            label11.Size = new Size(158, 15);
            label11.TabIndex = 2;
            label11.Text = "*ONLY red blue green yellow";
            // 
            // triangle_outColor
            // 
            triangle_outColor.Location = new Point(87, 177);
            triangle_outColor.Name = "triangle_outColor";
            triangle_outColor.Size = new Size(100, 23);
            triangle_outColor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 177);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Outline color";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(rectangle_Width);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(rectangle_outColor);
            groupBox2.Controls.Add(rectangle_Height);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(8, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 229);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangle";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 206);
            label12.Name = "label12";
            label12.Size = new Size(158, 15);
            label12.TabIndex = 2;
            label12.Text = "*ONLY red blue green yellow";
            // 
            // rectangle_outColor
            // 
            rectangle_outColor.Location = new Point(100, 155);
            rectangle_outColor.Name = "rectangle_outColor";
            rectangle_outColor.Size = new Size(100, 23);
            rectangle_outColor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 155);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Outline color";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(circle_outColor);
            groupBox3.Controls.Add(circle_Radius);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(549, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 229);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Circle";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 206);
            label10.Name = "label10";
            label10.Size = new Size(158, 15);
            label10.TabIndex = 2;
            label10.Text = "*ONLY red blue green yellow";
            // 
            // circle_outColor
            // 
            circle_outColor.Location = new Point(88, 147);
            circle_outColor.Name = "circle_outColor";
            circle_outColor.Size = new Size(100, 23);
            circle_outColor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Outline color";
            // 
            // button1
            // 
            button1.Location = new Point(98, 62);
            button1.Name = "button1";
            button1.Size = new Size(549, 72);
            button1.TabIndex = 2;
            button1.Text = "Submit Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(default_button);
            groupBox4.Controls.Add(save_toFile_Button);
            groupBox4.Controls.Add(load_fromFile_Button);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(25, 258);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(739, 180);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // save_toFile_Button
            // 
            save_toFile_Button.Location = new Point(570, 141);
            save_toFile_Button.Margin = new Padding(2, 1, 2, 1);
            save_toFile_Button.Name = "save_toFile_Button";
            save_toFile_Button.Size = new Size(160, 35);
            save_toFile_Button.TabIndex = 4;
            save_toFile_Button.Text = "Save to File";
            save_toFile_Button.UseVisualStyleBackColor = true;
            save_toFile_Button.Click += save_toFile_Button_Click;
            // 
            // load_fromFile_Button
            // 
            load_fromFile_Button.Location = new Point(8, 141);
            load_fromFile_Button.Margin = new Padding(2, 1, 2, 1);
            load_fromFile_Button.Name = "load_fromFile_Button";
            load_fromFile_Button.Size = new Size(160, 35);
            load_fromFile_Button.TabIndex = 3;
            load_fromFile_Button.Text = "Load from File";
            load_fromFile_Button.UseVisualStyleBackColor = true;
            load_fromFile_Button.Click += load_fromFile_Button_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(224, 29);
            label13.Name = "label13";
            label13.Size = new Size(264, 15);
            label13.TabIndex = 0;
            label13.Text = "*Click \"Set default\" to set all properties to default";
            // 
            // default_button
            // 
            default_button.Location = new Point(8, 25);
            default_button.Name = "default_button";
            default_button.Size = new Size(75, 23);
            default_button.TabIndex = 5;
            default_button.Text = "Set default";
            default_button.UseVisualStyleBackColor = true;
            default_button.Click += default_button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Options";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox rectangle_Width;
        private Label label4;
        private Label label5;
        private TextBox rectangle_Height;
        private TextBox circle_Radius;
        private TextBox triangle_Side1;
        private TextBox triangle_Side2;
        private TextBox triangle_Side3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private GroupBox groupBox4;
        private TextBox rectangle_outColor;
        private Label label1;
        private TextBox triangle_outColor;
        private Label label2;
        private TextBox circle_outColor;
        private Label label3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button load_fromFile_Button;
        private Button save_toFile_Button;
        private Label label13;
        private Button default_button;
    }
}