namespace Timer_kontrola
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
            components = new System.ComponentModel.Container();
            StartBtn = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            StopBtn = new Button();
            ResetBtn = new Button();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartBtn.Location = new Point(50, 187);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(232, 51);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartStopBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(293, 86);
            label1.TabIndex = 1;
            label1.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // StopBtn
            // 
            StopBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StopBtn.Location = new Point(50, 244);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(232, 51);
            StopBtn.TabIndex = 2;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(50, 301);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(232, 51);
            ResetBtn.TabIndex = 3;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 372);
            Controls.Add(ResetBtn);
            Controls.Add(StopBtn);
            Controls.Add(label1);
            Controls.Add(StartBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button StopBtn;
        private Button ResetBtn;
    }
}
