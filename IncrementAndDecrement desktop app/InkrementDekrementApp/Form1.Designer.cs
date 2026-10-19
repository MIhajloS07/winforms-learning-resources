namespace InkrementDekrementApp
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
            this.IncrementBtn = new System.Windows.Forms.Button();
            this.DecrementBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncrementBtn
            // 
            this.IncrementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncrementBtn.Location = new System.Drawing.Point(36, 210);
            this.IncrementBtn.Name = "IncrementBtn";
            this.IncrementBtn.Padding = new System.Windows.Forms.Padding(1);
            this.IncrementBtn.Size = new System.Drawing.Size(102, 50);
            this.IncrementBtn.TabIndex = 0;
            this.IncrementBtn.Text = "Increment";
            this.IncrementBtn.UseVisualStyleBackColor = true;
            this.IncrementBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecrementBtn
            // 
            this.DecrementBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecrementBtn.Location = new System.Drawing.Point(289, 210);
            this.DecrementBtn.Name = "DecrementBtn";
            this.DecrementBtn.Padding = new System.Windows.Forms.Padding(1);
            this.DecrementBtn.Size = new System.Drawing.Size(102, 50);
            this.DecrementBtn.TabIndex = 3;
            this.DecrementBtn.Text = "Decrement";
            this.DecrementBtn.UseVisualStyleBackColor = true;
            this.DecrementBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(161, 210);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Padding = new System.Windows.Forms.Padding(1);
            this.ResetBtn.Size = new System.Drawing.Size(102, 50);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 318);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecrementBtn);
            this.Controls.Add(this.IncrementBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IncrementBtn;
        private System.Windows.Forms.Button DecrementBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetBtn;
    }
}

