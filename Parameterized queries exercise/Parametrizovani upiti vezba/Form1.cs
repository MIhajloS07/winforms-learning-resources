using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Parametrizovani_upiti_vezba
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void ButtonPretrazi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                string drzava = txtDrzava.Text.Trim();
                string connString = ConfigurationManager.ConnectionStrings["NorthWindBaza"].ConnectionString;
                //string SqlUpit = "SELECT CustomerID, CompanyName, City FROM Customers WHERE Country = @drzava";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.usp_GetCustomersByCountry", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@drzava", drzava);
                    cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = drzava;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                               listBox1.Items.Add(reader["CustomerID"].ToString() + " - " + reader["CompanyName"].ToString() + " - " + reader["City"].ToString());
                            }
                            txtDrzava.Clear();
                        }
                        else                         
                        {
                            MessageBox.Show(
                                "Nema rezultata za zadatu drzavu.",
                                "Nema rezultata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            txtDrzava.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

