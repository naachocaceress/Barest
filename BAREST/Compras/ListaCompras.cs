using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class ListaCompras : Form
    {
        public ListaCompras()
        {
            InitializeComponent();
        }

        private void ListaCompras_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        private void cargarTabla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT [idCompra], [Proveedor].empresa proveedor, [Insumo].descripcion insumo, [COmpra].cantidad, [Compra].espec, [Compra].fecha FROM [dbo].[Compra] INNER JOIN Proveedor ON Compra.idProveedor= Proveedor.idProveedor  INNER JOIN Insumo ON Compra.idInsumo = Insumo.idInsumo", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    dataListaCompras.Rows.Clear();

                    while (registros.Read())
                    {                        
                        dataListaCompras.Rows.Add(
                            registros["idCompra"].ToString(),
                            registros["proveedor"].ToString(),
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
    }
}
