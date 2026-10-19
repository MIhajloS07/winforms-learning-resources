namespace Primer_konekcionog_pristupa_MSSQL
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
            this.listBoxBaza = new System.Windows.Forms.ListBox();
            this.IspisiIzBaze = new System.Windows.Forms.Button();
            this.IzlazBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBaza
            // 
            this.listBoxBaza.FormattingEnabled = true;
            this.listBoxBaza.Location = new System.Drawing.Point(12, 5);
            this.listBoxBaza.Name = "listBoxBaza";
            this.listBoxBaza.Size = new System.Drawing.Size(319, 459);
            this.listBoxBaza.TabIndex = 0;
            // 
            // IspisiIzBaze
            // 
            this.IspisiIzBaze.Location = new System.Drawing.Point(29, 495);
            this.IspisiIzBaze.Name = "IspisiIzBaze";
            this.IspisiIzBaze.Size = new System.Drawing.Size(148, 43);
            this.IspisiIzBaze.TabIndex = 1;
            this.IspisiIzBaze.Text = "Ispisi podatke";
            this.IspisiIzBaze.UseVisualStyleBackColor = true;
            this.IspisiIzBaze.Click += new System.EventHandler(this.IspisiIzBaze_Click);
            // 
            // IzlazBtn
            // 
            this.IzlazBtn.Location = new System.Drawing.Point(240, 510);
            this.IzlazBtn.Name = "IzlazBtn";
            this.IzlazBtn.Size = new System.Drawing.Size(91, 27);
            this.IzlazBtn.TabIndex = 2;
            this.IzlazBtn.Text = "Izlaz";
            this.IzlazBtn.UseVisualStyleBackColor = true;
            this.IzlazBtn.Click += new System.EventHandler(this.IzlazBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 549);
            this.Controls.Add(this.IzlazBtn);
            this.Controls.Add(this.IspisiIzBaze);
            this.Controls.Add(this.listBoxBaza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBaza;
        private System.Windows.Forms.Button IspisiIzBaze;
        private System.Windows.Forms.Button IzlazBtn;
    }
}

