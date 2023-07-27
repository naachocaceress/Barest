using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

        }

        void buscartipo()
        {
            Conexion.ObtenerConexion();
            String sql = "select id, unidad from Insumo";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            combotipo.DisplayMember = "unidad";
            combotipo.ValueMember = "id";
            combotipo.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }

        void buscarProveedor()
        {
            Conexion.ObtenerConexion();
            String sql = "select id ,descripcion from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboProv.DisplayMember = "descripcion";
            comboProv.ValueMember = "id";
            comboProv.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }
        void buscarinsumo()
        {
            Conexion.ObtenerConexion();
            String sql = "select id, descripcion from Insumo";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboInsumo.DisplayMember = "descripcion";
            comboInsumo.ValueMember = "id";
            comboInsumo.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            /*buscarinsumo();
            buscarProveedor();
            buscartipo();*/
        }
    }
}
