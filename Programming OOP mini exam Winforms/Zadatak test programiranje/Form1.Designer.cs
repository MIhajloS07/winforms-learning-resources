namespace Zadatak_test_programiranje
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            BtnIzracunaj = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            pozadinaPanelaBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            PovrsinaCheck = new RadioButton();
            ObimCheck = new RadioButton();
            colorDialog1 = new ColorDialog();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Poluprecnik";
            // 
            // BtnIzracunaj
            // 
            BtnIzracunaj.Location = new Point(81, 137);
            BtnIzracunaj.Name = "BtnIzracunaj";
            BtnIzracunaj.Size = new Size(121, 53);
            BtnIzracunaj.TabIndex = 2;
            BtnIzracunaj.Text = "Izracunaj";
            BtnIzracunaj.UseVisualStyleBackColor = true;
            BtnIzracunaj.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50" });
            comboBox1.Location = new Point(81, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(pozadinaPanelaBtn);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(320, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 167);
            panel1.TabIndex = 6;
            // 
            // pozadinaPanelaBtn
            // 
            pozadinaPanelaBtn.Location = new Point(20, 96);
            pozadinaPanelaBtn.Name = "pozadinaPanelaBtn";
            pozadinaPanelaBtn.Size = new Size(125, 60);
            pozadinaPanelaBtn.TabIndex = 1;
            pozadinaPanelaBtn.Text = "Izaberi pozadinu";
            pozadinaPanelaBtn.UseVisualStyleBackColor = true;
            pozadinaPanelaBtn.Click += pozadinaPanelaBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 28);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 33);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 7;
            label2.Text = "REZULTAT";
            // 
            // PovrsinaCheck
            // 
            PovrsinaCheck.AutoSize = true;
            PovrsinaCheck.Location = new Point(56, 103);
            PovrsinaCheck.Name = "PovrsinaCheck";
            PovrsinaCheck.Size = new Size(70, 19);
            PovrsinaCheck.TabIndex = 8;
            PovrsinaCheck.TabStop = true;
            PovrsinaCheck.Text = "Povrsina";
            PovrsinaCheck.UseVisualStyleBackColor = true;
            // 
            // ObimCheck
            // 
            ObimCheck.AutoSize = true;
            ObimCheck.Location = new Point(161, 103);
            ObimCheck.Name = "ObimCheck";
            ObimCheck.Size = new Size(55, 19);
            ObimCheck.TabIndex = 9;
            ObimCheck.TabStop = true;
            ObimCheck.Text = "Obim";
            ObimCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 10;
            label4.Text = "KRUG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 224);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 83);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-1, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(497, 83);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(-1, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(497, 91);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 252);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ObimCheck);
            Controls.Add(PovrsinaCheck);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(BtnIzracunaj);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "Forma";
            Text = "Krug";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnIzracunaj;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label2;
        private RadioButton PovrsinaCheck;
        private RadioButton ObimCheck;
        private Label label3;
        private Button pozadinaPanelaBtn;
        private ColorDialog colorDialog1;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
    }
}
