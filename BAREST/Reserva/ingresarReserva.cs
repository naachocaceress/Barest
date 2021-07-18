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
using static BAREST.Reservas;

namespace BAREST
{
    public partial class ingresarReserva : Form
    {
        public ingresarReserva()
        {
            InitializeComponent();
        }

        private void cargarcomboTurno()
        {
            Conexion.ObtenerConexion();
            string sql = "select id, nombre from Turno";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboTurno.DisplayMember = "nombre";
            comboTurno.ValueMember = "id";
            comboTurno.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }
        private void cargarComboMesa()
        {
            Conexion.ObtenerConexion();
            string sql = "select id, numero from Mesa";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboMesa.DisplayMember = "numero";
            comboMesa.ValueMember = "id";
            comboMesa.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }
        private void confirmar_Click(object sender, EventArgs e)
        {
            if (ClaseCompartida.Insum2 == 0)
            {
                if (textNombre.Text == "" || textApellido.Text == "" || textTelefono.Text == "" || textcomensal.Text == "" || textSeña.Text == "" || comboMesa.SelectedIndex.Equals(-1) || comboTurno.SelectedIndex.Equals(-1) || textHora.Text == "" || textPosicion.Text == "")
                {
                    MessageBox.Show("Faltan datos para poder guardar la reserva");
                }
                else
                {
                    // hice una modificacion en numero de reserva pongo seña en lugar de numero de reserva.
                    Conexion.ObtenerConexion();

                    string sql = "insert into Cliente (Nombre,telefono,apellido) values (@nCli, @tCLi,@aCli)" +
                        "select @@IDENTITY " +
                        "insert into Reserva(cantDePersona, numeroDeReserva, fecha, idMesa, idTurno, hora, Posicion, idCliente) values(@cant, @seña, @fecha, @idmesa, @idTurno, @hora, @Posicion,@@IDENTITY)";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
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
                    MessageBox.Show("La reserva de " + textNombre.Text + " se registro correctamente");
                    Conexion.ObtenerConexion().Close();
                    textNombre.Text = " ";
                    textApellido.Text = " ";
                    textcomensal.Text = " ";
                    textSeña.Text = " ";
                    dateTimePicker1.Value = DateTime.Now;
                    comboMesa.SelectedItem = -1;
                    comboTurno.SelectedItem = -1;
                    textHora.Text = " ";
                    textPosicion.Text = " ";
                    this.Close();
                }
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "update Reserva set hora=@hora, numeroDeReserva=@seña,fecha=@fecha,cantDePersona=@cantDePersona, Posicion= @posicion where idCliente=@id";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@id", SqlDbType.VarChar).Value = ClaseCompartida.Insum2;
                comando.Parameters.Add("@hora", SqlDbType.Char).Value = textHora.Text;
                comando.Parameters.Add("@seña", SqlDbType.Int).Value = textSeña.Text;
                comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                comando.Parameters.Add("@cantDePersona", SqlDbType.Int).Value = textcomensal.Text;
                comando.Parameters.Add("@posicion", SqlDbType.VarChar).Value = textPosicion.Text;
                int cant = comando.ExecuteNonQuery();
                if (cant != 0)
                {
                    MessageBox.Show("Los datos se modificaron correctamente");
                    this.Close();
                }
                Conexion.ObtenerConexion().Close();
            }   

        }

        bool existeNombre()
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Cliente where nombre=@cli";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@cli", SqlDbType.VarChar).Value = textNombre.Text;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            return existe;
            Conexion.ObtenerConexion().Close();
        }

        private void ingresarReserva_Load(object sender, EventArgs e)
        {
            if (ClaseCompartida.Insum2 == 0)
            {
                cargarComboMesa();
                cargarcomboTurno();
            }
            else
            {
                cargarModificacion();
            }
        }

        private void cargarModificacion()
        {
            Conexion.ObtenerConexion();
            string sql = "select c.nombre,c.apellido,c.telefono,r.hora,m.numero,r.numeroDeReserva,r.fecha,t.nombre AS turno, r.cantDePersona, r.Posicion from Cliente c join Reserva r on r.idCliente =c.id join Turno t on r.idTurno=t.id join Mesa m on m.id= r.idMesa where c.id = @dni";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = ClaseCompartida.Insum2;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textNombre.Text = leido["nombre"].ToString();
                textApellido.Text = leido["apellido"].ToString();
                textTelefono.Text = leido["telefono"].ToString();
                textHora.Text = leido["hora"].ToString();
                comboMesa.Text = leido["numero"].ToString();
                textPosicion.Text = leido["Posicion"].ToString();
                textSeña.Text = leido["numeroDeReserva"].ToString();
                comboTurno.Text = leido["turno"].ToString();
                textcomensal.Text = leido["cantDePersona"].ToString();

                //---PARA PODER PONER LA FECHA EN EL DATATIMEPICKER---

                string hola = leido["fecha"].ToString();

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
            leido.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
