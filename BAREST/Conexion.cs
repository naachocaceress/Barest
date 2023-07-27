using BAREST.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace BAREST
{
    class Conexion
    {
        public static int BARESTNEWConnectionString1 { get; private set; }

        public static string ObtenerString()
        {
            return Settings.Default.BARESTNEWConnectionString1;
        }

        public static SqlConnection ObtenerConexion()
        {
            //SqlConnection Cone = new SqlConnection(ConfigurationManager.ConnectionStrings["BARESTNEWConnectionString1"].ConnectionString);
            SqlConnection Cone = new SqlConnection(ObtenerString());
            Cone.Open();
            return Cone;
        }
    }
}
