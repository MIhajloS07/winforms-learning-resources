using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Primer_konekcionog_pristupa_MSSQL
{
    public partial class Form1 : Form
    {
        //private readonly string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;
        //                                           Initial Catalog=NorthWind;
        //                                           Integrated Security=True;";

        string connectionString = ConfigurationManager.ConnectionStrings["NorthWindBaza"].ConnectionString;  
        public Form1()
        {
            InitializeComponent();
        }

        private void IspisiIzBaze_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxBaza.Items.Add(reader["CompanyName"].ToString());
                    }
                }
            }
            MessageBox.Show("Podaci su uspešno učitani iz baze!");
        }

        private void IzlazBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da izađete?",
                "Potvrda izlaska",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
