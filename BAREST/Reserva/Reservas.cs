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
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservasTitulo_Click(object sender, EventArgs e)
        {

        }
        public void cargarTabla()
        {
            Cone.Open();
            string sql = "Select r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id ";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            ingresarReserva i = new ingresarReserva();
            i.ShowDialog();
         // Reserva.AgregarReserva m = Reserva.AgregarReserva();
         // m.ShowDialog();

        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            
            Cone.Open();
            string sql = "update Reserva set cantDePersona ='5', hora='23:00',numeroDeReserva='500' where fecha = @date ";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value;
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "Select r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id ";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "Select r.cantDePersona,r.fecha,r.hora,r.numeroDeReserva,c.nombre,c.telefono from Reserva r Join Cliente c on r.idCliente = c.id where fecha  between @d1 and @d2 ";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@d1", SqlDbType.Date).Value = dateTimePicker1.Value;
            comando.Parameters.Add("@d2", SqlDbType.Date).Value = dateTimePicker2.Value;
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["cantDePersona"].ToString(), registros["hora"].ToString(), registros["fecha"].ToString(), registros["telefono"].ToString(), registros["numeroDeReserva"].ToString());
            }
            registros.Close();
            Cone.Close();
        }
        private bool fechaExiste()
        {
            Cone.Open();
            string sql = "select * from Reserva where fecha= @date1";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@date1", SqlDbType.Date).Value = dateTimePicker1.Value;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            Cone.Close();
            return existe;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void cargarRubro()
        {
            Cone.Open();
            string sql = "select descripcion from Reserva";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            /* Font font = new Font("Arial", 14);
             int ancho = 150;
             int y = 30;
             e.Graphics.DrawString("---- BAREST ----", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
             e.Graphics.DrawString("Reserva# ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

             foreach (DataRow row in dataGridView1.Rows)
             {
                 e.Graphics.DrawString(row["nombre"].ToString() + " " +
                     row["cantDePersona"].ToString() + " " +
                     row["hora"].ToString() + " " +
                     row["fecha"].ToString() + " " +
                     row["telefono"].ToString() + " " +
                     row["numeroDeReserva"].ToString() + " "
                     , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
             }*/
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "pdf";

            PrintPreviewDialog ps = new PrintPreviewDialog { Document = doc };
            ((Form)ps).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Green, left, top);
                    //avanzar el margen de la cabeza
                    left += col.Width;

                    if (col.Index < dataGridView1.Columns.Count - 1)

                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dataGridView1.RowCount - 1) * DGV_ALTO);

                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dataGridView1.Rows)

                {
                    if (row.Index == dataGridView1.Rows.Count - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 12), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Red, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
        }
    }
}
