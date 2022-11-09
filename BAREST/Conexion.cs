using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BAREST.Properties;
using System.Data;
using System.Windows.Forms;
using BAREST;
using System.Configuration;

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
            SqlConnection Cone = new SqlConnection(ObtenerString());
            Cone.Open();
            return Cone;
        }
    }
}
