using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class listadoProveedor : Form
    {
        public listadoProveedor()
        {
            InitializeComponent();
        }

        private void listadoProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion()) 
                using (var comando = new SqlCommand("SELECT cuit, empresa, telefono, direccion, altura, depto, archivo FROM Proveedor WHERE estado ='A'", conexion))
                using (SqlDataReader registros = comando.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    // Agregar las columnas necesarias al DataGridView
                    dataGridView1.Columns.Add("cuit", "CUIT");
                    dataGridView1.Columns.Add("empresa", "Empresa");
                    dataGridView1.Columns.Add("telefono", "Teléfono");
                    dataGridView1.Columns.Add("direccion", "Dirección");
                    dataGridView1.Columns.Add("altura", "Altura");
                    dataGridView1.Columns.Add("depto", "Depto");
                    dataGridView1.Columns.Add("archivo", "Archivo");

                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add(
                            registros["cuit"].ToString(),
                            registros["empresa"].ToString(),
                            registros["telefono"].ToString(),
                            registros["direccion"].ToString(),
                            registros["altura"].ToString(),
                            registros["depto"].ToString(),
                            registros["archivo"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los proveedores en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
