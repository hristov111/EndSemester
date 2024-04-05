namespace EndSemesterProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            create_circle = new Button();
            red = new Button();
            blue = new Button();
            green = new Button();
            yellow = new Button();
            create_Triangle = new Button();
            create_Rectangle = new Button();
            options_button = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // create_circle
            // 
            create_circle.Location = new Point(12, 12);
            create_circle.Name = "create_circle";
            create_circle.Size = new Size(101, 43);
            create_circle.TabIndex = 0;
            create_circle.Text = "Circle";
            create_circle.UseVisualStyleBackColor = true;
            create_circle.Click += create_circle_Click;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.ForeColor = Color.Red;
            red.Location = new Point(12, 76);
            red.Name = "red";
            red.Size = new Size(75, 29);
            red.TabIndex = 1;
            red.Text = "red";
            red.UseVisualStyleBackColor = false;
            red.Click += red_Click;
            // 
            // blue
            // 
            blue.BackColor = Color.Blue;
            blue.ForeColor = Color.Blue;
            blue.Location = new Point(12, 124);
            blue.Name = "blue";
            blue.Size = new Size(75, 29);
            blue.TabIndex = 2;
            blue.Text = "blue";
            blue.UseVisualStyleBackColor = false;
            blue.Click += blue_Click;
            // 
            // green
            // 
            green.BackColor = Color.Green;
            green.ForeColor = Color.Green;
            green.Location = new Point(12, 180);
            green.Name = "green";
            green.Size = new Size(75, 29);
            green.TabIndex = 3;
            green.Text = "green";
            green.UseVisualStyleBackColor = false;
            green.Click += green_Click;
            // 
            // yellow
            // 
            yellow.BackColor = Color.Yellow;
            yellow.ForeColor = Color.Yellow;
            yellow.Location = new Point(12, 225);
            yellow.Name = "yellow";
            yellow.Size = new Size(75, 29);
            yellow.TabIndex = 4;
            yellow.Text = "yellow";
            yellow.UseVisualStyleBackColor = false;
            yellow.Click += yellow_Click;
            // 
            // create_Triangle
            // 
            create_Triangle.Location = new Point(145, 12);
            create_Triangle.Name = "create_Triangle";
            create_Triangle.Size = new Size(101, 43);
            create_Triangle.TabIndex = 5;
            create_Triangle.Text = "Triangle";
            create_Triangle.UseVisualStyleBackColor = true;
            create_Triangle.Click += create_Triangle_Click;
            // 
            // create_Rectangle
            // 
            create_Rectangle.Location = new Point(272, 12);
            create_Rectangle.Name = "create_Rectangle";
            create_Rectangle.Size = new Size(101, 43);
            create_Rectangle.TabIndex = 6;
            create_Rectangle.Text = "Rectangle";
            create_Rectangle.UseVisualStyleBackColor = true;
            create_Rectangle.Click += create_Rectangle_Click;
            // 
            // options_button
            // 
            options_button.BackColor = Color.White;
            options_button.Location = new Point(1284, 12);
            options_button.Name = "options_button";
            options_button.Size = new Size(75, 23);
            options_button.TabIndex = 0;
            options_button.Text = "OPTIONS";
            options_button.UseVisualStyleBackColor = false;
            options_button.Click += options_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Create", "Delete", "Move" });
            comboBox1.Location = new Point(1157, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Create";
            comboBox1.SelectedIndexChanged += comboBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(1113, 16);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "Mode";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1371, 647);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(options_button);
            Controls.Add(create_Rectangle);
            Controls.Add(create_Triangle);
            Controls.Add(yellow);
            Controls.Add(green);
            Controls.Add(blue);
            Controls.Add(red);
            Controls.Add(create_circle);
            Name = "Form1";
            Text = "MyFigures";
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_circle;
        private Button red;
        private Button blue;
        private Button green;
        private Button yellow;
        private Button create_Triangle;
        private Button create_Rectangle;
        private Button options_button;
        private ComboBox comboBox1;
        private Label label1;
    }
}
