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
    public partial class Usuarios: Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql= "insert into persona (nombre, apellido, telefono, fechaNacimiento, cuil) values(@n,@ap,@tel,@fecha,@cuil)" +
                "select @@IDENTITY" +
                "insert into Empleado(idPersona, legajo, contraseña, cargo) values(@@IDENTITY,@usuario,@cont,@cargo)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@n", SqlDbType.VarChar).Value =textNombre.Text;
            comando.Parameters.Add("@ap", SqlDbType.VarChar).Value =textApellido.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value =textTelefono.Text;
            comando.Parameters.Add("@fecha", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToString();
            comando.Parameters.Add("@cuil", SqlDbType.VarChar).Value = textDocumento.Text;
            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = textUsuario.Text;
            comando.Parameters.Add("@cont", SqlDbType.VarChar).Value = textContraseña.Text;
            comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargo.SelectedItem.ToString();
            comando.ExecuteNonQuery();
            Cone.Close();
            textNombre.Text = " ";
            textApellido.Text = " ";
            textTelefono.Text = " ";
            textDocumento.Text = " ";
            textUsuario.Text = " ";
            textContraseña.Text = " ";
            MessageBox.Show("Se Ha regitrado El usuario" + "@usuario" +"corectamente");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
