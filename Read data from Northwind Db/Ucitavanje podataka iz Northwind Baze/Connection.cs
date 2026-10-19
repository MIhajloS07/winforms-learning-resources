using System.Configuration;
namespace Ucitavanje_podataka_iz_Northwind_Baze
{
    internal class Connection
    {
        public static string ConnectionString
        {
            get 
            {
                return ConfigurationManager.ConnectionStrings["NorthWindCS"].ConnectionString;
            }
        }
    }
}
