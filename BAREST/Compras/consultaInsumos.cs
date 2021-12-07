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
    public partial class consultaInsumos : Form
    {
        public consultaInsumos()
        {
            InitializeComponent();
        }

        private void consultaInsumos_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "select I.descripcion, I.unidad, I.cant,P.nombre,R.descripcion from Insumo I inner join Rubro R on r.id = I.idRubro inner join Proveedor P on P.id = I.idProveedor ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["descripcion"].ToString(), registros["unidad"].ToString(), registros["cant"].ToString(), registros["descripcion"].ToString(), registros["nombre"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
