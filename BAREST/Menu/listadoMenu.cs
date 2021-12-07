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

namespace BAREST
{
    public partial class listadoMenu : Form
    {
        public listadoMenu()
        {
            InitializeComponent();
        }

        private void listadoMenu_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "select m.nombre,d.descripcion,r.descripcionMenu,m.precio from menu m inner join DetalleMenu  d on m.IdDetalleMenu=d.id inner join RubroMenu r on r.id=m.idRubroMenu";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["descripcion"].ToString(), registros["descripcionMenu"].ToString(), registros["precio"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
