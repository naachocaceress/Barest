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
            try
            {
                Conexion.ObtenerConexion();
                using(var comando= new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText= "SELECT m.nombre,m.precio,m.descripcion, r.nombre  as rubro FROM Menu m  INNER JOIN RubroMenu r ON r.id = m.idRubro WHERE m.estado ='A' ORDER BY m.nombre ASC ";
                    SqlDataReader registros = comando.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["precio"].ToString(), registros["descripcion"].ToString(), registros["rubro"].ToString());
                    }
                    registros.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN BUSQUEDA DE LA LISTA MENÚ");
            }
          
        }

     
    }
}
