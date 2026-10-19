using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;

namespace Ucitavanje_podataka_iz_Northwind_Baze
{
    internal class Proizvod
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }

        public static List<Proizvod> UcitajSve()
        {
            List<Proizvod> proizvodi = new List<Proizvod>();
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"usp_Kat_Proizvodi";
                // usladistena procedura koja vraca sve proizvode sa kategorijama
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Proizvod p = new Proizvod
                    {
                        ProductID = (int)dr["ProductID"],
                        ProductName = (string)dr["ProductName"],
                        CategoryName = (string)dr["CategoryName"],
                        QuantityPerUnit = (string)dr["QuantityPerUnit"],
                        UnitPrice = (decimal)dr["UnitPrice"],
                        UnitsInStock = (short)dr["UnitsInStock"],
                        UnitsOnOrder = (short)dr["UnitsOnOrder"]
                    };
                    proizvodi.Add(p);
                }
            }
            return proizvodi;
        }
    }
}
