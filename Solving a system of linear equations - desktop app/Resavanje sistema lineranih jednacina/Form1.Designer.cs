namespace Resavanje_sistema_lineranih_jednacina
{
    partial class Forma
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
            A1 = new TextBox();
            B1 = new TextBox();
            C1 = new TextBox();
            C2 = new TextBox();
            B2 = new TextBox();
            A2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NacrtajBtn = new Button();
            ObrisiBtn = new Button();
            PanelCanvas = new Panel();
            PanelError = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            MinimizeBtn = new Button();
            ExitBtn = new Button();
            label4 = new Label();
            PanelError.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // A1
            // 
            A1.BorderStyle = BorderStyle.FixedSingle;
            A1.Location = new Point(27, 61);
            A1.Name = "A1";
            A1.Size = new Size(56, 23);
            A1.TabIndex = 0;
            // 
            // B1
            // 
            B1.BorderStyle = BorderStyle.FixedSingle;
            B1.Location = new Point(101, 61);
            B1.Name = "B1";
            B1.Size = new Size(56, 23);
            B1.TabIndex = 1;
            // 
            // C1
            // 
            C1.BorderStyle = BorderStyle.FixedSingle;
            C1.Location = new Point(176, 61);
            C1.Name = "C1";
            C1.Size = new Size(56, 23);
            C1.TabIndex = 2;
            // 
            // C2
            // 
            C2.BorderStyle = BorderStyle.FixedSingle;
            C2.Location = new Point(474, 61);
            C2.Name = "C2";
            C2.Size = new Size(56, 23);
            C2.TabIndex = 5;
            // 
            // B2
            // 
            B2.BorderStyle = BorderStyle.FixedSingle;
            B2.Location = new Point(399, 61);
            B2.Name = "B2";
            B2.Size = new Size(56, 23);
            B2.TabIndex = 4;
            // 
            // A2
            // 
            A2.BorderStyle = BorderStyle.FixedSingle;
            A2.Location = new Point(325, 61);
            A2.Name = "A2";
            A2.Size = new Size(56, 23);
            A2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 6;
            label1.Text = "Koeficijenti prve jednacine a₁x + b₁x = c₁";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 43);
            label2.Name = "label2";
            label2.Size = new Size(218, 15);
            label2.TabIndex = 7;
            label2.Text = "Koeficijenti prve jednacine a₂x + b₂x = c₂";
            // 
            // NacrtajBtn
            // 
            NacrtajBtn.FlatAppearance.BorderColor = Color.OrangeRed;
            NacrtajBtn.FlatStyle = FlatStyle.Flat;
            NacrtajBtn.Location = new Point(608, 59);
            NacrtajBtn.Name = "NacrtajBtn";
            NacrtajBtn.Size = new Size(81, 27);
            NacrtajBtn.TabIndex = 8;
            NacrtajBtn.Text = "Nacrtaj";
            NacrtajBtn.UseVisualStyleBackColor = true;
            NacrtajBtn.Click += NacrtajBtn_Click;
            NacrtajBtn.MouseEnter += NacrtajBtn_MouseEnter;
            NacrtajBtn.MouseLeave += NacrtajBtn_MouseLeave;
            // 
            // ObrisiBtn
            // 
            ObrisiBtn.FlatAppearance.BorderColor = Color.OrangeRed;
            ObrisiBtn.FlatStyle = FlatStyle.Flat;
            ObrisiBtn.Location = new Point(702, 59);
            ObrisiBtn.Name = "ObrisiBtn";
            ObrisiBtn.Size = new Size(81, 27);
            ObrisiBtn.TabIndex = 9;
            ObrisiBtn.Text = "Obrisi";
            ObrisiBtn.UseVisualStyleBackColor = true;
            ObrisiBtn.Click += ObrisiBtn_Click;
            ObrisiBtn.MouseEnter += ObrisiBtn_MouseEnter;
            ObrisiBtn.MouseLeave += ObrisiBtn_MouseLeave;
            // 
            // PanelCanvas
            // 
            PanelCanvas.BorderStyle = BorderStyle.FixedSingle;
            PanelCanvas.Location = new Point(22, 98);
            PanelCanvas.Name = "PanelCanvas";
            PanelCanvas.Size = new Size(763, 368);
            PanelCanvas.TabIndex = 10;
            PanelCanvas.Paint += PanelCanvas_Paint;
            // 
            // PanelError
            // 
            PanelError.BackColor = Color.Red;
            PanelError.Controls.Add(label3);
            PanelError.Location = new Point(0, 480);
            PanelError.Name = "PanelError";
            PanelError.Size = new Size(805, 23);
            PanelError.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(302, 2);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 28);
            panel1.TabIndex = 12;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackgroundImageLayout = ImageLayout.None;
            MinimizeBtn.Cursor = Cursors.Hand;
            MinimizeBtn.FlatAppearance.BorderSize = 0;
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeBtn.Location = new Point(728, 1);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(35, 27);
            MinimizeBtn.TabIndex = 14;
            MinimizeBtn.Text = "-";
            MinimizeBtn.TextAlign = ContentAlignment.TopCenter;
            MinimizeBtn.UseVisualStyleBackColor = true;
            MinimizeBtn.Click += MinimizeBtn_Click;
            MinimizeBtn.MouseEnter += MinimizeBtn_MouseEnter;
            MinimizeBtn.MouseLeave += MinimizeBtn_MouseLeave;
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImageLayout = ImageLayout.None;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(770, 1);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(35, 27);
            ExitBtn.TabIndex = 13;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OrangeRed;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(266, 5);
            label4.Name = "label4";
            label4.Size = new Size(235, 17);
            label4.TabIndex = 0;
            label4.Text = "Resavanje sistema linearnih jednacina";
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 503);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(PanelError);
            Controls.Add(PanelCanvas);
            Controls.Add(ObrisiBtn);
            Controls.Add(NacrtajBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C2);
            Controls.Add(B2);
            Controls.Add(A2);
            Controls.Add(C1);
            Controls.Add(B1);
            Controls.Add(A1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelError.ResumeLayout(false);
            PanelError.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox A1;
        private TextBox B1;
        private TextBox C1;
        private TextBox C2;
        private TextBox B2;
        private TextBox A2;
        private Label label1;
        private Label label2;
        private Button NacrtajBtn;
        private Button ObrisiBtn;
        private Panel PanelCanvas;
        private Panel PanelError;
        private Label label3;
        private Panel panel1;
        private Button ExitBtn;
        private Label label4;
        private Button MinimizeBtn;
    }
}
