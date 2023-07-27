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
                using (var comando = new SqlCommand("SELECT [idCompra], [Proveedor].empresa proveedor, [Insumo].descripcion insumo, [COmpra].cantidad, [Compra].espec, [Compra].Estado, [Compra].fecha FROM [dbo].[Compra] INNER JOIN Proveedor ON Compra.idProveedor= Proveedor.idProveedor  INNER JOIN Insumo ON Compra.idInsumo = Insumo.idInsumo WHERE Compra.estado IN ('A', 'P', 'L', 'D') ORDER BY COmpra.Estado", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    dataListaCompras.Rows.Clear();

                    while (registros.Read())
                    {
                        string estado = registros["Estado"].ToString();
                        if (estado == "A")
                        {
                            estado = "HECHO";
                        }
                        else if (estado == "P")
                        {
                            estado = "PENDIENTE";
                        }
                        else if (estado == "L" && (DateTime.Now - Convert.ToDateTime(registros["fecha"])).Days > 3)
                        {
                            estado = "DEMORADO";
                        }
                        else if (estado == "D")
                        {
                            estado = "CANCELADO";
                        }

                        dataListaCompras.Rows.Add(
                            registros["idCompra"].ToString(),
                            registros["proveedor"].ToString(),
                            registros["insumo"].ToString(),
                            registros["cantidad"].ToString(),
                            registros["espec"].ToString(),
                            estado,
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
