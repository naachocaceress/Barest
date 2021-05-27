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
    public partial class buscarUsuario : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public buscarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "select p.nombre,p.apellido,p.telefono,p.fechaNacimiento,p.cuil,e.legajo,e.contraseña,e.cargo from Persona p Join Empleado e on e.idPersona = p.id where p.cuil= @nombre2";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@nombre2", SqlDbType.VarChar).Value = textNombre2.Text;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                
            }
            Cone.Close();
        }
    }
}
