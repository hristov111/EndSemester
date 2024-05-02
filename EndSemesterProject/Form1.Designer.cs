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
            clear_button = new Button();
            red = new Color_Button();
            blue = new Color_Button();
            green = new Color_Button();
            yellow = new Color_Button();
            undo_button = new Button();
            redo_button = new Button();
            mode1 = new Label();
            stop_Alive_button = new Button();
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
            comboBox1.Items.AddRange(new object[] { "Create", "Delete", "Move", "Edit", "Alive" });
            comboBox1.Location = new Point(1157, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Create";
            comboBox1.SelectedIndexChanged += comboBox_TextChanged;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(1293, 39);
            clear_button.Margin = new Padding(2, 1, 2, 1);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(66, 25);
            clear_button.TabIndex = 9;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.Location = new Point(12, 75);
            red.Margin = new Padding(2, 1, 2, 1);
            red.Name = "red";
            red.Size = new Size(81, 22);
            red.TabIndex = 10;
            red.UseVisualStyleBackColor = false;
            // 
            // blue
            // 
            blue.BackColor = Color.Blue;
            blue.Location = new Point(12, 112);
            blue.Margin = new Padding(2, 1, 2, 1);
            blue.Name = "blue";
            blue.Size = new Size(81, 22);
            blue.TabIndex = 10;
            blue.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            green.BackColor = Color.Green;
            green.Location = new Point(12, 150);
            green.Margin = new Padding(2, 1, 2, 1);
            green.Name = "green";
            green.Size = new Size(81, 22);
            green.TabIndex = 10;
            green.UseVisualStyleBackColor = false;
            // 
            // yellow
            // 
            yellow.BackColor = Color.Yellow;
            yellow.Location = new Point(12, 188);
            yellow.Margin = new Padding(2, 1, 2, 1);
            yellow.Name = "yellow";
            yellow.Size = new Size(81, 22);
            yellow.TabIndex = 10;
            yellow.UseVisualStyleBackColor = false;
            // 
            // undo_button
            // 
            undo_button.Location = new Point(645, 13);
            undo_button.Margin = new Padding(2, 1, 2, 1);
            undo_button.Name = "undo_button";
            undo_button.Size = new Size(81, 22);
            undo_button.TabIndex = 11;
            undo_button.Text = "Undo";
            undo_button.UseVisualStyleBackColor = true;
            undo_button.Click += undo_button_Click;
            // 
            // redo_button
            // 
            redo_button.Location = new Point(742, 14);
            redo_button.Margin = new Padding(2, 1, 2, 1);
            redo_button.Name = "redo_button";
            redo_button.Size = new Size(81, 22);
            redo_button.TabIndex = 11;
            redo_button.Text = "Redo";
            redo_button.UseVisualStyleBackColor = true;
            redo_button.Click += redo_button_Click;
            // 
            // mode1
            // 
            mode1.AutoSize = true;
            mode1.BackColor = Color.White;
            mode1.Location = new Point(1110, 16);
            mode1.Margin = new Padding(2, 0, 2, 0);
            mode1.Name = "mode1";
            mode1.Size = new Size(38, 15);
            mode1.TabIndex = 12;
            mode1.Text = "Mode";
            // 
            // stop_Alive_button
            // 
            stop_Alive_button.Location = new Point(12, 236);
            stop_Alive_button.Name = "stop_Alive_button";
            stop_Alive_button.Size = new Size(75, 23);
            stop_Alive_button.TabIndex = 13;
            stop_Alive_button.Text = "Stop";
            stop_Alive_button.UseVisualStyleBackColor = true;
            stop_Alive_button.Visible = false;
            stop_Alive_button.Click += stop_Alive_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1371, 616);
            Controls.Add(stop_Alive_button);
            Controls.Add(mode1);
            Controls.Add(redo_button);
            Controls.Add(undo_button);
            Controls.Add(yellow);
            Controls.Add(green);
            Controls.Add(blue);
            Controls.Add(red);
            Controls.Add(clear_button);
            Controls.Add(comboBox1);
            Controls.Add(options_button);
            Controls.Add(create_Rectangle);
            Controls.Add(create_Triangle);
            Controls.Add(create_circle);
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

        public Button create_circle;
        public Button create_Triangle;
        public Button create_Rectangle;
        private Button options_button;
        private ComboBox comboBox1;
        private Button clear_button;
        private Color_Button red;
        private Color_Button blue;
        private Color_Button green;
        private Color_Button yellow;
        private Button undo_button;
        private Button redo_button;
        private Label mode1;
        private Button stop_Alive_button;
    }
}
