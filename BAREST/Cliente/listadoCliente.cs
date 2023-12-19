using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.Configuracion
{
    public partial class listadoCliente : Form
    {
        public listadoCliente()
        {
            InitializeComponent();
        }

        private void listadoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand(" SELECT [nombre],[apellido] ,[telefono]  ,[documento],[domicilio],[altura] ,[depto], [piso] FROM[dbo].[Cliente] ORDER BY  [nombre] ASC", conexion))
                using (SqlDataReader registros = comando.ExecuteReader())
                {

                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("nombre", "Nombre");
                    dataGridView1.Columns.Add("apellido", "Apellido");
                    dataGridView1.Columns.Add("documento", "Documento");
                    dataGridView1.Columns.Add("domicilio", "Domicilio");
                    dataGridView1.Columns.Add("altura", "altura");
                    dataGridView1.Columns.Add("depto", "Nombre");
                    dataGridView1.Columns.Add("piso", "Piso");
                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add(registros["nombre"], registros["apellido"], registros["documento"], registros["domicilio"], registros["altura"], registros["depto"], registros["piso"]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la lista clientes en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void llenar()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "nombre";
            dataGridView1.Columns[1].Name = "apellido";
            dataGridView1.Columns[2].Name = "telefono";
            dataGridView1.Columns[3].Name = "domicilio";
            dataGridView1.Columns[4].Name = "altura";
            dataGridView1.Columns[5].Name = "deptopiso";
            dataGridView1.Columns[6].Name = "dni";

            dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridView1.Columns["apellido"].HeaderText = "APELLIDO";
            dataGridView1.Columns["telefono"].HeaderText = "TELEFONO";
            dataGridView1.Columns["domicilio"].HeaderText = "DNI";
            dataGridView1.Columns["altura"].HeaderText = "DOMICILIO";
            dataGridView1.Columns["deptopiso"].HeaderText = "NUMERO";
            dataGridView1.Columns["dni"].HeaderText = "DOCUMENTO";




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
