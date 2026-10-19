namespace Ucitavanje_podataka_iz_Northwind_Baze
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstPrevoznici = new System.Windows.Forms.ListView();
            this.txtNazivKompanije = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbPrevoznici = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPrevoznici = new System.Windows.Forms.DataGridView();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.lvProizvodi = new System.Windows.Forms.ListView();
            this.btnIzmeniLV = new System.Windows.Forms.Button();
            this.btnObrisiLV = new System.Windows.Forms.Button();
            this.btnDodajLV = new System.Windows.Forms.Button();
            this.shipperIDTxt = new System.Windows.Forms.TextBox();
            this.CompanyNameTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevoznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPrevoznici
            // 
            this.lstPrevoznici.HideSelection = false;
            this.lstPrevoznici.Location = new System.Drawing.Point(17, 12);
            this.lstPrevoznici.Name = "lstPrevoznici";
            this.lstPrevoznici.Size = new System.Drawing.Size(550, 16);
            this.lstPrevoznici.TabIndex = 0;
            this.lstPrevoznici.UseCompatibleStateImageBehavior = false;
            // 
            // txtNazivKompanije
            // 
            this.txtNazivKompanije.Location = new System.Drawing.Point(239, 213);
            this.txtNazivKompanije.Name = "txtNazivKompanije";
            this.txtNazivKompanije.Size = new System.Drawing.Size(155, 20);
            this.txtNazivKompanije.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(406, 213);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(160, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(17, 681);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(154, 53);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cmbPrevoznici
            // 
            this.cmbPrevoznici.FormattingEnabled = true;
            this.cmbPrevoznici.Location = new System.Drawing.Point(17, 212);
            this.cmbPrevoznici.Name = "cmbPrevoznici";
            this.cmbPrevoznici.Size = new System.Drawing.Size(209, 21);
            this.cmbPrevoznici.TabIndex = 5;
            this.cmbPrevoznici.SelectedIndexChanged += new System.EventHandler(this.cmbPrevoznici_SelectedIndexChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(216, 681);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(154, 53);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(413, 681);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(154, 53);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPrevoznici
            // 
            this.dgvPrevoznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevoznici.Location = new System.Drawing.Point(191, 529);
            this.dgvPrevoznici.Name = "dgvPrevoznici";
            this.dgvPrevoznici.Size = new System.Drawing.Size(192, 123);
            this.dgvPrevoznici.TabIndex = 8;
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.Location = new System.Drawing.Point(239, 658);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(95, 23);
            this.sacuvajBtn.TabIndex = 9;
            this.sacuvajBtn.Text = "sacuvaj izmene";
            this.sacuvajBtn.UseVisualStyleBackColor = true;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // lvProizvodi
            // 
            this.lvProizvodi.HideSelection = false;
            this.lvProizvodi.Location = new System.Drawing.Point(17, 34);
            this.lvProizvodi.Name = "lvProizvodi";
            this.lvProizvodi.Size = new System.Drawing.Size(549, 162);
            this.lvProizvodi.TabIndex = 10;
            this.lvProizvodi.UseCompatibleStateImageBehavior = false;
            this.lvProizvodi.SelectedIndexChanged += new System.EventHandler(this.lvProizvodi_SelectedIndexChanged);
            // 
            // btnIzmeniLV
            // 
            this.btnIzmeniLV.Location = new System.Drawing.Point(17, 319);
            this.btnIzmeniLV.Name = "btnIzmeniLV";
            this.btnIzmeniLV.Size = new System.Drawing.Size(154, 53);
            this.btnIzmeniLV.TabIndex = 11;
            this.btnIzmeniLV.Text = "Izmeni";
            this.btnIzmeniLV.UseVisualStyleBackColor = true;
            this.btnIzmeniLV.Click += new System.EventHandler(this.btnIzmeniLV_Click);
            // 
            // btnObrisiLV
            // 
            this.btnObrisiLV.Location = new System.Drawing.Point(216, 319);
            this.btnObrisiLV.Name = "btnObrisiLV";
            this.btnObrisiLV.Size = new System.Drawing.Size(154, 53);
            this.btnObrisiLV.TabIndex = 12;
            this.btnObrisiLV.Text = "Obrisi";
            this.btnObrisiLV.UseVisualStyleBackColor = true;
            this.btnObrisiLV.Click += new System.EventHandler(this.btnObrisiLV_Click);
            // 
            // btnDodajLV
            // 
            this.btnDodajLV.Location = new System.Drawing.Point(412, 319);
            this.btnDodajLV.Name = "btnDodajLV";
            this.btnDodajLV.Size = new System.Drawing.Size(154, 53);
            this.btnDodajLV.TabIndex = 13;
            this.btnDodajLV.Text = "Dodaj";
            this.btnDodajLV.UseVisualStyleBackColor = true;
            this.btnDodajLV.Click += new System.EventHandler(this.btnDodajLV_Click);
            // 
            // shipperIDTxt
            // 
            this.shipperIDTxt.Location = new System.Drawing.Point(72, 401);
            this.shipperIDTxt.Name = "shipperIDTxt";
            this.shipperIDTxt.Size = new System.Drawing.Size(118, 20);
            this.shipperIDTxt.TabIndex = 14;
            // 
            // CompanyNameTxt
            // 
            this.CompanyNameTxt.Location = new System.Drawing.Point(237, 401);
            this.CompanyNameTxt.Name = "CompanyNameTxt";
            this.CompanyNameTxt.Size = new System.Drawing.Size(118, 20);
            this.CompanyNameTxt.TabIndex = 15;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(415, 401);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(118, 20);
            this.PhoneTxt.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(625, 21);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(469, 186);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(610, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(496, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Location = new System.Drawing.Point(799, 249);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(75, 23);
            this.prikaziBtn.TabIndex = 19;
            this.prikaziBtn.Text = "button1";
            this.prikaziBtn.UseVisualStyleBackColor = true;
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(610, 286);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(496, 318);
            this.treeView1.TabIndex = 20;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 746);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.prikaziBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.CompanyNameTxt);
            this.Controls.Add(this.shipperIDTxt);
            this.Controls.Add(this.btnDodajLV);
            this.Controls.Add(this.btnObrisiLV);
            this.Controls.Add(this.btnIzmeniLV);
            this.Controls.Add(this.lvProizvodi);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.dgvPrevoznici);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cmbPrevoznici);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtNazivKompanije);
            this.Controls.Add(this.lstPrevoznici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevoznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPrevoznici;
        private System.Windows.Forms.TextBox txtNazivKompanije;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbPrevoznici;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPrevoznici;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.ListView lvProizvodi;
        private System.Windows.Forms.Button btnIzmeniLV;
        private System.Windows.Forms.Button btnObrisiLV;
        private System.Windows.Forms.Button btnDodajLV;
        private System.Windows.Forms.TextBox shipperIDTxt;
        private System.Windows.Forms.TextBox CompanyNameTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.TreeView treeView1;
    }
}

