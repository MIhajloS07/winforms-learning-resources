namespace GroupBox_kontrola
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
            grupaUnos = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grupaOpcije = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            grupaUnos.SuspendLayout();
            grupaOpcije.SuspendLayout();
            SuspendLayout();
            // 
            // grupaUnos
            // 
            grupaUnos.Controls.Add(textBox3);
            grupaUnos.Controls.Add(textBox2);
            grupaUnos.Controls.Add(textBox1);
            grupaUnos.Controls.Add(label3);
            grupaUnos.Controls.Add(label2);
            grupaUnos.Controls.Add(label1);
            grupaUnos.Location = new Point(12, 12);
            grupaUnos.Name = "grupaUnos";
            grupaUnos.Size = new Size(293, 167);
            grupaUnos.TabIndex = 0;
            grupaUnos.TabStop = false;
            grupaUnos.Text = "Podaci korisnika";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 107);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Adresa elektronske poste";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime";
            // 
            // grupaOpcije
            // 
            grupaOpcije.Controls.Add(button3);
            grupaOpcije.Controls.Add(button2);
            grupaOpcije.Controls.Add(button1);
            grupaOpcije.Location = new Point(12, 185);
            grupaOpcije.Name = "grupaOpcije";
            grupaOpcije.Size = new Size(293, 148);
            grupaOpcije.TabIndex = 1;
            grupaOpcije.TabStop = false;
            grupaOpcije.Text = "Opcije";
            // 
            // button3
            // 
            button3.Location = new Point(16, 109);
            button3.Name = "button3";
            button3.Size = new Size(260, 23);
            button3.TabIndex = 2;
            button3.Text = "Odustani";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 66);
            button2.Name = "button2";
            button2.Size = new Size(260, 23);
            button2.TabIndex = 1;
            button2.Text = "Pozovi telefonom";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 22);
            button1.Name = "button1";
            button1.Size = new Size(260, 23);
            button1.TabIndex = 0;
            button1.Text = "Posalji elektronsku postu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 345);
            Controls.Add(grupaOpcije);
            Controls.Add(grupaUnos);
            Name = "Form1";
            Text = "Form1";
            grupaUnos.ResumeLayout(false);
            grupaUnos.PerformLayout();
            grupaOpcije.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grupaUnos;
        private GroupBox grupaOpcije;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
