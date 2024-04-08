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
            create_Triangle = new Button();
            create_Rectangle = new Button();
            options_button = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            clear_button = new Button();
            red = new Color_Button();
            blue = new Color_Button();
            green = new Color_Button();
            yellow = new Color_Button();
            undo_button = new Button();
            redo_button = new Button();
            SuspendLayout();
            // 
            // create_circle
            // 
            create_circle.Location = new Point(22, 26);
            create_circle.Margin = new Padding(6);
            create_circle.Name = "create_circle";
            create_circle.Size = new Size(188, 92);
            create_circle.TabIndex = 0;
            create_circle.Text = "Circle";
            create_circle.UseVisualStyleBackColor = true;
            create_circle.Click += create_circle_Click;
            // 
            // create_Triangle
            // 
            create_Triangle.Location = new Point(269, 26);
            create_Triangle.Margin = new Padding(6);
            create_Triangle.Name = "create_Triangle";
            create_Triangle.Size = new Size(188, 92);
            create_Triangle.TabIndex = 5;
            create_Triangle.Text = "Triangle";
            create_Triangle.UseVisualStyleBackColor = true;
            create_Triangle.Click += create_Triangle_Click;
            // 
            // create_Rectangle
            // 
            create_Rectangle.Location = new Point(505, 26);
            create_Rectangle.Margin = new Padding(6);
            create_Rectangle.Name = "create_Rectangle";
            create_Rectangle.Size = new Size(188, 92);
            create_Rectangle.TabIndex = 6;
            create_Rectangle.Text = "Rectangle";
            create_Rectangle.UseVisualStyleBackColor = true;
            create_Rectangle.Click += create_Rectangle_Click;
            // 
            // options_button
            // 
            options_button.BackColor = Color.White;
            options_button.Location = new Point(2385, 26);
            options_button.Margin = new Padding(6);
            options_button.Name = "options_button";
            options_button.Size = new Size(139, 49);
            options_button.TabIndex = 0;
            options_button.Text = "OPTIONS";
            options_button.UseVisualStyleBackColor = false;
            options_button.Click += options_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Create", "Delete", "Move", "Edit" });
            comboBox1.Location = new Point(2149, 28);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 40);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Create";
            comboBox1.SelectedIndexChanged += comboBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(2067, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 8;
            label1.Text = "Mode";
            // 
            // clear_button
            // 
            clear_button.Location = new Point(2402, 84);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(122, 54);
            clear_button.TabIndex = 9;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.Location = new Point(22, 160);
            red.Name = "red";
            red.Size = new Size(150, 46);
            red.TabIndex = 10;
            red.UseVisualStyleBackColor = false;
            // 
            // blue
            // 
            blue.BackColor = Color.Blue;
            blue.Location = new Point(22, 240);
            blue.Name = "blue";
            blue.Size = new Size(150, 46);
            blue.TabIndex = 10;
            blue.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            green.BackColor = Color.Green;
            green.Location = new Point(22, 320);
            green.Name = "green";
            green.Size = new Size(150, 46);
            green.TabIndex = 10;
            green.UseVisualStyleBackColor = false;
            // 
            // yellow
            // 
            yellow.BackColor = Color.Yellow;
            yellow.Location = new Point(22, 400);
            yellow.Name = "yellow";
            yellow.Size = new Size(150, 46);
            yellow.TabIndex = 10;
            yellow.UseVisualStyleBackColor = false;
            // 
            // undo_button
            // 
            undo_button.Location = new Point(1197, 28);
            undo_button.Name = "undo_button";
            undo_button.Size = new Size(150, 46);
            undo_button.TabIndex = 11;
            undo_button.Text = "Undo";
            undo_button.UseVisualStyleBackColor = true;
            undo_button.Click += undo_button_Click;
            // 
            // redo_button
            // 
            redo_button.Location = new Point(1378, 29);
            redo_button.Name = "redo_button";
            redo_button.Size = new Size(150, 46);
            redo_button.TabIndex = 11;
            redo_button.Text = "Redo";
            redo_button.UseVisualStyleBackColor = true;
            redo_button.Click += redo_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2546, 1380);
            Controls.Add(redo_button);
            Controls.Add(undo_button);
            Controls.Add(yellow);
            Controls.Add(green);
            Controls.Add(blue);
            Controls.Add(red);
            Controls.Add(clear_button);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(options_button);
            Controls.Add(create_Rectangle);
            Controls.Add(create_Triangle);
            Controls.Add(create_circle);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "MyFigures";
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_DoubleClick;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_circle;
        private Button create_Triangle;
        private Button create_Rectangle;
        private Button options_button;
        private ComboBox comboBox1;
        private Label label1;
        private Button clear_button;
        private Color_Button red;
        private Color_Button blue;
        private Color_Button green;
        private Color_Button yellow;
        private Button undo_button;
        private Button redo_button;
    }
}
