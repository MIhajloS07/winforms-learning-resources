namespace Rad_sa_vise_formi
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
            UcitajFormuBtn = new Button();
            SuspendLayout();
            // 
            // UcitajFormuBtn
            // 
            UcitajFormuBtn.Location = new Point(22, 21);
            UcitajFormuBtn.Name = "UcitajFormuBtn";
            UcitajFormuBtn.Size = new Size(128, 49);
            UcitajFormuBtn.TabIndex = 0;
            UcitajFormuBtn.Text = "Ucitaj drugu formu";
            UcitajFormuBtn.UseVisualStyleBackColor = true;
            UcitajFormuBtn.Click += UcitajFormuBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UcitajFormuBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button UcitajFormuBtn;
    }
}
