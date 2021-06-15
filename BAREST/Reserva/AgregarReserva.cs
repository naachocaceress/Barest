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

namespace BAREST.Reserva
{
    public partial class textLugar : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public textLugar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            comboturno.DisplayMember = "nombre";
            comboturno.ValueMember = "id";
            comboturno.DataSource = tabla1;
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
            comboturno.DisplayMember = "numero";
            comboturno.ValueMember = "id";
            comboturno.DataSource = tabla1;
            Cone.Close();
        }


        private void textLugar_Load(object sender, EventArgs e)
        {
            cargarComboMesa();
            cargarcomboTurno();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {// hice una modificacion en numero de reserva pongo seña en lugar de numero de reserva.
            Cone.Open();
            string sql = "insert into  Reserva (cantDePersona,numeroDeReserva,fecha, idMesa,idTurno,idCliente,hora,Posicion) values (@cant,@seña,'@fecha',@idmesa,@idTurno,@idCliente,@hora,@Posicion)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = textTefono.Text;
            comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = textcomensal.Text;
            comando.Parameters.Add("@seña", SqlDbType.VarChar).Value = textseña.Text;
            comando.Parameters.Add("@fecha", SqlDbType.VarChar).Value = dateTimePicker1.Text;
            comando.Parameters.Add("@idMesa", SqlDbType.VarChar).Value = combomesa.SelectedValue.ToString();
            comando.Parameters.Add("@idTurno", SqlDbType.VarChar).Value = comboturno.SelectedValue.ToString();
            comando.Parameters.Add("@hora", SqlDbType.VarChar).Value = textHora.Text;
            comando.Parameters.Add("@Posicion", SqlDbType.VarChar).Value = textposicion.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Reserva de " + textNombre.Text + "Está registrado");
            textNombre.Text = " ";
            textTefono.Text = " ";
            textcomensal.Text = " ";
            textseña.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            combomesa.SelectedItem = -1;
            comboturno.SelectedItem = -1;
            Cone.Close();
        }
        private void buscarcliente()
        {
            Cone.Open();
            String sql = "select id ,nombre,telefono from Cliente where nombre LIKE '%nom%' or telefono like '%@tel%'";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            combonom.DisplayMember = "nombre";
            combotel.DisplayMember = "telefono";
            comboturno.ValueMember = "id";
            comboturno.DataSource = tabla1;
            Cone.Close();
        }
    }
}
