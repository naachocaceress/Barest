using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
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
                using (var comando = new SqlCommand("SELECT cuit, empresa, telefono, direccion, altura, depto, archivo, nombreArchivo FROM Proveedor WHERE estado ='A'", conexion))
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
                    dataGridView1.Columns.Add("nombreArchivo", "Nombre de Archivo"); // Cambiado el nombre de la columna

                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add(
                            registros["cuit"].ToString(),
                            registros["empresa"].ToString(),
                            registros["telefono"].ToString(),
                            registros["direccion"].ToString(),
                            registros["altura"].ToString(),
                            registros["depto"].ToString(),
                            registros["nombreArchivo"].ToString() // Mostrar el nombre del archivo
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los proveedores en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic se realizó en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["nombreArchivo"].Index)
            {
                // Obtener el nombre del archivo desde la celda
                string nombreArchivo = dataGridView1.Rows[e.RowIndex].Cells["nombreArchivo"].Value.ToString();

                // Obtener el contenido del archivo desde la base de datos
                byte[] contenidoArchivo = ObtenerContenidoArchivoDesdeBaseDeDatos(nombreArchivo);

                // Verificar si se pudo obtener el contenido del archivo
                if (contenidoArchivo != null && contenidoArchivo.Length > 0)
                {
                    // Preguntar al usuario dónde desea guardar el archivo
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.FileName = nombreArchivo;

                        // Mostrar el cuadro de diálogo para guardar el archivo
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Guardar el archivo en la ubicación seleccionada por el usuario
                                File.WriteAllBytes(saveFileDialog.FileName, contenidoArchivo);

                                // Informar al usuario que la descarga se realizó correctamente
                                MessageBox.Show("Archivo descargado correctamente.", "Descarga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                // Mostrar un mensaje de error si la descarga falla
                                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // Informar al usuario si no se pudo obtener el contenido del archivo
                    MessageBox.Show("No se pudo obtener el contenido del archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] ObtenerContenidoArchivoDesdeBaseDeDatos(string nombreArchivo)
        {
            try
            {
                // Realizar la lógica para obtener el contenido del archivo desde la base de datos
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT archivo FROM Proveedor WHERE nombreArchivo = @nombreArchivo", conexion))
                {
                    comando.Parameters.AddWithValue("@nombreArchivo", nombreArchivo);
                    object resultado = comando.ExecuteScalar();

                    // Verificar si el resultado no es nulo
                    if (resultado != DBNull.Value)
                    {
                        // Convertir el resultado a un arreglo de bytes
                        return (byte[])resultado;
                    }
                }

                // Informar al usuario que el archivo no se encontró
                MessageBox.Show("El archivo no se encontró en la base de datos.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al obtener el contenido del archivo
                MessageBox.Show("Error al obtener el contenido del archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
