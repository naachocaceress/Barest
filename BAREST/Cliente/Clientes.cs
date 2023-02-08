using BAREST.Clientes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Configuracion
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
        }

        public static class CLientesshare
        {
            public static string selectCliente = "";
        }


        private void agregarCliente_Click(object sender, EventArgs e)
        {
            CLientesshare.selectCliente = "";
            var i = new ingresarCliente();
            i.ShowDialog();
            cargarGrilla();
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            string Scliente = "";
            Scliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["nombre"].Value.ToString();
            var i = new ingresarCliente();
            CLientesshare.selectCliente = Scliente;
            i.ShowDialog();
            cargarGrilla();


        }



        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int row = dataGridView1.SelectedRows[0].Index;
                int dni = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);


                Conexion.ObtenerConexion();
                String sql = "delete FROM Cliente WHERE  id=@id";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@id", SqlDbType.Int).Value = dni;
                int cant = comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el usuario: ");
                Conexion.ObtenerConexion().Close();
            }
            cargarGrilla();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();

        }

        public void cargarGrilla()
        {
            Conexion.ObtenerConexion();
            String sql = "select id, nombre,dni,telefono from Cliente order by nombre asc";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "id";
                dataGridView1.Columns[1].Name = "nombre";
                dataGridView1.Columns[2].Name = "dni";
                dataGridView1.Columns[3].Name = "telefono";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
                dataGridView1.Columns["dni"].HeaderText = "DOCUMENTO";
                dataGridView1.Columns["telefono"].HeaderText = "TELEFONO";
                dataGridView1.Rows.Add(registros["id"].ToString(), registros["nombre"].ToString(), registros["dni"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listadoCliente l = new listadoCliente();
            l.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            buscar2();

        }
        private void buscar2()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,dni,telefono from Cliente where nombre like'" + textBusqueda.Text + "%'";
            var comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            dataGridView1.Rows.Clear();
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "nombre";
                dataGridView1.Columns[1].Name = "dni";
                dataGridView1.Columns[2].Name = "telefono";
                dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
                dataGridView1.Columns["dni"].HeaderText = "DOCUMENTO";
                dataGridView1.Columns["telefono"].HeaderText = "TELEFONO";
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["dni"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
    }
}
