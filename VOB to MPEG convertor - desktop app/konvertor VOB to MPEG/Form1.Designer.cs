namespace konvertor_VOB_to_MPEG
{
    partial class KonvertorForma
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
            BtnSelectVob = new Button();
            lstFiles = new ListBox();
            label1 = new Label();
            btnSelectOutput = new Button();
            txtOutputPath = new TextBox();
            label2 = new Label();
            btnMerge = new Button();
            progressBar1 = new ProgressBar();
            statusLabel = new Label();
            label3 = new Label();
            btnPostupak = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // BtnSelectVob
            // 
            BtnSelectVob.Location = new Point(28, 59);
            BtnSelectVob.Name = "BtnSelectVob";
            BtnSelectVob.Size = new Size(171, 66);
            BtnSelectVob.TabIndex = 0;
            BtnSelectVob.Text = "Selektuj VOB fajlove";
            BtnSelectVob.UseVisualStyleBackColor = true;
            BtnSelectVob.Click += BtnSelectVob_Click;
            BtnSelectVob.MouseEnter += BtnSelectVob_MouseEnter;
            BtnSelectVob.MouseLeave += BtnSelectVob_MouseLeave;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 15;
            lstFiles.Location = new Point(251, 59);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(377, 184);
            lstFiles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 2;
            label1.Text = "Izabrani fajlovi";
            // 
            // btnSelectOutput
            // 
            btnSelectOutput.Location = new Point(28, 145);
            btnSelectOutput.Name = "btnSelectOutput";
            btnSelectOutput.Size = new Size(171, 66);
            btnSelectOutput.TabIndex = 3;
            btnSelectOutput.Text = "Sacuvaj kao MPEG";
            btnSelectOutput.UseVisualStyleBackColor = true;
            btnSelectOutput.Click += btnSelectOutput_Click;
            btnSelectOutput.MouseEnter += btnSelectOutput_MouseEnter;
            btnSelectOutput.MouseLeave += btnSelectOutput_MouseLeave;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(354, 272);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(274, 23);
            txtOutputPath.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 274);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Putanja fajla";
            // 
            // btnMerge
            // 
            btnMerge.Location = new Point(29, 228);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(171, 66);
            btnMerge.TabIndex = 6;
            btnMerge.Text = "Spoji u MPEG";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            btnMerge.MouseEnter += btnMerge_MouseEnter;
            btnMerge.MouseLeave += btnMerge_MouseLeave;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 364);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(672, 23);
            progressBar1.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(96, 328);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 328);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 9;
            label3.Text = "STATUS:";
            // 
            // btnPostupak
            // 
            btnPostupak.Location = new Point(450, 314);
            btnPostupak.Name = "btnPostupak";
            btnPostupak.Size = new Size(178, 34);
            btnPostupak.TabIndex = 10;
            btnPostupak.Text = "Postupak konvertovanja";
            btnPostupak.UseVisualStyleBackColor = true;
            btnPostupak.Click += btnPostupak_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(23, 21);
            label4.TabIndex = 11;
            label4.Text = "1.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 166);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 12;
            label5.Text = "2.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 249);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 13;
            label6.Text = "3.";
            // 
            // KonvertorForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 387);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnPostupak);
            Controls.Add(label3);
            Controls.Add(statusLabel);
            Controls.Add(progressBar1);
            Controls.Add(btnMerge);
            Controls.Add(label2);
            Controls.Add(txtOutputPath);
            Controls.Add(btnSelectOutput);
            Controls.Add(label1);
            Controls.Add(lstFiles);
            Controls.Add(BtnSelectVob);
            MaximizeBox = false;
            Name = "KonvertorForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VOB u MPEG konvertor";
            FormClosing += KonvertorForma_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSelectVob;
        private ListBox lstFiles;
        private Label label1;
        private Button btnSelectOutput;
        private TextBox txtOutputPath;
        private Label label2;
        private Button btnMerge;
        private ProgressBar progressBar1;
        private Label statusLabel;
        private Label label3;
        private Button btnPostupak;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
