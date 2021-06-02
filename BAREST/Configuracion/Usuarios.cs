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
        public string usuario = "";
        public string docu = "";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Inscripto())
            {
                MessageBox.Show("El usuario con ese 'documento' ya esta registrado");
                return;
            }

            if (textUsuario.Text == "" || textDocumento.Text == "" || textContraseña.Text == "" || textNombre.Text == "" || textApellido.Text == "" || comboCargo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Falta completar algun campo");
            }
            else
            {
                    Cone.Open();
                    string sql = "insert into Persona (nombre, apellido, telefono, fechaNacimiento, cuil) values(@n,@ap,@tel,@fecha,@cuil) select @@IDENTITY insert into Empleado(idPersona, legajo, contraseña, cargo) values(@@IDENTITY,@usuario,@cont,@cargo) ";
                    SqlCommand comando = new SqlCommand(sql, Cone);
                    comando.Parameters.Add("@n", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@ap", SqlDbType.VarChar).Value = textApellido.Text;
                    comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTelefono.Text;
                    comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                    comando.Parameters.Add("@cuil", SqlDbType.VarChar).Value = textDocumento.Text;
                    comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = textUsuario.Text;
                    comando.Parameters.Add("@cont", SqlDbType.VarChar).Value = textContraseña.Text;
                    comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargo.SelectedItem.ToString();
                    comando.ExecuteNonQuery();
                    Cone.Close();

                    MessageBox.Show("Se ha regitrado el usuario " + textUsuario.Text + " correctamente");
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    textUsuario.Text = "";
                    textContraseña.Text = "";
                    comboCargo.SelectedIndex = -1;
                    dateTimePicker1.Value = DateTime.Now;
                    CargarGrilla();
            }

        }

        //-------------------- PARA VERIFICAR SI EXISTE -----------------------------------

        private bool Inscripto()
        {
            Cone.Open();
            string sql = "select * from Persona where cuil=@cuil";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@cuil", SqlDbType.Char).Value = textDocumento.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Cone.Close();
            return existe;
        }

        // A MODIFICAR EL UPDATE
        private void button3_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "update Persona set nombre =@nombre, apellido =@apellido, telefono =@tel, fechaNacimiento =@fecha, cuil =@cuil where cuil =@docu";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTelefono.Text;
            comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
            comando.Parameters.Add("@cuil", SqlDbType.VarChar).Value = textDocumento.Text;
            comando.Parameters.Add("@docu", SqlDbType.VarChar).Value = docu;

            int cant = comando.ExecuteNonQuery();
            if (cant != 0)
            {
                MessageBox.Show("Los datos se modificaron correctamente");
                docu = textDocumento.Text;
            }
            else
                MessageBox.Show("Buscar por el 'documento' el usuario a modificar");
            Cone.Close();
            CargarGrilla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "select p.nombre,p.apellido,p.telefono,p.fechaNacimiento,p.cuil,e.legajo,e.contraseña,e.cargo from Persona p Join Empleado e on e.idPersona = p.id where p.cuil= @dni";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@dni", SqlDbType.VarChar).Value =textDocumento.Text;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textNombre.Text = leido["nombre"].ToString();
                textApellido.Text = leido["apellido"].ToString();
                textTelefono.Text = leido["telefono"].ToString();
                textUsuario.Text = leido["legajo"].ToString();
                textContraseña.Text = leido["contraseña"].ToString();
                comboCargo.Text = leido["cargo"].ToString();

                usuario = textUsuario.Text;
                docu = textDocumento.Text;

                //---PARA PODER PONER LA FECHA EN EL DATATIMEPICKER---

                string hola = leido["fechaNacimiento"].ToString();

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
                Cone.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDocumento.Text == "")
            {
                MessageBox.Show("Es necesario el 'documento' para eliminar un usuario"); 
            }
            else 
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar el usuario?", "Borrar usuario", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Cone.Open();
                    string sql = "delete from Persona where cuil= @doc";
                    SqlCommand comando = new SqlCommand(sql, Cone);
                    comando.Parameters.Add("@doc", SqlDbType.VarChar).Value = textDocumento.Text;
                    int cant = comando.ExecuteNonQuery();
                    MessageBox.Show("Se eliminó el usuario: " + textUsuario.Text);
                    Cone.Close();
                    CargarGrilla();
                    textNombre.Text = "";
                    textApellido.Text = "";
                    textTelefono.Text = "";
                    textDocumento.Text = "";
                    textUsuario.Text = "";
                    textContraseña.Text = "";
                    comboCargo.SelectedIndex = -1;
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            Cone.Open();
            string sql = "select p.nombre, p.cuil, e.cargo from Persona p inner join Empleado e on e.idPersona = p.id";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cargo"].ToString(), registros["cuil"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "" || textContraseña.Text == "" ||  comboCargo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Buscar por el 'documento' el usuario a modificar");
            }
            else
            {
                Cone.Open();
                string sql = "update Empleado set legajo=@usuario,contraseña=@cont,cargo=@cargo where legajo=@usu";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = textUsuario.Text;
                comando.Parameters.Add("@cont", SqlDbType.VarChar).Value = textContraseña.Text;
                comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargo.SelectedItem.ToString();
                comando.Parameters.Add("@usu", SqlDbType.VarChar).Value = usuario;
                int cant = comando.ExecuteNonQuery();
                if (cant != 0)
                {
                    MessageBox.Show("Los datos se modificaron correctamente");
                    usuario = "";
                }
                else
                    MessageBox.Show("Buscar por el 'documento' el usuario a modificar");
                Cone.Close();
                CargarGrilla();
            }
        }
    }
}
