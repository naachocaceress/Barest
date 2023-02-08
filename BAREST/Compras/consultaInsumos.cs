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
                Conexion.ObtenerConexion();
                string sql = "select descripcion as articulo, unidad, cantidad,fechaIngreso,R.descripcion as rubro from Insumo  inner join RubroInsumo R on R.id = Insumo.idrubro";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                SqlDataReader registros = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registros.Read())
                {
                    dataGridView1.Rows.Add(registros["articulo"].ToString(), registros["unidad"].ToString(), registros["cantidad"].ToString(), registros["rubro"].ToString());
                }
                registros.Close();
                Conexion.ObtenerConexion().Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
