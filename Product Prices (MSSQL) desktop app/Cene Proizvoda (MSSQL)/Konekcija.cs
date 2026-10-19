using System.Configuration;
namespace Cene_Proizvoda__MSSQL_
{
    internal class Konekcija
    {
        public static string connString
        {
            get 
            { 
                return ConfigurationManager.ConnectionStrings["NorthWindCS"].ConnectionString;
            }
        }
    }
}
