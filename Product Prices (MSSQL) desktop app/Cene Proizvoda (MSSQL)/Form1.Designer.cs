namespace Cene_Proizvoda__MSSQL_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCeneProizvoda = new System.Windows.Forms.DataGridView();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.izlazBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCeneProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCeneProizvoda
            // 
            this.dataGridViewCeneProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCeneProizvoda.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCeneProizvoda.Name = "dataGridViewCeneProizvoda";
            this.dataGridViewCeneProizvoda.Size = new System.Drawing.Size(374, 454);
            this.dataGridViewCeneProizvoda.TabIndex = 0;
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Location = new System.Drawing.Point(12, 482);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(90, 30);
            this.prikaziBtn.TabIndex = 1;
            this.prikaziBtn.Text = "Prikazi";
            this.prikaziBtn.UseVisualStyleBackColor = true;
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(296, 482);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(90, 30);
            this.izlazBtn.TabIndex = 2;
            this.izlazBtn.Text = "IZLAZ";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 524);
            this.Controls.Add(this.izlazBtn);
            this.Controls.Add(this.prikaziBtn);
            this.Controls.Add(this.dataGridViewCeneProizvoda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCeneProizvoda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCeneProizvoda;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.Button izlazBtn;
    }
}

