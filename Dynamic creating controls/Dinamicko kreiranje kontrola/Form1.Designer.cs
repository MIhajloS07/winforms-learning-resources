namespace Dinamicko_kreiranje_kontrola
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
            ButtonText = new Button();
            ButtonImage = new Button();
            label1 = new Label();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // ButtonText
            // 
            ButtonText.Location = new Point(142, 97);
            ButtonText.Name = "ButtonText";
            ButtonText.Size = new Size(84, 31);
            ButtonText.TabIndex = 3;
            ButtonText.Text = "Prikazi tekst";
            ButtonText.UseVisualStyleBackColor = true;
            ButtonText.Click += ButtonText_Click;
            // 
            // ButtonImage
            // 
            ButtonImage.Location = new Point(386, 95);
            ButtonImage.Name = "ButtonImage";
            ButtonImage.Size = new Size(84, 33);
            ButtonImage.TabIndex = 2;
            ButtonImage.Text = "Prikazi sliku";
            ButtonImage.UseVisualStyleBackColor = true;
            ButtonImage.Click += ButtonImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.MaximumSize = new Size(630, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(602, 42);
            label1.TabIndex = 4;
            label1.Text = "Koji programski jezik je 2000. godine dizajnirao Anders Hajlsberg u kompaniji Microsoft";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(257, 406);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Resetuj";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(ResetButton);
            Controls.Add(label1);
            Controls.Add(ButtonText);
            Controls.Add(ButtonImage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonText;
        private Button ButtonImage;
        private Label label1;
        private Button ResetButton;
    }
}
