namespace ComboBox_kontrola
{
    partial class Forma
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ImePrezimeTextBox = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            PrijaviSeBtn = new Button();
            PrikazPrijaveTextBox = new TextBox();
            ErrorLabel1 = new Label();
            ErrorLabel2 = new Label();
            ErrorLabel3 = new Label();
            ErrorLabel4 = new Label();
            ErrorLabel5 = new Label();
            ErrorLabel6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(425, 25);
            label1.TabIndex = 0;
            label1.Text = "Prijava na skolsko takmicenje iz programiranja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime i prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 99);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Broj godina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 151);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Razred";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 194);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "Indeks odeljenja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 238);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Skolska godina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 286);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 6;
            label7.Text = "Kategorija";
            // 
            // ImePrezimeTextBox
            // 
            ImePrezimeTextBox.Location = new Point(145, 49);
            ImePrezimeTextBox.Name = "ImePrezimeTextBox";
            ImePrezimeTextBox.Size = new Size(280, 23);
            ImePrezimeTextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "14", "15", "16", "17", "18", "19" });
            comboBox1.Location = new Point(145, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            comboBox2.Location = new Point(145, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox3.Location = new Point(145, 191);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "2025/26", "2024/25", "2023/24" });
            comboBox4.Location = new Point(145, 235);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 11;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "A", "B" });
            comboBox5.Location = new Point(145, 283);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 12;
            // 
            // PrijaviSeBtn
            // 
            PrijaviSeBtn.Location = new Point(379, 235);
            PrijaviSeBtn.Name = "PrijaviSeBtn";
            PrijaviSeBtn.Size = new Size(111, 61);
            PrijaviSeBtn.TabIndex = 13;
            PrijaviSeBtn.Text = "Prijavi se";
            PrijaviSeBtn.UseVisualStyleBackColor = true;
            PrijaviSeBtn.Click += PrijaviSeBtn_Click;
            PrijaviSeBtn.MouseEnter += PrijaviSeBtn_MouseEnter;
            PrijaviSeBtn.MouseLeave += PrijaviSeBtn_MouseLeave;
            // 
            // PrikazPrijaveTextBox
            // 
            PrikazPrijaveTextBox.Location = new Point(33, 331);
            PrikazPrijaveTextBox.Multiline = true;
            PrikazPrijaveTextBox.Name = "PrikazPrijaveTextBox";
            PrikazPrijaveTextBox.ReadOnly = true;
            PrikazPrijaveTextBox.ScrollBars = ScrollBars.Vertical;
            PrikazPrijaveTextBox.Size = new Size(507, 147);
            PrikazPrijaveTextBox.TabIndex = 14;
            // 
            // ErrorLabel1
            // 
            ErrorLabel1.AutoSize = true;
            ErrorLabel1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel1.ForeColor = Color.Red;
            ErrorLabel1.Location = new Point(145, 75);
            ErrorLabel1.Name = "ErrorLabel1";
            ErrorLabel1.Size = new Size(175, 13);
            ErrorLabel1.TabIndex = 15;
            ErrorLabel1.Text = "*Obavezno je uneti ime i prezime";
            // 
            // ErrorLabel2
            // 
            ErrorLabel2.AutoSize = true;
            ErrorLabel2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel2.ForeColor = Color.Red;
            ErrorLabel2.Location = new Point(145, 127);
            ErrorLabel2.Name = "ErrorLabel2";
            ErrorLabel2.Size = new Size(166, 13);
            ErrorLabel2.TabIndex = 16;
            ErrorLabel2.Text = "*Obavezno je uneti broj godina";
            // 
            // ErrorLabel3
            // 
            ErrorLabel3.AutoSize = true;
            ErrorLabel3.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel3.ForeColor = Color.Red;
            ErrorLabel3.Location = new Point(145, 175);
            ErrorLabel3.Name = "ErrorLabel3";
            ErrorLabel3.Size = new Size(138, 13);
            ErrorLabel3.TabIndex = 17;
            ErrorLabel3.Text = "*Obavezno je uneti razred";
            // 
            // ErrorLabel4
            // 
            ErrorLabel4.AutoSize = true;
            ErrorLabel4.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel4.ForeColor = Color.Red;
            ErrorLabel4.Location = new Point(145, 219);
            ErrorLabel4.Name = "ErrorLabel4";
            ErrorLabel4.Size = new Size(189, 13);
            ErrorLabel4.TabIndex = 18;
            ErrorLabel4.Text = "*Obavezno je uneti indeks odeljenja";
            // 
            // ErrorLabel5
            // 
            ErrorLabel5.AutoSize = true;
            ErrorLabel5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel5.ForeColor = Color.Red;
            ErrorLabel5.Location = new Point(145, 267);
            ErrorLabel5.Name = "ErrorLabel5";
            ErrorLabel5.Size = new Size(183, 13);
            ErrorLabel5.TabIndex = 19;
            ErrorLabel5.Text = "*Obavezno je uneti skolsku godinu";
            // 
            // ErrorLabel6
            // 
            ErrorLabel6.AutoSize = true;
            ErrorLabel6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel6.ForeColor = Color.Red;
            ErrorLabel6.Location = new Point(145, 309);
            ErrorLabel6.Name = "ErrorLabel6";
            ErrorLabel6.Size = new Size(158, 13);
            ErrorLabel6.TabIndex = 20;
            ErrorLabel6.Text = "*Obavezno je uneti kategoriju";
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 490);
            Controls.Add(ErrorLabel6);
            Controls.Add(ErrorLabel5);
            Controls.Add(ErrorLabel4);
            Controls.Add(ErrorLabel3);
            Controls.Add(ErrorLabel2);
            Controls.Add(ErrorLabel1);
            Controls.Add(PrikazPrijaveTextBox);
            Controls.Add(PrijaviSeBtn);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(ImePrezimeTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Forma";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ImePrezimeTextBox;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button PrijaviSeBtn;
        private TextBox PrikazPrijaveTextBox;
        private Label ErrorLabel1;
        private Label ErrorLabel2;
        private Label ErrorLabel3;
        private Label ErrorLabel4;
        private Label ErrorLabel5;
        private Label ErrorLabel6;
    }
}
