namespace BudilnikZad1
{
    partial class DigitalAlarmClock
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
            ExitBtn = new Button();
            clocklabel = new Label();
            HourTextBox = new TextBox();
            MinuteTextBox = new TextBox();
            buttonClock = new Button();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SecondTextBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(495, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(89, 39);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "Izlaz";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            ExitBtn.MouseLeave += ExitBtn_MouseLeave;
            // 
            // clocklabel
            // 
            clocklabel.AutoSize = true;
            clocklabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clocklabel.Location = new Point(151, 58);
            clocklabel.Name = "clocklabel";
            clocklabel.Size = new Size(293, 86);
            clocklabel.TabIndex = 1;
            clocklabel.Text = "00:00:00";
            clocklabel.MouseEnter += clocklabel_MouseEnter;
            clocklabel.MouseLeave += clocklabel_MouseLeave;
            // 
            // HourTextBox
            // 
            HourTextBox.Location = new Point(142, 185);
            HourTextBox.Name = "HourTextBox";
            HourTextBox.Size = new Size(77, 23);
            HourTextBox.TabIndex = 2;
            HourTextBox.MouseEnter += HourTextBox_MouseEnter;
            HourTextBox.MouseLeave += HourTextBox_MouseLeave;
            // 
            // MinuteTextBox
            // 
            MinuteTextBox.Location = new Point(253, 185);
            MinuteTextBox.Name = "MinuteTextBox";
            MinuteTextBox.Size = new Size(77, 23);
            MinuteTextBox.TabIndex = 3;
            MinuteTextBox.MouseEnter += MinuteTextBox_MouseEnter;
            MinuteTextBox.MouseLeave += MinuteTextBox_MouseLeave;
            // 
            // buttonClock
            // 
            buttonClock.Location = new Point(225, 247);
            buttonClock.Name = "buttonClock";
            buttonClock.Size = new Size(131, 41);
            buttonClock.TabIndex = 4;
            buttonClock.Text = "Ukljuci alarm";
            buttonClock.UseVisualStyleBackColor = true;
            buttonClock.Click += button1_Click;
            buttonClock.MouseEnter += buttonClock_MouseEnter;
            buttonClock.MouseLeave += buttonClock_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 167);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 5;
            label2.Text = "Sati";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 167);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Minute";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // SecondTextBox
            // 
            SecondTextBox.Location = new Point(367, 185);
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size(77, 23);
            SecondTextBox.TabIndex = 7;
            SecondTextBox.MouseEnter += SecondTextBox_MouseEnter;
            SecondTextBox.MouseLeave += SecondTextBox_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 167);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "Sekundi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // DigitalAlarmClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 315);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(SecondTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonClock);
            Controls.Add(MinuteTextBox);
            Controls.Add(HourTextBox);
            Controls.Add(clocklabel);
            Controls.Add(ExitBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DigitalAlarmClock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital alarm clock";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Label clocklabel;
        private TextBox HourTextBox;
        private TextBox MinuteTextBox;
        private Button buttonClock;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private TextBox SecondTextBox;
        private Label label1;
        private Label label4;
    }
}
