namespace CheckListBox_kontrola
{
    partial class ToDoForm
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
            checkedListBox1 = new CheckedListBox();
            textBoxZad = new TextBox();
            label1 = new Label();
            DodajBtn = new Button();
            PretraziBtn = new Button();
            UkloniBtn = new Button();
            UkloniSveBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(-1, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(396, 328);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // textBoxZad
            // 
            textBoxZad.Location = new Point(102, 338);
            textBoxZad.Name = "textBoxZad";
            textBoxZad.Size = new Size(237, 23);
            textBoxZad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 340);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 2;
            label1.Text = "Zadatak";
            // 
            // DodajBtn
            // 
            DodajBtn.Location = new Point(12, 386);
            DodajBtn.Name = "DodajBtn";
            DodajBtn.Size = new Size(75, 23);
            DodajBtn.TabIndex = 3;
            DodajBtn.Text = "Dodaj";
            DodajBtn.UseVisualStyleBackColor = true;
            DodajBtn.Click += DodajBtn_Click;
            // 
            // PretraziBtn
            // 
            PretraziBtn.Location = new Point(102, 386);
            PretraziBtn.Name = "PretraziBtn";
            PretraziBtn.Size = new Size(75, 23);
            PretraziBtn.TabIndex = 4;
            PretraziBtn.Text = "Pretrazi";
            PretraziBtn.UseVisualStyleBackColor = true;
            PretraziBtn.Click += PretraziBtn_Click;
            // 
            // UkloniBtn
            // 
            UkloniBtn.Location = new Point(199, 386);
            UkloniBtn.Name = "UkloniBtn";
            UkloniBtn.Size = new Size(75, 23);
            UkloniBtn.TabIndex = 5;
            UkloniBtn.Text = "Ukloni";
            UkloniBtn.UseVisualStyleBackColor = true;
            UkloniBtn.Click += UkloniBtn_Click;
            // 
            // UkloniSveBtn
            // 
            UkloniSveBtn.Location = new Point(296, 386);
            UkloniSveBtn.Name = "UkloniSveBtn";
            UkloniSveBtn.Size = new Size(75, 23);
            UkloniSveBtn.TabIndex = 6;
            UkloniSveBtn.Text = "Ukloni sve";
            UkloniSveBtn.UseVisualStyleBackColor = true;
            UkloniSveBtn.Click += UkloniSveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 296);
            label2.Name = "label2";
            label2.Size = new Size(253, 25);
            label2.TabIndex = 7;
            label2.Text = "Broj zadatka: 0 | zavrseni: 0";
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 432);
            Controls.Add(label2);
            Controls.Add(UkloniSveBtn);
            Controls.Add(UkloniBtn);
            Controls.Add(PretraziBtn);
            Controls.Add(DodajBtn);
            Controls.Add(label1);
            Controls.Add(textBoxZad);
            Controls.Add(checkedListBox1);
            Name = "ToDoForm";
            Text = "ToDo App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private TextBox textBoxZad;
        private Label label1;
        private Button DodajBtn;
        private Button PretraziBtn;
        private Button UkloniBtn;
        private Button UkloniSveBtn;
        private Label label2;
    }
}
