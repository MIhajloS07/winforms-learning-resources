namespace Font_klasa
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
            numericUpDown1 = new NumericUpDown();
            boldBtn = new Button();
            italicBtn = new Button();
            underlineBtn = new Button();
            lblText = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(225, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // boldBtn
            // 
            boldBtn.Location = new Point(66, 58);
            boldBtn.Name = "boldBtn";
            boldBtn.Size = new Size(22, 23);
            boldBtn.TabIndex = 1;
            boldBtn.Text = "B";
            boldBtn.UseVisualStyleBackColor = true;
            boldBtn.Click += boldBtn_Click;
            // 
            // italicBtn
            // 
            italicBtn.Location = new Point(109, 58);
            italicBtn.Name = "italicBtn";
            italicBtn.Size = new Size(22, 23);
            italicBtn.TabIndex = 2;
            italicBtn.Text = "I";
            italicBtn.UseVisualStyleBackColor = true;
            italicBtn.Click += italicBtn_Click;
            // 
            // underlineBtn
            // 
            underlineBtn.Location = new Point(153, 58);
            underlineBtn.Name = "underlineBtn";
            underlineBtn.Size = new Size(22, 23);
            underlineBtn.TabIndex = 3;
            underlineBtn.Text = "U";
            underlineBtn.UseVisualStyleBackColor = true;
            underlineBtn.Click += underlineBtn_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(62, 150);
            lblText.Name = "lblText";
            lblText.Size = new Size(110, 15);
            lblText.TabIndex = 4;
            lblText.Text = "Ovo je tekst u labeli";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 220);
            Controls.Add(lblText);
            Controls.Add(underlineBtn);
            Controls.Add(italicBtn);
            Controls.Add(boldBtn);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button boldBtn;
        private Button italicBtn;
        private Button underlineBtn;
        private Label lblText;
    }
}
