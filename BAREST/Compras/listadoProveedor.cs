using System;
using System.Data.SqlClient;
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
            string sql = "select cuit,empresa, telefono,direccion,altura,depto,archivo from Proveedor  where estado ='A' ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["cuit"].ToString(),
                                       registros["empresa"].ToString(),
                                       registros["telefono"].ToString(),
                                       registros["direccion"].ToString(),
                                       registros["altura"].ToString(),
                                       registros["depto"].ToString(),
                                       registros["archivo"].ToString()
                                       );
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
