namespace Dijalozi_za_rad_sa_fajlovima
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
            openFileDialog1 = new OpenFileDialog();
            OpenFileBtn = new Button();
            pathLabel = new Label();
            richTextBox1 = new RichTextBox();
            SaveFileBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ChooseFolderBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileBtn
            // 
            OpenFileBtn.Location = new Point(21, 23);
            OpenFileBtn.Name = "OpenFileBtn";
            OpenFileBtn.Size = new Size(75, 23);
            OpenFileBtn.TabIndex = 0;
            OpenFileBtn.Text = "Otvori fajl";
            OpenFileBtn.UseVisualStyleBackColor = true;
            OpenFileBtn.Click += OpenFileBtn_Click;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(311, 27);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(0, 15);
            pathLabel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(21, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(646, 374);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // SaveFileBtn
            // 
            SaveFileBtn.Location = new Point(116, 23);
            SaveFileBtn.Name = "SaveFileBtn";
            SaveFileBtn.Size = new Size(75, 23);
            SaveFileBtn.TabIndex = 3;
            SaveFileBtn.Text = "Sacuvaj fajl";
            SaveFileBtn.UseVisualStyleBackColor = true;
            SaveFileBtn.Click += SaveFileBtn_Click;
            // 
            // ChooseFolderBtn
            // 
            ChooseFolderBtn.Location = new Point(214, 23);
            ChooseFolderBtn.Name = "ChooseFolderBtn";
            ChooseFolderBtn.Size = new Size(96, 23);
            ChooseFolderBtn.TabIndex = 4;
            ChooseFolderBtn.Text = "Odaberi folder";
            ChooseFolderBtn.UseVisualStyleBackColor = true;
            ChooseFolderBtn.Click += ChooseFolderBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(ChooseFolderBtn);
            Controls.Add(SaveFileBtn);
            Controls.Add(richTextBox1);
            Controls.Add(pathLabel);
            Controls.Add(OpenFileBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button OpenFileBtn;
        private Label pathLabel;
        private RichTextBox richTextBox1;
        private Button SaveFileBtn;
        private SaveFileDialog saveFileDialog1;
        private Button ChooseFolderBtn;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
