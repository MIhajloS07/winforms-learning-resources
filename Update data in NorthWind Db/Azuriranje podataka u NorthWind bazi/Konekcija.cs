using System.Configuration;

namespace Azuriranje_podataka_u_NorthWind_bazi
{
    internal class Konekcija
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
