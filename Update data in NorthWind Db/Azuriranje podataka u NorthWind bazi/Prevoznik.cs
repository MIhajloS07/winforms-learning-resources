using System;
using System.Data.SqlClient;
namespace Azuriranje_podataka_u_NorthWind_bazi
{
    internal class Prevoznik
    {
        //public string CompanyName { get; set; }
        //public string Phone { get; set; }
        //public int ShipperID { get; set; }
        
        public static bool Azuriraj(int shipperID, string companyName, string phone)
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.ConnectionString)
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "usp_Izmeni";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ShipperID", System.Data.SqlDbType.Int).Value = shipperID;
                cmd.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 50).Value = companyName;
                cmd.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 24).Value = phone;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }
    }
}
