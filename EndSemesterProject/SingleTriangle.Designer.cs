namespace EndSemesterProject
{
    partial class SingleTriangle
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
            triangle_groupBox = new GroupBox();
            groupBox2 = new GroupBox();
            triangle_button = new Button();
            third_side = new TextBox();
            second_side = new TextBox();
            first_side = new TextBox();
            current_outline = new TextBox();
            current_color = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            triangle_groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // triangle_groupBox
            // 
            triangle_groupBox.Controls.Add(groupBox2);
            triangle_groupBox.Controls.Add(third_side);
            triangle_groupBox.Controls.Add(second_side);
            triangle_groupBox.Controls.Add(first_side);
            triangle_groupBox.Controls.Add(current_outline);
            triangle_groupBox.Controls.Add(current_color);
            triangle_groupBox.Controls.Add(label5);
            triangle_groupBox.Controls.Add(label4);
            triangle_groupBox.Controls.Add(label3);
            triangle_groupBox.Controls.Add(label2);
            triangle_groupBox.Controls.Add(label1);
            triangle_groupBox.Location = new Point(46, 37);
            triangle_groupBox.Name = "triangle_groupBox";
            triangle_groupBox.Size = new Size(1209, 707);
            triangle_groupBox.TabIndex = 0;
            triangle_groupBox.TabStop = false;
            triangle_groupBox.Text = "Triangle Edit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(triangle_button);
            groupBox2.Location = new Point(55, 460);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 197);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // triangle_button
            // 
            triangle_button.Location = new Point(189, 38);
            triangle_button.Name = "triangle_button";
            triangle_button.Size = new Size(698, 132);
            triangle_button.TabIndex = 0;
            triangle_button.Text = "Submit Changes";
            triangle_button.UseVisualStyleBackColor = true;
            triangle_button.Click += triangle_button_Click;
            // 
            // third_side
            // 
            third_side.Location = new Point(902, 222);
            third_side.Name = "third_side";
            third_side.Size = new Size(180, 39);
            third_side.TabIndex = 1;
            // 
            // second_side
            // 
            second_side.Location = new Point(902, 92);
            second_side.Name = "second_side";
            second_side.Size = new Size(180, 39);
            second_side.TabIndex = 1;
            // 
            // first_side
            // 
            first_side.Location = new Point(287, 347);
            first_side.Name = "first_side";
            first_side.Size = new Size(180, 39);
            first_side.TabIndex = 1;
            // 
            // current_outline
            // 
            current_outline.Location = new Point(287, 218);
            current_outline.Name = "current_outline";
            current_outline.Size = new Size(180, 39);
            current_outline.TabIndex = 1;
            // 
            // current_color
            // 
            current_color.Location = new Point(287, 99);
            current_color.Name = "current_color";
            current_color.Size = new Size(180, 39);
            current_color.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 229);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 0;
            label5.Text = "Size of Third Side";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 99);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 0;
            label4.Text = "Size of Second Side";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 350);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 0;
            label3.Text = "Size of First Side";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 225);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 0;
            label2.Text = "Current outline";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 99);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Current color";
            // 
            // SingleTriangle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 842);
            Controls.Add(triangle_groupBox);
            Name = "SingleTriangle";
            Text = "Triangle";
            triangle_groupBox.ResumeLayout(false);
            triangle_groupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox triangle_groupBox;
        private TextBox current_color;
        private Label label1;
        private TextBox current_outline;
        private TextBox third_side;
        private TextBox second_side;
        private TextBox first_side;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button triangle_button;
    }
}