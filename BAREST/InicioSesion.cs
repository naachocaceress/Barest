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
    public partial class Form1 : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            logiarse();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                logiarse();
            }
        }

        // METODO PARA INCIAR SESION
        private void logiarse()
        {
            Cone.Open();
            string sql = "SELECT legajo, contraseña, cargo FROM Empleado WHERE legajo = @legajo AND contraseña = @contra AND cargo = 'Administrador'";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@legajo", SqlDbType.VarChar).Value = tboxUsuario.Text;
            comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = tboxContraseña.Text;
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                inicio m = new inicio();
                m.label2.Text = tboxUsuario.Text;
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos, intenta de nuevo");
                tboxUsuario.Clear();
                tboxContraseña.Clear();
                tboxUsuario.Focus();
            }
            dr.Close();
            Cone.Close();
        }

        private void tboxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
