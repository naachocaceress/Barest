using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BAREST.Ventas
{
    public partial class EstadisticasVtas : Form
    {
        public EstadisticasVtas()
        {
            InitializeComponent();
        }

        public int efect, tarj, transf;

        private void EstadisticasVtas_Load(object sender, EventArgs e)
        {
            string[] series = { "Efectivo", "Transferencia", "Tarjeta" };
            int[] puntos = { efect, transf, tarj };

            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Forma de cobro");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
    }
}
