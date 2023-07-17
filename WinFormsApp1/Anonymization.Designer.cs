namespace WinFormsApp1
{
    partial class Anonymization
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
            button1 = new Button();
            textBoxGender = new TextBox();
            textBoxAge = new TextBox();
            textBoxZip = new TextBox();
            textBoxColour = new TextBox();
            textBoxSalary = new TextBox();
            label1 = new Label();
            textBoxAn = new TextBox();
            buttonA = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxQ = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1014, 564);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxGender
            // 
            textBoxGender.Location = new Point(12, 44);
            textBoxGender.Multiline = true;
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(152, 532);
            textBoxGender.TabIndex = 1;
            textBoxGender.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(182, 44);
            textBoxAge.Multiline = true;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(152, 532);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxZip
            // 
            textBoxZip.Location = new Point(350, 44);
            textBoxZip.Multiline = true;
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(152, 532);
            textBoxZip.TabIndex = 3;
            // 
            // textBoxColour
            // 
            textBoxColour.Location = new Point(518, 44);
            textBoxColour.Multiline = true;
            textBoxColour.Name = "textBoxColour";
            textBoxColour.Size = new Size(152, 532);
            textBoxColour.TabIndex = 4;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(687, 44);
            textBoxSalary.Multiline = true;
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(152, 532);
            textBoxSalary.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Gender";
            // 
            // textBoxAn
            // 
            textBoxAn.Location = new Point(928, 191);
            textBoxAn.Name = "textBoxAn";
            textBoxAn.Size = new Size(159, 23);
            textBoxAn.TabIndex = 7;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(928, 295);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(159, 23);
            buttonA.TabIndex = 8;
            buttonA.Text = "Anonymization";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Colour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 9);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 10;
            label3.Text = "Zip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 9);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(928, 163);
            label5.Name = "label5";
            label5.Size = new Size(159, 15);
            label5.TabIndex = 12;
            label5.Text = "Insert level of anonymization";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(687, 9);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(928, 233);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 14;
            label7.Text = "Insert quasi identifiers";
            // 
            // textBoxQ
            // 
            textBoxQ.Location = new Point(928, 251);
            textBoxQ.Name = "textBoxQ";
            textBoxQ.Size = new Size(159, 23);
            textBoxQ.TabIndex = 15;
            // 
            // Anonymization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 599);
            Controls.Add(textBoxQ);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonA);
            Controls.Add(textBoxAn);
            Controls.Add(label1);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxColour);
            Controls.Add(textBoxZip);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxGender);
            Controls.Add(button1);
            Name = "Anonymization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anonymization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxGender;
        private TextBox textBoxAge;
        private TextBox textBoxZip;
        private TextBox textBoxColour;
        private TextBox textBoxSalary;
        private Label label1;
        private TextBox textBoxAn;
        private Button buttonA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxQ;
    }
}