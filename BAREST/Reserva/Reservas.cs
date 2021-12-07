using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechaLabel.Text = DateTime.Now.ToLongDateString();
            btnActualMes.Text = DateTime.Now.ToString("MMMM").ToUpper();
            btnAnteriorMes.Text = DateTime.Now.AddMonths(-1).ToString("MMMM").ToUpper(); 
        }
        
        public void cargarTabla()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,cantComensales,hora,fechaReserva,posicion,telefono,comentarios, estado from Reserva" +
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
        }

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
        }

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

        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reservas.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.A4);

            documento.SetMargins(60,20,55,20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Nombre", "Apellido", "PAX", "Hora", "Fecha", "Mesa", "Estado"};

            float[] tamanios = { 2, 4, 2, 3, 3, 4, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            Conexion.ObtenerConexion();
            string sql = "select nombre,apellido,cantComensales,hora,fechaReserva,posicion, estado from Reserva" +
                " group by fechaReserva,apellido,nombre,cantComensales,posicion, hora, estado";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(registros["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["apellido"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["cantComensales"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["hora"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["fechaReserva"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["posicion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["estado"].ToString()).SetFont(fontContenido)));
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Nacho/OneDrive/Escritorio/Nacho6/ISSD/BAREST/Recursos/Barest (NUEVO COLOR).png")).SetWidth(50);
            var PLOGO = new Paragraph("").Add(logo);
            var titulo = new Paragraph("RESERVAS");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reservas.pdf"), new PdfWriter("C:/Users/Nacho/OneDrive/Escritorio/ReservasVidonAlta.pdf"));
            Document doc = new Document(pdfDoc);

            int numero = pdfDoc.GetNumberOfPages();

            for(int i = 1; i<= numero;i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);
                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(PLOGO, 40, y + 8, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Pagina {0} de {1}", i, numero)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0); 
            }
            doc.Close();
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
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }
    }
}
