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
using System.Windows.Forms.DataVisualization.Charting;

namespace BAREST.Cajas
{
    public partial class EstadisticasCajas : Form
    {
        public EstadisticasCajas()
        {
            InitializeComponent();
        }

        private void EstadisticasCajas_Load(object sender, EventArgs e)
        {
            MostrarGraficoPastel();
            //MostrarGraficoSumaMontos();
        }

        private void MostrarGraficoPastel()
        {
            // Obtener los datos de la base de datos y agrupar por condición
            DataTable dataTable = ObtenerDatosDesdeLaBaseDeDatos();

            // Crear un diccionario para almacenar las cantidades de cada condición
            Dictionary<string, int> cantidadesPorCondicion = new Dictionary<string, int>();

            // Procesar los datos de la tabla para obtener las cantidades por condición
            foreach (DataRow row in dataTable.Rows)
            {
                string condicion = row["condicion"].ToString();
                int cantidad = Convert.ToInt32(row["cantidad"]);

                // Si ya existe la condición en el diccionario, se suma la cantidad
                if (cantidadesPorCondicion.ContainsKey(condicion))
                {
                    cantidadesPorCondicion[condicion] += cantidad;
                }
                // Si no existe, se agrega al diccionario
                else
                {
                    cantidadesPorCondicion.Add(condicion, cantidad);
                }
            }

            // Limpiar los puntos de datos actuales del Chart (si es necesario)
            chart1.Series[0].Points.Clear();

            // Agregar las cantidades al Chart y configurar para mostrar tanto palabras como cantidades
            foreach (var kvp in cantidadesPorCondicion)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(1, kvp.Value);
                dataPoint.Label = kvp.Value.ToString();
                dataPoint.LabelToolTip = "Cantidad: " + kvp.Value;
                dataPoint.LegendText = kvp.Key + " (" + kvp.Value + ")";
                chart1.Series[0].Points.Add(dataPoint);
            }

            // Configurar el gráfico para que sea de tipo pastel
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0]["PieLabelStyle"] = "Outside";
            chart1.Series[0]["PieLineColor"] = "Black";
            chart1.Legends[0].Enabled = true;
            chart1.Titles.Clear();
            chart1.Titles.Add("Total de operaciones");
        }

        private void MostrarGraficoSumaMontos()
        {
                // Obtener los datos de la base de datos
                DataTable dataTable = ObtenerDatosDesdeLaBaseDeDatos();

                // Crear un diccionario para almacenar las sumas de montos por condición
                Dictionary<string, decimal> sumasMontosPorCondicion = new Dictionary<string, decimal>();

                // Calcular la suma de montos por condición
                foreach (DataRow row in dataTable.Rows)
                {
                    string condicion = row["condicion"].ToString();
                    decimal monto = Convert.ToDecimal(row["monto"]);

                    // Si ya existe la condición en el diccionario, se suma el monto
                    if (sumasMontosPorCondicion.ContainsKey(condicion))
                    {
                        sumasMontosPorCondicion[condicion] += monto;
                    }
                    // Si no existe, se agrega al diccionario
                    else
                    {
                        sumasMontosPorCondicion.Add(condicion, monto);
                    }
                }

                // Limpiar los puntos de datos actuales del Chart2 (si es necesario)
                chart2.Series[0].Points.Clear();

                // Agregar las sumas al Chart2
                foreach (var kvp in sumasMontosPorCondicion)
                {
                    string condicion = kvp.Key;
                    decimal sumaMontos = kvp.Value;

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueXY(condicion, sumaMontos);
                    dataPoint.Label = sumaMontos.ToString("C"); // Mostrar la suma de montos como moneda (por ejemplo: $100.00)
                    dataPoint.LabelToolTip = "Suma de Montos: " + sumaMontos.ToString("C");
                    dataPoint.LegendText = condicion + " (" + sumaMontos.ToString("C") + ")";
                    chart2.Series[0].Points.Add(dataPoint);
                }

                // Configurar el gráfico para que sea de tipo columnas agrupadas
                chart2.Series[0].ChartType = SeriesChartType.Column;
                chart2.Series[0]["BarLabelStyle"] = "Outside";
                chart2.Legends[0].Enabled = true;
                chart2.Titles.Clear();
                chart2.Titles.Add("Suma de Montos por Condición");
            
        }


        // Método para obtener los datos desde la base de datos
        private DataTable ObtenerDatosDesdeLaBaseDeDatos()
        {
            // Aquí debes realizar la consulta SQL para obtener los datos
            // y retornarlos en una DataTable
            // Por ejemplo:
            string sqlQuery = "SELECT condicion, COUNT(*) as cantidad FROM CajaChica GROUP BY condicion;";

            using (SqlConnection connection = Conexion.ObtenerConexion())
            {
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                return dataTable;
            }
        }

    }
}
