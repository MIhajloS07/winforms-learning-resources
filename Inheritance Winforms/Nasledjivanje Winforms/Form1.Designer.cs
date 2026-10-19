namespace Nasledjivanje_Winforms
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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 274);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 296);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o zaposlenom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(334, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 237);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 4);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 7;
            label5.Text = "UNOS PODATAKA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 121);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = "Tip zaposlenog";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Radnik", "Menadzer" });
            comboBox1.Location = new Point(121, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(57, 165);
            button1.Name = "button1";
            button1.Size = new Size(196, 49);
            button1.TabIndex = 4;
            button1.Text = "Dodaj zaposlenog";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 80);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Plata";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 41);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Ime";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(499, 315);
            button2.Name = "button2";
            button2.Size = new Size(117, 54);
            button2.TabIndex = 3;
            button2.Text = "Ukloni zaposlenog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(499, 398);
            button3.Name = "button3";
            button3.Size = new Size(117, 54);
            button3.TabIndex = 4;
            button3.Text = "Tamna tema";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 490);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}
