namespace Test_brzine_kucanja
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
            TypeTextBox = new TextBox();
            StartButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // TypeTextBox
            // 
            TypeTextBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TypeTextBox.ForeColor = SystemColors.MenuHighlight;
            TypeTextBox.Location = new Point(23, 83);
            TypeTextBox.Multiline = true;
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(755, 151);
            TypeTextBox.TabIndex = 0;
            TypeTextBox.TextChanged += TypeTextBox_TextChanged;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(335, 240);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(86, 31);
            StartButton.TabIndex = 1;
            StartButton.Text = "Pocni";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 248);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = " Rezultat: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 9);
            label2.MaximumSize = new Size(750, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 248);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 281);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Controls.Add(TypeTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(816, 320);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test brzine kucanja";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ClientSizeChanged += Form1_ClientSizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TypeTextBox;
        private Button StartButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
