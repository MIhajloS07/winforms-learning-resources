using System;
using System.Data;
using System.Windows.Forms;

namespace Cene_Proizvoda__MSSQL_
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Proizvod.Prikazi();
                if (dt.Rows.Count > 0)
                {
                    dataGridViewCeneProizvoda.DataSource = dt;
                }
                else
                {
                    dataGridViewCeneProizvoda.DataSource = null;
                    MessageBox.Show(
                        "Nema podataka za prikaz u bazi.", 
                        "Informacija", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Doslo je do greske: {ex.Message}", 
                    "Greska", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da zelite da izadjete?", 
                "Potvrda izlaska", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
