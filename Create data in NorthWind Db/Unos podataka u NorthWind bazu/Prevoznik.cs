using System;
using System.Data.SqlClient;

namespace Unos_podataka_u_NorthWind_bazu
{
    internal class Prevoznik
    {
        public static int Dodaj(string companyName, string phone)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "usp_Ubaci";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40).Value = companyName;
                cmd.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 24).Value = phone;
                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
    }
}
