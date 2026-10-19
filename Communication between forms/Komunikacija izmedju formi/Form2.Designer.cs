namespace Komunikacija_izmedju_formi
{
    partial class Form2
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
            ButtonOk = new Button();
            ButtonSend = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(204, 202);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(75, 23);
            ButtonOk.TabIndex = 0;
            ButtonOk.Text = "Ok";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonSend
            // 
            ButtonSend.Location = new Point(452, 202);
            ButtonSend.Name = "ButtonSend";
            ButtonSend.Size = new Size(75, 23);
            ButtonSend.TabIndex = 1;
            ButtonSend.Text = "Posalji";
            ButtonSend.UseVisualStyleBackColor = true;
            ButtonSend.Click += ButtonSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 307);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(522, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ButtonSend);
            Controls.Add(ButtonOk);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonOk;
        private Button ButtonSend;
        private Label label1;
        private TextBox textBox1;
    }
}