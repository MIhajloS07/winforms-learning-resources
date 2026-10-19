namespace ListBox_kontrola
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
            label1 = new Label();
            textBox1 = new TextBox();
            DodajBtn = new Button();
            PretraziBtn = new Button();
            UkloniBtn = new Button();
            UkloniSveBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.ForeColor = SystemColors.ActiveCaptionText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-2, -1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(340, 319);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 329);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Zadatak";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 2;
            // 
            // DodajBtn
            // 
            DodajBtn.Location = new Point(12, 359);
            DodajBtn.Name = "DodajBtn";
            DodajBtn.Size = new Size(75, 23);
            DodajBtn.TabIndex = 3;
            DodajBtn.Text = "Dodaj";
            DodajBtn.UseVisualStyleBackColor = true;
            DodajBtn.Click += DodajBtn_Click;
            // 
            // PretraziBtn
            // 
            PretraziBtn.Location = new Point(93, 359);
            PretraziBtn.Name = "PretraziBtn";
            PretraziBtn.Size = new Size(75, 23);
            PretraziBtn.TabIndex = 4;
            PretraziBtn.Text = "Pretrazi";
            PretraziBtn.UseVisualStyleBackColor = true;
            PretraziBtn.Click += PretraziBtn_Click;
            // 
            // UkloniBtn
            // 
            UkloniBtn.Location = new Point(174, 359);
            UkloniBtn.Name = "UkloniBtn";
            UkloniBtn.Size = new Size(75, 23);
            UkloniBtn.TabIndex = 5;
            UkloniBtn.Text = "Ukloni";
            UkloniBtn.UseVisualStyleBackColor = true;
            UkloniBtn.Click += UkloniBtn_Click;
            // 
            // UkloniSveBtn
            // 
            UkloniSveBtn.Location = new Point(251, 359);
            UkloniSveBtn.Name = "UkloniSveBtn";
            UkloniSveBtn.Size = new Size(75, 23);
            UkloniSveBtn.TabIndex = 6;
            UkloniSveBtn.Text = "Ukloni sve";
            UkloniSveBtn.UseVisualStyleBackColor = true;
            UkloniSveBtn.Click += UkloniSveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 284);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 7;
            label2.Text = "Ukupno zadatka: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 394);
            Controls.Add(label2);
            Controls.Add(UkloniSveBtn);
            Controls.Add(UkloniBtn);
            Controls.Add(PretraziBtn);
            Controls.Add(DodajBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "ToDo lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Button DodajBtn;
        private Button PretraziBtn;
        private Button UkloniBtn;
        private Button UkloniSveBtn;
        private Label label2;
    }
}
