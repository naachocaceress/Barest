using BAREST.Reserva;
using ClosedXML.Excel;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

//todos los codigos que se encuentra dentro una region es porque  están funcionando perfecto. el nombre es para poder identificarlo bien
namespace BAREST
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cantReservasHoy();
            timer1.Enabled = true;
        }

        string ScantReservasHoy = "", ScantPAXHoy;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            fechaLabel.Text = "Hoy " + hoy.ToString("M") + " hay " + ScantReservasHoy + " reservas con " + ScantPAXHoy + " PAX en total";
            btnActualMes.Text = DateTime.Now.ToString("MMMM").ToUpper();
            btnAnteriorMes.Text = DateTime.Now.AddMonths(-1).ToString("MMMM").ToUpper();
        }

        public void cantReservasHoy()
        {
            Conexion.ObtenerConexion();
            string sql = "select count (cantComensales) from Reserva where datepart(dd, fechaReserva) = datepart(dd, getdate()) and estado = 'DISPONIBLE'";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                int num = (registros.GetInt32(0));
                ScantReservasHoy = num.ToString();
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            cantPAXHoy();
        }

        public void cantPAXHoy()
        {
            if (ScantReservasHoy == "0")
            {
                ScantPAXHoy = "0";
                //MessageBox.Show("Hoy no hay reservas");
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "SELECT sum (cantComensales) from Reserva where datepart(dd, fechaReserva) = datepart(dd, getdate()) and estado = 'DISPONIBLE'";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    int num = (registros.GetInt32(0));
                    ScantPAXHoy = num.ToString();
                }
                registros.Close();
                Conexion.ObtenerConexion().Close();
            }
        }

        public void cargarTabla()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,cantComensales,hora,fechaReserva,posicion,telefono,comentarios, estado from Reserva WHERE sucursal='Alta Cordoba'" +
                " group by fechaReserva,apellido,telefono,nombre,comentarios,cantComensales,posicion, hora, estado";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void btnAgregarRes_Click(object sender, EventArgs e)
        {
            ClaseCompartida.Insum3 = "";
            ingresarReserva i = new ingresarReserva();
            i.ShowDialog();
            cargarTabla();
            cantReservasHoy();
        }

        #region  Anulacion y recuperacion de  estado de reserva  disponible o anulado
        private void btnAnuRecu_Click(object sender, EventArgs e)
        {
            string Insum0 = "";
            Insum0 = tablaReservas.Rows[tablaReservas.CurrentRow.Index].Cells["Estado"].Value.ToString();

            if (Insum0 == "ANULADA")
            {
                string Insum = "";
                Insum = tablaReservas.Rows[tablaReservas.CurrentRow.Index].Cells["nombre"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "update Reserva set estado = 'DISPONIBLE' where nombre = @nombre";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@nombre", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se recupero la reserva");
                Conexion.ObtenerConexion().Close();
                cargarTabla();
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere anular?", "Anular reserva", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string Insum = "";
                    Insum = tablaReservas.Rows[tablaReservas.CurrentRow.Index].Cells["nombre"].Value.ToString();
                    Conexion.ObtenerConexion();
                    string sql = "update Reserva set estado = 'ANULADA' where nombre = @nombre";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.AddWithValue("@nombre", Insum);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se anuló la reserva");
                    Conexion.ObtenerConexion().Close();
                    cargarTabla();
                }
            }
            cantReservasHoy();
        }
        #endregion

        #region Cambio de cuando el estado de la reserva es anulado
        public void anuladas()
        {
            tablaReservas.Rows.Cast<DataGridViewRow>().
                        ToList().
                        ForEach(fila =>
                        {
                            switch (fila.Cells["Estado"].Value.ToString())
                            {
                                case "ANULADA":
                                    fila.DefaultCellStyle.BackColor = Color.Tomato;
                                    break;
                            }
                        });
        }
        #endregion

        private void crearPDF()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT nombre, apellido, cantComensales, hora, fechaReserva, posicion, estado FROM Reserva" +
                                                   " GROUP BY fechaReserva, apellido, nombre, cantComensales, posicion, hora, estado", conexion))
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaDatos = new DataTable();
                    adaptador.Fill(tablaDatos);

                    // Crear un nuevo libro de Excel usando ClosedXML
                    using (var workbook = new XLWorkbook())
                    {
                        // Agregar una hoja al libro
                        var worksheet = workbook.Worksheets.Add("Reservas");

                        // Rellenar la hoja con los datos del DataTable
                        worksheet.Cell(1, 1).InsertTable(tablaDatos.AsEnumerable(), "Reservas", true);

                        // Guardar el libro de Excel
                        var saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Archivos Excel|*.xlsx";
                        saveFileDialog.Title = "Guardar como archivo Excel";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Datos de reservas exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar datos de reservas a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            crearPDF();
            MessageBox.Show("Se imprimio correctamente");
        }

        public static class ClaseCompartida
        {
            //public static int Insum2 = 0;
            public static string Insum3 = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Insum = "";
            Insum = tablaReservas.Rows[tablaReservas.CurrentRow.Index].Cells["nombre"].Value.ToString();
            ingresarReserva i = new ingresarReserva();
            ClaseCompartida.Insum3 = Insum;
            i.ShowDialog();
            cargarTabla();
            cantReservasHoy();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,telefono,fechaReserva,comentarios,cantComensales,posicion,hora, estado from Reserva  where fechaReserva  between @d1 and @d2 " +
                "group by fechaReserva,apellido,telefono,nombre,comentarios,cantComensales,posicion, hora, estado";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@d1", SqlDbType.Date).Value = dateTimePicker1.Value;
            comando.Parameters.Add("@d2", SqlDbType.Date).Value = dateTimePicker2.Value;
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void btnAnteriorMes_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "SELECT * FROM Reserva WHERE MONTH(fechaReserva) = MONTH(getdate()) - 1";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void btnActualMes_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "SELECT * FROM Reserva where datepart(mm, fechaReserva) = datepart(mm, getdate())";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Reserva where fechaReserva=CONVERT(DATE,GETDATE()) ORDER BY fechaReserva DESC";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void btnEliminarRes_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere eliminar la reserva?", "Eliminar reserva", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = tablaReservas.Rows[tablaReservas.CurrentRow.Index].Cells["nombre"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete  from Reserva where nombre = @nombre";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@nombre", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó la reserva: " + Insum);
                Conexion.ObtenerConexion().Close();
                cargarTabla();
                cantReservasHoy();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");

            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,telefono,fechaReserva,comentarios,cantComensales,posicion,hora, estado from Reserva  where fechaReserva = @d1 group by fechaReserva,apellido,telefono,nombre,comentarios,cantComensales,posicion, hora, estado";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@d1", SqlDbType.Date).Value = startDate;
            SqlDataReader registros = comando.ExecuteReader();
            tablaReservas.Rows.Clear();
            while (registros.Read())
            {
                tablaReservas.Rows.Add(registros["nombre"].ToString(), registros["apellido"].ToString(), registros["cantComensales"].ToString(), registros["hora"].ToString(), registros["fechaReserva"].ToString(), registros["posicion"].ToString(), registros["telefono"].ToString(), registros["comentarios"].ToString(), registros["estado"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
            anuladas();
        }

        private void tablaReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas i = new Estadisticas();
            i.ShowDialog();
        }
    }
}
