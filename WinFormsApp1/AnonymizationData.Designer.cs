﻿namespace WinFormsApp1
{
    partial class AnonymizationData
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(41, 47);
            button1.Name = "button1";
            button1.Size = new Size(175, 23);
            button1.TabIndex = 0;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 193);
            button2.Name = "button2";
            button2.Size = new Size(175, 23);
            button2.TabIndex = 1;
            button2.Text = "Anonymization";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 88);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 3;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 116);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 4;
            label2.Text = "Select Value for generaated data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 19);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Import data";
            // 
            // AnonymizationData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnonymizationData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}