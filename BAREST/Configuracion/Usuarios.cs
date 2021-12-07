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
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Inscripto())
            {
                MessageBox.Show("El usuario ya esta registrado");
                return;
            }

            if ( textDocumento.Text == "" ||  textNombre.Text == "" || textApellido.Text == "" )
            {
                MessageBox.Show("Falta completar algun campo");
            }
            else
            {
                    Conexion.ObtenerConexion();
                    string sql = "insert into Persona (nombrePersona, apellidoPersona, telefonoPersona, fechaDeNacimiento, dni) values(@n,@ap,@tel,@fecha,@dni)";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@n", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@ap", SqlDbType.VarChar).Value = textApellido.Text;
                    comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTelefono.Text;
                    comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                    comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textDocumento.Text;
                    comando.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();

                    MessageBox.Show("Se ha regitrado el usuario " + textNombre.Text + " correctamente");
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    CargarGrilla();
            }

        }

        //-------------------- PARA VERIFICAR SI EXISTE -----------------------------------

        private bool Inscripto()
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Persona where dni=@dni";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textDocumento.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Conexion.ObtenerConexion().Close();
            return existe;
        }

        //--------------------------------------------------------------------------------

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // A MODIFICAR EL UPDATE
        private void button3_Click(object sender, EventArgs e)
        {
            if (textDocumento.Text == "")
            {
                MessageBox.Show("Es necesario buscar el usuario para modificarlo");
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "update Persona set nombrePersona=@nombre,apellidoPersona=@apellido,telefonoPersona=@tel,fechaDeNacimiento=@fecha";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
                comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTelefono.Text;
                comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                
                int cant = comando.ExecuteNonQuery();
                if (cant != 0)
                {
                    MessageBox.Show("Los datos se modificaron correctamente");
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
                Conexion.ObtenerConexion().Close();
                CargarGrilla();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string BuscarUsu =  tablaUsua.Rows[tablaUsua.CurrentRow.Index].Cells["dni"].Value.ToString();

            Conexion.ObtenerConexion();
            string sql = "select dni, nombrePersona,apellidoPersona,telefonoPersona,fechaDeNacimiento from Persona where dni= @dni";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@dni", BuscarUsu);
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textDocumento.Text = leido["dni"].ToString();
                textNombre.Text = leido["nombrePersona"].ToString();
                textApellido.Text = leido["apellidoPersona"].ToString();
                textTelefono.Text = leido["telefonoPersona"].ToString();
                
                //---PARA PODER PONER LA FECHA EN EL DATATIMEPICKER---

                string hola = leido["fechaDeNacimiento"].ToString();

                string[] separarFecha = hola.Split('/');
                string dia = separarFecha[0];
                string mes = separarFecha[1];
                string anio = separarFecha[2];

                int dia2 = Int32.Parse(dia);
                int mes2 = Int32.Parse(mes);

                string[] separardeHora = anio.Split(' ');
                string ani = separardeHora[0];

                int anio2 = Int32.Parse(ani);

                DateTime dt = new DateTime(anio2, mes2, dia2);
                dateTimePicker1.Value = dt;

                //--------------------------------------------------
            }
            else
            {
                MessageBox.Show("No hay un usuario con ese 'documento'");
            }
                leido.Close();
                Conexion.ObtenerConexion().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDocumento.Text == "")
            {
                MessageBox.Show("Es necesario buscar el usuario para eliminarlo"); 
            }
            else 
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Usuario", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Conexion.ObtenerConexion();
                    string sql = "delete from Persona where dni= @dni";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textDocumento.Text;
                    int cant = comando.ExecuteNonQuery();
                    MessageBox.Show("Se eliminó el usuario: " + textNombre.Text);
                    Conexion.ObtenerConexion().Close();
                    CargarGrilla();
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            Conexion.ObtenerConexion();
            string sql = "select dni, nombrePersona,apellidoPersona,telefonoPersona from Persona";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaUsua.Rows.Clear();
            while (registros.Read())
            {
                tablaUsua.Rows.Add(registros["dni"].ToString(), registros["nombrePersona"].ToString(), registros["apellidoPersona"].ToString(), registros["telefonoPersona"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
