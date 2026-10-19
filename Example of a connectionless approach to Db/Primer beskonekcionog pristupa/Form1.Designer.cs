namespace Primer_beskonekcionog_pristupa
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PrikaziIzBazeBtn = new System.Windows.Forms.Button();
            this.IzlazBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 498);
            this.listBox1.TabIndex = 0;
            // 
            // PrikaziIzBazeBtn
            // 
            this.PrikaziIzBazeBtn.Location = new System.Drawing.Point(12, 551);
            this.PrikaziIzBazeBtn.Name = "PrikaziIzBazeBtn";
            this.PrikaziIzBazeBtn.Size = new System.Drawing.Size(124, 36);
            this.PrikaziIzBazeBtn.TabIndex = 1;
            this.PrikaziIzBazeBtn.Text = "Prikazi";
            this.PrikaziIzBazeBtn.UseVisualStyleBackColor = true;
            this.PrikaziIzBazeBtn.Click += new System.EventHandler(this.PrikaziIzBazeBtn_Click);
            // 
            // IzlazBtn
            // 
            this.IzlazBtn.Location = new System.Drawing.Point(202, 551);
            this.IzlazBtn.Name = "IzlazBtn";
            this.IzlazBtn.Size = new System.Drawing.Size(124, 36);
            this.IzlazBtn.TabIndex = 2;
            this.IzlazBtn.Text = "Izlaz";
            this.IzlazBtn.UseVisualStyleBackColor = true;
            this.IzlazBtn.Click += new System.EventHandler(this.IzlazBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 599);
            this.Controls.Add(this.IzlazBtn);
            this.Controls.Add(this.PrikaziIzBazeBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PrikaziIzBazeBtn;
        private System.Windows.Forms.Button IzlazBtn;
    }
}

