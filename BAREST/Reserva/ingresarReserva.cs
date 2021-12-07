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

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text=="")
            {
                MessageBox.Show("Falta agregar un nombre");
            }
            else
            {

                if (ClaseCompartida.Insum3 == "")
                {
                    Conexion.ObtenerConexion();
                    string sql = "insert into Reserva (nombre,telefono,apellido,fechaReserva,posicion,cantComensales,hora,comentarios,estado) values (@nombre, @telefono,@apellido,@fecha,@posicion,@cant,@hora,@com, 'DISPONIBLE')";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTelefono.Text;
                    comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = textcant.Text;

                    comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                    comando.Parameters.Add("@hora", SqlDbType.Char).Value = textHora.Text;
                    comando.Parameters.Add("@posicion", SqlDbType.VarChar).Value = textPosicion.Text;
                    comando.Parameters.Add("@com", SqlDbType.VarChar).Value = textcom.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("La reserva de " + textNombre.Text + " se registro correctamente");
                    Conexion.ObtenerConexion().Close();
                    textNombre.Text = " ";
                    textApellido.Text = " ";
                    textcant.Text = " ";

                    dateTimePicker1.Value = DateTime.Now;
                    textHora.Text = " ";
                    textPosicion.Text = " ";
                    textcom.Text = "";
                    this.Close();

                }
                else
                {
                    Conexion.ObtenerConexion();
                    string sql = "update Reserva set nombre= @nombre, apellido= @apellido, telefono= @telefono, fechaReserva= @fecha, cantComensales= @cant, posicion= @posicion, hora= @hora, comentarios= @com where nombre=@nombre";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ClaseCompartida.Insum3;
                    comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApellido.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTelefono.Text;
                    comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = textcant.Text;
                    comando.Parameters.Add("@fecha", SqlDbType.Date).Value = dateTimePicker1.Value;
                    comando.Parameters.Add("@hora", SqlDbType.Char).Value = textHora.Text;
                    comando.Parameters.Add("@posicion", SqlDbType.VarChar).Value = textPosicion.Text;
                    comando.Parameters.Add("@com", SqlDbType.VarChar).Value = textcom.Text;
                    int cant = comando.ExecuteNonQuery();
                    if (cant != 0)
                    {
                        MessageBox.Show("Los datos se modificaron correctamente");
                        this.Close();
                    }
                    Conexion.ObtenerConexion().Close();
                }
            }
        }

        private void ingresarReserva_Load(object sender, EventArgs e)
        {
            if (ClaseCompartida.Insum3 == "")
            {
             //   cargarComboMesa();
               // cargarcomboTurno();
            }
            else
            {
                cargarModificacion();
            }
        }

        private void cargarModificacion()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,telefono,fechaReserva,posicion,cantComensales,hora,comentarios from Reserva where nombre = @nombre";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ClaseCompartida.Insum3;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textNombre.Text = leido["nombre"].ToString();
                textApellido.Text = leido["apellido"].ToString();
                textTelefono.Text = leido["telefono"].ToString();
                dateTimePicker1.Text = leido["fechaReserva"].ToString();
                textPosicion.Text = leido["posicion"].ToString();
                textcant.Text = leido["cantcomensales"].ToString();
                textHora.Text = leido["hora"].ToString();
                textcom.Text = leido["comentarios"].ToString();

                //---PARA PODER PONER LA FECHA EN EL DATATIMEPICKER---

                string hola = leido["fechaReserva"].ToString();

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
