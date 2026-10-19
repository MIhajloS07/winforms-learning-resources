namespace OOPWinforms_zadatak
{
    partial class AppForm
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
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxGodine = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PrikaziBtn = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(139, 79);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(100, 23);
            textBoxIme.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(139, 131);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(100, 23);
            textBoxPrezime.TabIndex = 1;
            // 
            // textBoxGodine
            // 
            textBoxGodine.Location = new Point(139, 182);
            textBoxGodine.Name = "textBoxGodine";
            textBoxGodine.Size = new Size(100, 23);
            textBoxGodine.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 3;
            label1.Text = "OSOBA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 83);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 134);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Prezime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 185);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Godine";
            // 
            // PrikaziBtn
            // 
            PrikaziBtn.Location = new Point(135, 222);
            PrikaziBtn.Name = "PrikaziBtn";
            PrikaziBtn.Size = new Size(104, 36);
            PrikaziBtn.TabIndex = 7;
            PrikaziBtn.Text = "Kreiraj osobu";
            PrikaziBtn.UseVisualStyleBackColor = true;
            PrikaziBtn.Click += PrikaziBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(260, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(151, 204);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o osobi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 41);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 285);
            Controls.Add(groupBox1);
            Controls.Add(PrikaziBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGodine);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Name = "AppForm";
            Text = "Aplikacija";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private TextBox textBoxGodine;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button PrikaziBtn;
        private GroupBox groupBox1;
        private Label label5;
    }
}
