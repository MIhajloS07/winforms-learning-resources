using System.Configuration;

namespace Unos_podataka_u_NorthWind_bazu
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
