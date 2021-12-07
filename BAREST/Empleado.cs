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
    public partial class Empleado : Form
    {
        // private SqlConnection Cone = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConeBase"].ConnectionString);
      private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "Insert into Empleado(legajo,contraseña,cargo) values(@leg,@cont,@ca)";
            SqlCommand comando = new SqlCommand(sql,Cone);
            comando.Parameters.Add("@leg", SqlDbType.VarChar).Value = textUsuario.Text;
            comando.Parameters.Add("@cont", SqlDbType.VarChar).Value = textContraseña.Text;
            comando.Parameters.Add("@ca", SqlDbType.VarChar).Value = textCargo.Text;
            comando.ExecuteNonQuery();
            Cone.Close();
            textUsuario.Text = " ";
            textContraseña.Text = " ";
            textCargo.Text = " ";
            
            MessageBox.Show("Se Ha regitrado El usuario @leg corectamente");

        }
    }
}
