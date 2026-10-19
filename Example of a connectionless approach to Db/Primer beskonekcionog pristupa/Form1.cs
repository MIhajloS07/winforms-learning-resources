using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Primer_beskonekcionog_pristupa
{
    public partial class Form1 : Form
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["NorthWindbaza"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void PrikaziIzBazeBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", conn);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(row["CompanyName"].ToString());
                }
            }
            MessageBox.Show("Podaci su uspešno učitani iz baze!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IzlazBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    "Da li ste sigurni da želite da izađete?",
                    "Potvrda izlaska",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
