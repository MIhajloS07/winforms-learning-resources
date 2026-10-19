using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ucitavanje_podataka_iz_Northwind_Baze
{
    internal class Prevoznik
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        //public string City { get; set; }

        public static List<Prevoznik> UcitajSve()
        {
            List<Prevoznik> prevoznici = new List<Prevoznik>();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Prevoznik p = new Prevoznik();
                    p.ShipperID = Convert.ToInt32(row["ShipperID"]);
                    p.CompanyName = row["CompanyName"].ToString();
                    //p.City = row["City"].ToString();
                    p.Phone = row["Phone"].ToString();
                    prevoznici.Add(p);
                }
            }
            return prevoznici;
        }

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

        public static bool Azuriraj(int shipperID, string companyName, string phone)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "usp_Izmeni";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ShipperID", SqlDbType.Int).Value = shipperID;
                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50).Value = companyName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 24).Value = phone;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }

        public static bool Obrisi(int shipperId)
        {
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "usp_Obrisi";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ShipperID", SqlDbType.Int).Value = shipperId;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
