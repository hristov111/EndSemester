namespace EndSemesterProject
{
    partial class SingleCircle
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
            circle_edit = new GroupBox();
            groupBox1 = new GroupBox();
            circle_submit = new Button();
            current_outline = new TextBox();
            current_radius = new TextBox();
            current_color = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            circle_edit.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // circle_edit
            // 
            circle_edit.Controls.Add(groupBox1);
            circle_edit.Controls.Add(current_outline);
            circle_edit.Controls.Add(current_radius);
            circle_edit.Controls.Add(current_color);
            circle_edit.Controls.Add(label2);
            circle_edit.Controls.Add(label3);
            circle_edit.Controls.Add(label1);
            circle_edit.Location = new Point(46, 52);
            circle_edit.Name = "circle_edit";
            circle_edit.Size = new Size(1209, 707);
            circle_edit.TabIndex = 0;
            circle_edit.TabStop = false;
            circle_edit.Text = "Circle Edit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(circle_submit);
            groupBox1.Location = new Point(64, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1069, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // circle_submit
            // 
            circle_submit.Location = new Point(173, 38);
            circle_submit.Name = "circle_submit";
            circle_submit.Size = new Size(698, 132);
            circle_submit.TabIndex = 0;
            circle_submit.Text = "Submit Changes";
            circle_submit.UseVisualStyleBackColor = true;
            circle_submit.Click += circle_submit_Click;
            // 
            // current_outline
            // 
            current_outline.Location = new Point(276, 281);
            current_outline.Name = "current_outline";
            current_outline.Size = new Size(200, 39);
            current_outline.TabIndex = 1;
            // 
            // current_radius
            // 
            current_radius.Location = new Point(896, 93);
            current_radius.Name = "current_radius";
            current_radius.Size = new Size(200, 39);
            current_radius.TabIndex = 1;
            // 
            // current_color
            // 
            current_color.Location = new Point(276, 93);
            current_color.Name = "current_color";
            current_color.Size = new Size(200, 39);
            current_color.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 281);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 0;
            label2.Text = "Current outline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 100);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 0;
            label3.Text = "Current radius";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 93);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Current color";
            // 
            // SingleCircle
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 842);
            Controls.Add(circle_edit);
            Name = "SingleCircle";
            Text = "Circle";
            circle_edit.ResumeLayout(false);
            circle_edit.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox circle_edit;
        private TextBox current_outline;
        private TextBox current_color;
        private Label label1;
        private TextBox current_radius;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button circle_submit;
    }
}