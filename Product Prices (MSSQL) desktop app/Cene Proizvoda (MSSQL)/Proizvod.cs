using System.Data;
using System.Data.SqlClient;

namespace Cene_Proizvoda__MSSQL_
{
    internal class Proizvod
    {
        public static DataTable Prikazi()
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.connString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "usp_Proizvodi";
                cmd.CommandType = CommandType.StoredProcedure; // Pozivamo pohranjenu proceduru
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
