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
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTabla()
        {
            Conexion.ObtenerConexion();
            string sql = "Select c.id, r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["id"].ToString(), registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            ClaseCompartida.Insum2 = 0;
            ingresarReserva i = new ingresarReserva();
            i.ShowDialog();
            cargarTabla();
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar reserva", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete from reserva where idcliente = @descripcion";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@descripcion", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó la reserva");
                cargarTabla();
                Conexion.ObtenerConexion().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "Select r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "Select r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id where fecha  between @d1 and @d2 ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@d1", SqlDbType.Date).Value = dateTimePicker1.Value;
            comando.Parameters.Add("@d2", SqlDbType.Date).Value = dateTimePicker2.Value;
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private bool fechaExiste()
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Reserva where fecha= @date1";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@date1", SqlDbType.Date).Value = dateTimePicker1.Value;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            return existe;
            Conexion.ObtenerConexion().Close();
        }

        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reservas.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.A4);

            documento.SetMargins(60,20,55,20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Id", "Nombre", "PAX", "Hora", "Fecha", "Telefono", "Seña" };

            float[] tamanios = { 2, 4, 2, 3, 3, 4, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            Conexion.ObtenerConexion();
            string sql = "Select c.id, r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(registros["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["cantDePersona"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["hora"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["fecha"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["telefono"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(registros["numeroDeReserva"].ToString()).SetFont(fontContenido)));
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();

            documento.Add(tabla);
            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Nacho/OneDrive/Escritorio/Nacho6/ISSD/BAREST/Imagenes/Login/Barest.png")).SetWidth(50);
            var PLOGO = new Paragraph("").Add(logo);
            var titulo = new Paragraph("RESERVAS");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reservas.pdf"), new PdfWriter("ReservasProducto.pdf"));
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            crearPDF();
            MessageBox.Show("Se imprimio correctamente");
        }

        private void cargarRubro()
        {
            Conexion.ObtenerConexion();
            string sql = "select descripcion from Reserva";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        public static class ClaseCompartida
        {
            public static int Insum2 = 0;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string Insum = "";
            Insum = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString();   
            ingresarReserva i = new ingresarReserva();
            ClaseCompartida.Insum2 = Int32.Parse(Insum);
            i.ShowDialog();
            cargarTabla();
        }
    }
}
