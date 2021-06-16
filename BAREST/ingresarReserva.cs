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
    public partial class ingresarReserva : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public ingresarReserva()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarcomboTurno()
        {
            Cone.Open();
            string sql = "select id, nombre from Turno";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboTurno.DisplayMember = "nombre";
            comboTurno.ValueMember = "id";
            comboTurno.DataSource = tabla1;
            Cone.Close();
        }
        private void cargarComboMesa()
        {
            Cone.Open();
            string sql = "select id, numero from Mesa";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboMesa.DisplayMember = "numero";
            comboMesa.ValueMember = "id";
            comboMesa.DataSource = tabla1;
            Cone.Close();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
                // hice una modificacion en numero de reserva pongo seña en lugar de numero de reserva.
                Cone.Open();

            string sql = "insert into Cliente (Nombre,telefono,apellido) values (@nCli, @tCLi,@aCli)" +
                "select @@IDENTITY " +
                "insert into Reserva(cantDePersona, numeroDeReserva, fecha, idMesa, idTurno, hora, Posicion, idCliente) values(@cant, @seña, @fecha, @idmesa, @idTurno, @hora, @Posicion,@@IDENTITY)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@nCli", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@aCli", SqlDbType.VarChar).Value = textApellido.Text;
            comando.Parameters.Add("@tCli", SqlDbType.VarChar).Value = textTelefono.Text;
            comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = textcomensal.Text;
            comando.Parameters.Add("@seña", SqlDbType.Int).Value = textSeña.Text;
            comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
            comando.Parameters.Add("@idMesa", SqlDbType.VarChar).Value = comboMesa.SelectedValue.ToString();
            comando.Parameters.Add("@idTurno", SqlDbType.VarChar).Value = comboTurno.SelectedValue.ToString();
            comando.Parameters.Add("@hora", SqlDbType.Char).Value = textHora.Text;
            comando.Parameters.Add("@Posicion", SqlDbType.VarChar).Value = textPosicion.Text;
            comando.ExecuteNonQuery();
                MessageBox.Show("Reserva de " + textNombre.Text + "  Está registrado");
            textNombre.Text = " ";
            textApellido.Text = " ";
            textcomensal.Text = " ";
            textSeña.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            comboMesa.SelectedItem = -1;
            comboTurno.SelectedItem = -1;
            textHora.Text = " ";
            textPosicion.Text = " ";
                Cone.Close();


            }



        bool existeNombre()
        {
            Cone.Open();
            string sql = "select * from Cliente where nombre=@cli";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@cli", SqlDbType.VarChar).Value = textNombre.Text;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            Cone.Close();
            return existe;
        }

        private void ingresarReserva_Load(object sender, EventArgs e)
        {
            cargarComboMesa();
            cargarcomboTurno();
        }
    }
}
