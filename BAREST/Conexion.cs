using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BAREST.Properties;
using System.Configuration;

namespace BAREST
{
    class Conexion
    {
        public static string ObtenerString()
        {
            return Settings.Default.BARESTNEWConnectionString1;
        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Cone = new SqlConnection(ObtenerString());
            Cone.Open();

            return Cone;
        }
    }
}
