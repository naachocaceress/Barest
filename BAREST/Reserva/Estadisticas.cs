using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace BAREST.Reserva
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            GrafTotal();
        }

        ArrayList cate = new ArrayList();
        ArrayList cant = new ArrayList();

        ArrayList cate1 = new ArrayList();
        ArrayList cant1 = new ArrayList();

        public void GrafTotalAnuladas()
        {
            cate1.Clear();
            cant1.Clear();

            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            chart4.Visible = false;

            chart2.Titles.Add("Reservas Anuladas y Disponibles");
            Conexion.ObtenerConexion();
            string sql = "select Estado, count (estado) [Cantidad] from Reserva where estado = 'ANULADA' group by estado union select Estado, count(estado) from Reserva where estado = 'DISPONIBLE' group by estado ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                cate1.Add(registros.GetString(0));
                cant1.Add(registros.GetInt32(1));
            }
            chart2.Series[0].Points.DataBindXY(cate1, cant1);
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        public void GrafTotal()
        {
            chart1.Titles.Add("Reservas totales");
            Conexion.ObtenerConexion();
            string sql = "select count (*) as TotalReservas from Reserva";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                cate.Add(registros.GetInt32(0));
                cant.Add(registros.GetInt32(0));
            }
            chart1.Series[0].Points.DataBindXY(cate, cant);
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            GrafTotalAnuladas();
        }

        ArrayList cate2 = new ArrayList();
        ArrayList cant2 = new ArrayList();

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cate2.Clear();
            cant2.Clear();

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
            chart4.Visible = false;

            chart3.Titles.Add("Reservas Anuladas y Disponibles del mes actual");
            Conexion.ObtenerConexion();
            string sql = "select Estado, (select count (*) [DICIEMBRE] from Reserva where datepart(mm, fechaReserva) = datepart(mm, getdate()) AND estado = 'ANULADA')  from Reserva where estado = 'ANULADA' group by estado union select Estado, (select count(*)[DICIEMBRE] from Reserva where datepart(mm, fechaReserva) = datepart(mm, getdate()) AND estado = 'DISPONIBLE') from Reserva where estado = 'DISPONIBLE' group by estado";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                cate2.Add(registros.GetString(0));
                cant2.Add(registros.GetInt32(1));
            }
            chart3.Series[0].Points.DataBindXY(cate2, cant2);
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        ArrayList cate3 = new ArrayList();
        ArrayList cant3 = new ArrayList();
        private void iconButton2_Click(object sender, EventArgs e)
        {
            cate3.Clear();
            cant3.Clear();

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = true;

            chart4.Titles.Add("Reservas Anuladas y Disponibles del mes pasado");
            Conexion.ObtenerConexion();
            string sql = "select Estado, (SELECT count (*) [NOVIEMBRE] FROM Reserva WHERE MONTH(fechaReserva) = MONTH(getdate()) - 1 AND estado = 'ANULADA')  from Reserva where estado = 'ANULADA' group by estado union select Estado, (SELECT count(*)[NOVIEMBRE] FROM Reserva WHERE MONTH(fechaReserva) = MONTH(getdate()) - 1 AND estado = 'DISPONIBLE') from Reserva where estado = 'DISPONIBLE' group by estado ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                cate3.Add(registros.GetString(0));
                cant3.Add(registros.GetInt32(1));
            }
            chart4.Series[0].Points.DataBindXY(cate3, cant3);
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
