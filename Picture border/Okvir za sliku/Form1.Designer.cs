namespace Okvir_za_sliku
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
            MrezaLabel = new Label();
            PrisTacBtn = new Button();
            BezMostBtn = new Button();
            BezRuterBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MrezaLabel
            // 
            MrezaLabel.AutoSize = true;
            MrezaLabel.Location = new Point(12, 22);
            MrezaLabel.Name = "MrezaLabel";
            MrezaLabel.Size = new Size(0, 15);
            MrezaLabel.TabIndex = 0;
            // 
            // PrisTacBtn
            // 
            PrisTacBtn.Location = new Point(23, 52);
            PrisTacBtn.Name = "PrisTacBtn";
            PrisTacBtn.Size = new Size(101, 23);
            PrisTacBtn.TabIndex = 1;
            PrisTacBtn.Text = "Pristupna tacka";
            PrisTacBtn.UseVisualStyleBackColor = true;
            PrisTacBtn.Click += PrisTacBtn_Click;
            // 
            // BezMostBtn
            // 
            BezMostBtn.Location = new Point(23, 81);
            BezMostBtn.Name = "BezMostBtn";
            BezMostBtn.Size = new Size(101, 23);
            BezMostBtn.TabIndex = 2;
            BezMostBtn.Text = "Bezicni most";
            BezMostBtn.UseVisualStyleBackColor = true;
            BezMostBtn.Click += BezMostBtn_Click;
            // 
            // BezRuterBtn
            // 
            BezRuterBtn.Location = new Point(23, 110);
            BezRuterBtn.Name = "BezRuterBtn";
            BezRuterBtn.Size = new Size(101, 23);
            BezRuterBtn.TabIndex = 3;
            BezRuterBtn.Text = "Bezicni ruter";
            BezRuterBtn.UseVisualStyleBackColor = true;
            BezRuterBtn.Click += BezRuterBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(147, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 123);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 201);
            Controls.Add(pictureBox1);
            Controls.Add(BezRuterBtn);
            Controls.Add(BezMostBtn);
            Controls.Add(PrisTacBtn);
            Controls.Add(MrezaLabel);
            Name = "Form1";
            Text = "Kontrola PictureBox";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MrezaLabel;
        private Button PrisTacBtn;
        private Button BezMostBtn;
        private Button BezRuterBtn;
        private PictureBox pictureBox1;
    }
}
