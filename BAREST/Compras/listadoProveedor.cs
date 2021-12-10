using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class listadoProveedor : Form
    {
        public listadoProveedor()
        {
            InitializeComponent();
        }

        private void listadoProveedor_Load(object sender, EventArgs e)
        {
            listaproveedor();
        }

        void listaproveedor()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,empresa, telefono,calle,nro,depto,piso,codPostal,localidad,provincia from Proveedor ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(),
                                       registros["empresa"].ToString(),
                                       registros["telefono"].ToString(),
                                       registros["calle"].ToString(),
                                       registros["nro"].ToString(),
                                       registros["depto"].ToString(),
                                       registros["piso"].ToString(),
                                       registros["codPostal"].ToString(),
                                       registros["localidad"].ToString(),
                                       registros["provincia"].ToString()
                                       );
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
