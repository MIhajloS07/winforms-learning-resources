namespace Bankovni_racun
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
            label2 = new Label();
            userNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            logInbtn = new Button();
            checkPass = new CheckBox();
            FirstNameText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LastNameText = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 71);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisnicko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 187);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "lozinka";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(259, 71);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(167, 23);
            userNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(259, 184);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(167, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // logInbtn
            // 
            logInbtn.Location = new Point(241, 227);
            logInbtn.Name = "logInbtn";
            logInbtn.Size = new Size(107, 37);
            logInbtn.TabIndex = 4;
            logInbtn.Text = "Uloguj se";
            logInbtn.UseVisualStyleBackColor = true;
            logInbtn.Click += logInbtn_Click;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.Location = new Point(407, 189);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(15, 14);
            checkPass.TabIndex = 5;
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(259, 112);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(167, 23);
            FirstNameText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 115);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Ime:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 153);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Prezime:";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(259, 150);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(167, 23);
            LastNameText.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 27);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 10;
            label5.Text = "LOG IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 343);
            Controls.Add(label5);
            Controls.Add(LastNameText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FirstNameText);
            Controls.Add(checkPass);
            Controls.Add(logInbtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        private TextBox PasswordTextBox;
        private Button logInbtn;
        private CheckBox checkPass;
        private TextBox FirstNameText;
        private Label label3;
        private Label label4;
        private TextBox LastNameText;
        private Label label5;
    }
}
