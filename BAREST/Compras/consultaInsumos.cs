using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class consultaInsumos : Form
    {
        public consultaInsumos()
        {
            InitializeComponent();
        }

        private void consultaInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT Insumo.descripcion, Insumo.cantidad, Insumo.unidad, RubroInsumo.descripcion rubro, Insumo.fechaIngreso FROM Insumo INNER JOIN RubroInsumo ON Insumo.idrubroInsumo = RubroInsumo.idRubroInsumo WHERE Insumo.estado = 'A' ORDER BY LTRIM(Insumo.descripcion) ASC", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaInsumo.Rows.Clear();
                    tablaInsumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    while (registros.Read())
                    {
                        string descripcion = registros["descripcion"].ToString();
                        int cantidad = Convert.ToInt32(registros["cantidad"]);
                        string unidad = registros["unidad"].ToString();
                        string rubro = registros["rubro"].ToString();
                        DateTime fechaIngreso = (DateTime)registros["fechaIngreso"];
                        tablaInsumo.Rows.Add(descripcion, cantidad, unidad, rubro, fechaIngreso);
                    }

                    registros.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del Insumo en la tablaInsumo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
