using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace BAREST.Compras
{
    public partial class Compras : Form
    {

        public Compras()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si txtCantidad está nulo o vacío
                if (string.IsNullOrWhiteSpace(textCantidad.Text))
                {
                    MessageBox.Show("Tienes que completar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SumarSiExiste();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool SumarSiExiste()
        {
            if (comboInsumo.SelectedValue != null && comboProv.SelectedValue != null)
            {
                int InsumoId = Convert.ToInt32(comboInsumo.SelectedValue);

                int ProveedorId = Convert.ToInt32(comboProv.SelectedValue);

                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("SELECT SUM(cantidad) FROM [dbo].[Compra] WHERE IdInsumo = @IdInsumo AND idProveedor = @idProveedor AND estado IN ('A', 'P')", conexion))
                    {
                        comando.Parameters.AddWithValue("@IdInsumo", InsumoId);
                        comando.Parameters.AddWithValue("@idProveedor", ProveedorId);

                        object result = comando.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int cantidadSumada = Convert.ToInt32(result);
                            int cantidadNueva = Convert.ToInt32(textCantidad.Text);
                            int cantidadTotal = cantidadSumada + cantidadNueva;

                            MessageBox.Show("Se agregó la cantidad al pedido pendiente. Cantidad total: " + cantidadTotal);

                            // Aquí puedes realizar la actualización de la base de datos para reflejar la nueva cantidad.
                            using (var comando1 = new SqlCommand("UPDATE [dbo].[Compra] SET [cantidad] = @cantidadTotal WHERE IdInsumo = @IdInsumo AND idProveedor = @idProveedor  AND estado IN ('A', 'P')", conexion))
                            {
                                comando1.Parameters.AddWithValue("@IdInsumo", InsumoId);
                                comando1.Parameters.AddWithValue("@idProveedor", ProveedorId);
                                comando1.Parameters.AddWithValue("@cantidadTotal", cantidadTotal);
                                comando1.Parameters.AddWithValue("@fecha", DateTime.Now);
                                comando1.ExecuteNonQuery();

                            }
                            MessageBox.Show("Se ha sumado la compra pendiente una suma de:." + cantidadNueva);
                        }
                        else
                        {
                            int proveedorId = Convert.ToInt32(comboProv.SelectedValue);
                            int insumoId = Convert.ToInt32(comboInsumo.SelectedValue);
                            int cantidad = Convert.ToInt32(textCantidad.Text);
                            string especificacion = textEspecificacion.Text;

                            using (SqlCommand comando2 = new SqlCommand(" INSERT INTO [dbo].[Compra] ([idProveedor], [idInsumo], [cantidad], [espec], [fecha], [estado]) VALUES (@proveedorId, @insumoId, @cantidad, @especificacion, GETDATE(), 'P') ", conexion))
                            {
                                comando2.Parameters.AddWithValue("@proveedorId", proveedorId);
                                comando2.Parameters.AddWithValue("@insumoId", insumoId);
                                comando2.Parameters.AddWithValue("@cantidad", cantidad);
                                comando2.Parameters.AddWithValue("@especificacion", especificacion);
                                comando2.ExecuteNonQuery();
                            }
                            MessageBox.Show("Se ha registrado la compra correctamente.");
                        }

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al sumar el insumo en la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        private void BuscarProveedor()
        {
            try
            {
                Conexion.ObtenerConexion();
                string sql = "SELECT idProveedor, empresa FROM Proveedor WHERE estado = 'A'";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                SqlDataAdapter adaptador1 = new SqlDataAdapter(comando);
                DataTable tabla1 = new DataTable();
                adaptador1.Fill(tabla1);
                comboProv.DisplayMember = "empresa";
                comboProv.ValueMember = "idProveedor";
                comboProv.DataSource = tabla1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }

        private void Buscarinsumo()
        {
            try
            {
                Conexion.ObtenerConexion();
                string sql = "SELECT idInsumo, descripcion FROM Insumo WHERE estado = 'A'";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                SqlDataAdapter adaptador1 = new SqlDataAdapter(comando);
                DataTable tabla1 = new DataTable();
                adaptador1.Fill(tabla1);
                comboInsumo.DisplayMember = "descripcion";
                comboInsumo.ValueMember = "idInsumo";
                comboInsumo.DataSource = tabla1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los insumos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }

        void LimpiarCampos()
        {
            comboProv.SelectedIndex = -1;
            comboInsumo.SelectedIndex = -1;
            textCantidad.Text = "";
            textEspecificacion.Text = "";
        }

        private void CargarTabla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT [idCompra], [Proveedor].empresa proveedor , [Insumo].descripcion insumo, [COmpra].cantidad, [Compra].espec, [Compra].fecha FROM [dbo].[Compra] INNER JOIN Proveedor ON Compra.idProveedor= Proveedor.idProveedor  INNER JOIN Insumo ON Compra.idInsumo = Insumo.idInsumo", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    dataCompras.Rows.Clear();

                    while (registros.Read())
                    {
                        
                        dataCompras.Rows.Add(
                            registros["idCompra"].ToString(),
                            registros["Proveedor"].ToString(),
                            registros["insumo"].ToString(),
                            registros["cantidad"].ToString(),
                            registros["espec"].ToString(),
                            Convert.ToDateTime(registros["fecha"]).ToString("dd/MM/yyyy")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }



        private void Compras_Load(object sender, EventArgs e)
        {
            Buscarinsumo();
            BuscarProveedor();
            CargarTabla();
            LimpiarCampos();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Actualizar el estado a 'D' (Cancelar) para la compra seleccionada en dataCompras.
            if (dataCompras.SelectedRows.Count > 0)
            {
                string idCompra = dataCompras.SelectedRows[0].Cells["idCompra"].Value.ToString();
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string sql = "DELETE FROM Compra WHERE idCompra = @idCompra";
                        using (SqlCommand comando = new SqlCommand(sql, conexion))
                        {
                            comando.Parameters.AddWithValue("@idCompra", idCompra);
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Compra eliminada correctamente.");
                    CargarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la compra:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT [idCompra], [Proveedor].empresa proveedor, [Insumo].descripcion insumo, [Compra].cantidad, [Compra].espec, [Compra].fecha FROM [dbo].[Compra] INNER JOIN Proveedor ON Compra.idProveedor= Proveedor.idProveedor  INNER JOIN Insumo ON Compra.idInsumo = Insumo.idInsumo", conexion))
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaDatos = new DataTable();
                    adaptador.Fill(tablaDatos);

                    // Crear un nuevo libro de Excel usando ClosedXML
                    using (var workbook = new XLWorkbook())
                    {
                        // Agregar una hoja al libro
                        var worksheet = workbook.Worksheets.Add("Datos");

                        // Rellenar la hoja con los datos del DataTable
                        worksheet.Cell(1, 1).InsertTable(tablaDatos.AsEnumerable());

                        // Guardar el libro de Excel
                        var saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Archivos Excel|*.xlsx";
                        saveFileDialog.Title = "Guardar como archivo Excel";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // lo voy a usar despues de entregar el proyecto.
        private void VisualizarPorProveedor()
        {
            // Mostrar las compras asociadas al proveedor seleccionado en comboProv.
            if (comboProv.SelectedValue != null)
            {
                int proveedorId = Convert.ToInt32(comboProv.SelectedValue);
                try
                {
                    Conexion.ObtenerConexion();
                    string sql = "SELECT [idCompra], [idProveedor], [idInsumo], [cantidad], [espec], [Estado], [fecha] FROM [dbo].[Compra] WHERE IdProveedor = @proveedorId";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.AddWithValue("@proveedorId", proveedorId);
                    SqlDataAdapter adaptador1 = new SqlDataAdapter(comando);
                    DataTable tabla1 = new DataTable();
                    adaptador1.Fill(tabla1);
                    dataCompras.DataSource = tabla1;

                    // Modificar los valores de la columna "Estado" según los criterios indicados en los comentarios.
                    foreach (DataGridViewRow row in dataCompras.Rows)
                    {
                        if (row.Cells["Estado"].Value.ToString() == "A")
                        {
                            row.Cells["Estado"].Value = "HECHO";
                        }
                        else if (row.Cells["Estado"].Value.ToString() == "P")
                        {
                            row.Cells["Estado"].Value = "PENDIENTE";
                        }
                        else if (row.Cells["Estado"].Value.ToString() == "L" && (DateTime.Now - Convert.ToDateTime(row.Cells["fecha"].Value)).Days > 3)
                        {
                            row.Cells["Estado"].Value = "DEMORADO";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las compras del proveedor:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conexion.ObtenerConexion().Close();
                }
            }
        }


        private void btnlista_Click(object sender, EventArgs e)
        {
            ListaCompras i = new ListaCompras();
            i.ShowDialog();
        }
    }
}
