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
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");

        public listadoMenu()
        {
            InitializeComponent();
        }

        private void listadoMenu_Load(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "select m.nombre,d.descripcion,r.descripcionMenu,m.precio from menu m inner join DetalleMenu  d on m.IdDetalleMenu=d.id inner join RubroMenu r on r.id=m.idRubroMenu";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["descripcion"].ToString(), registros["descripcionMenu"].ToString(), registros["precio"].ToString());
            }
            registros.Close();
            Cone.Close();
        }
    }
}
