namespace EndSemesterProject
{
    partial class SingleRectangle
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
            rect_groupbox = new GroupBox();
            groupBox2 = new GroupBox();
            submit_button = new Button();
            current_width = new TextBox();
            current_height = new TextBox();
            current_outline = new TextBox();
            label5 = new Label();
            label4 = new Label();
            current_color = new TextBox();
            label3 = new Label();
            label1 = new Label();
            rect_groupbox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rect_groupbox
            // 
            rect_groupbox.Controls.Add(groupBox2);
            rect_groupbox.Controls.Add(current_width);
            rect_groupbox.Controls.Add(current_height);
            rect_groupbox.Controls.Add(current_outline);
            rect_groupbox.Controls.Add(label5);
            rect_groupbox.Controls.Add(label4);
            rect_groupbox.Controls.Add(current_color);
            rect_groupbox.Controls.Add(label3);
            rect_groupbox.Controls.Add(label1);
            rect_groupbox.Location = new Point(43, 52);
            rect_groupbox.Name = "rect_groupbox";
            rect_groupbox.Size = new Size(1209, 751);
            rect_groupbox.TabIndex = 0;
            rect_groupbox.TabStop = false;
            rect_groupbox.Text = "Rectangle Edit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(submit_button);
            groupBox2.Location = new Point(98, 505);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 197);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // submit_button
            // 
            submit_button.Location = new Point(178, 38);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(698, 132);
            submit_button.TabIndex = 0;
            submit_button.Text = "Submit Changes";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_button_Click;
            // 
            // current_width
            // 
            current_width.Location = new Point(854, 103);
            current_width.Name = "current_width";
            current_width.Size = new Size(200, 39);
            current_width.TabIndex = 1;
            // 
            // current_height
            // 
            current_height.Location = new Point(258, 424);
            current_height.Name = "current_height";
            current_height.Size = new Size(200, 39);
            current_height.TabIndex = 1;
            // 
            // current_outline
            // 
            current_outline.Location = new Point(258, 241);
            current_outline.Name = "current_outline";
            current_outline.Size = new Size(200, 39);
            current_outline.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 103);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 0;
            label5.Text = "Current Width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 424);
            label4.Name = "label4";
            label4.Size = new Size(173, 32);
            label4.TabIndex = 0;
            label4.Text = "Current Height";
            // 
            // current_color
            // 
            current_color.Location = new Point(276, 96);
            current_color.Name = "current_color";
            current_color.Size = new Size(200, 39);
            current_color.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 251);
            label3.Name = "label3";
            label3.Size = new Size(176, 32);
            label3.TabIndex = 0;
            label3.Text = "Current outline";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 103);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Current color";
            // 
            // SingleRectangle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 842);
            Controls.Add(rect_groupbox);
            Name = "SingleRectangle";
            Text = "Rectangle";
            rect_groupbox.ResumeLayout(false);
            rect_groupbox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox rect_groupbox;
        private TextBox current_width;
        private TextBox current_height;
        private TextBox current_outline;
        private Label label5;
        private Label label4;
        private TextBox current_color;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private Button submit_button;
    }
}