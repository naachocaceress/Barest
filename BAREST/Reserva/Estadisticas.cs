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
            chart1.Titles.Add("Anuladas");
            GrafReservas();
        }

        ArrayList cate = new ArrayList();
        ArrayList cant = new ArrayList();

        public void GrafReservas()
        {
            Conexion.ObtenerConexion();
            string sql = "select count (estado) [ANULADAS] from Reserva where estado = 'ANULADA' union select count(estado)[DISPONIBLE] from Reserva where estado = 'DISPONIBLE'";
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
    }
}
