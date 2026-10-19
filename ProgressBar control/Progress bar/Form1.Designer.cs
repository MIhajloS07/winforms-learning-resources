namespace Progress_bar
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            StartBtn = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Chartreuse;
            progressBar1.ForeColor = Color.PaleTurquoise;
            progressBar1.Location = new Point(-1, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.Size = new Size(801, 23);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(292, 177);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(159, 74);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(StartBtn);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button StartBtn;
    }
}
