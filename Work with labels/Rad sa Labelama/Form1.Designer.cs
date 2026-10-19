namespace Rad_sa_Labelama
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
            KontrolaLabel = new Label();
            DatumLabel = new Label();
            AutorLabel = new Label();
            label1 = new Label();
            SkrivenaLabela = new Label();
            SuspendLayout();
            // 
            // KontrolaLabel
            // 
            KontrolaLabel.AutoSize = true;
            KontrolaLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KontrolaLabel.Location = new Point(21, 28);
            KontrolaLabel.Name = "KontrolaLabel";
            KontrolaLabel.Size = new Size(261, 47);
            KontrolaLabel.TabIndex = 0;
            KontrolaLabel.Text = "Kontrola Label";
            // 
            // DatumLabel
            // 
            DatumLabel.AutoSize = true;
            DatumLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatumLabel.Location = new Point(31, 98);
            DatumLabel.Name = "DatumLabel";
            DatumLabel.Size = new Size(59, 20);
            DatumLabel.TabIndex = 1;
            DatumLabel.Text = "Datum:";
            // 
            // AutorLabel
            // 
            AutorLabel.AutoSize = true;
            AutorLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AutorLabel.Location = new Point(31, 143);
            AutorLabel.Name = "AutorLabel";
            AutorLabel.Size = new Size(183, 20);
            AutorLabel.TabIndex = 2;
            AutorLabel.Text = "Autor: Mihajlo Stoiljkovic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 194);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 3;
            label1.Text = "www.mojsajt.com";
            label1.Click += label1_Click;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // SkrivenaLabela
            // 
            SkrivenaLabela.AutoSize = true;
            SkrivenaLabela.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SkrivenaLabela.Location = new Point(136, 260);
            SkrivenaLabela.Name = "SkrivenaLabela";
            SkrivenaLabela.Size = new Size(78, 32);
            SkrivenaLabela.TabIndex = 4;
            SkrivenaLabela.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 335);
            Controls.Add(SkrivenaLabela);
            Controls.Add(label1);
            Controls.Add(AutorLabel);
            Controls.Add(DatumLabel);
            Controls.Add(KontrolaLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KontrolaLabel;
        private Label DatumLabel;
        private Label AutorLabel;
        private Label label1;
        private Label SkrivenaLabela;
    }
}
