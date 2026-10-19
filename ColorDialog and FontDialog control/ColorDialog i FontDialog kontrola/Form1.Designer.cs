namespace ColorDialog_i_FontDialog_kontrola
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
            label1 = new Label();
            izaberiBojuBtn = new Button();
            izaberiFontBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 130);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Ovo je labela";
            // 
            // izaberiBojuBtn
            // 
            izaberiBojuBtn.Location = new Point(87, 249);
            izaberiBojuBtn.Name = "izaberiBojuBtn";
            izaberiBojuBtn.Size = new Size(150, 58);
            izaberiBojuBtn.TabIndex = 1;
            izaberiBojuBtn.Text = "Izaberi boju";
            izaberiBojuBtn.UseVisualStyleBackColor = true;
            izaberiBojuBtn.Click += izaberiBojuBtn_Click;
            // 
            // izaberiFontBtn
            // 
            izaberiFontBtn.Location = new Point(280, 249);
            izaberiFontBtn.Name = "izaberiFontBtn";
            izaberiFontBtn.Size = new Size(150, 58);
            izaberiFontBtn.TabIndex = 2;
            izaberiFontBtn.Text = "Izaberi font";
            izaberiFontBtn.UseVisualStyleBackColor = true;
            izaberiFontBtn.Click += izaberiFontBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 400);
            Controls.Add(izaberiFontBtn);
            Controls.Add(izaberiBojuBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button izaberiBojuBtn;
        private Button izaberiFontBtn;
    }
}
