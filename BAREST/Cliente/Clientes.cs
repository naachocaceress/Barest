using BAREST.Clientes;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
            CargarGrilla();
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            string cliente = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["nombre"].Value.ToString();
            
            
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand(" SELECT nombre,apellido telefono ,domicilio,altura,depto, documento, piso.cuit, idCliente FROM Cliente nombre = @nombre", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", cliente);
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {

                        ingresarCliente vista = new ingresarCliente();
                        vista.nombre = leido["Nombre"].ToString();
                        vista.apellido = leido["apellido"].ToString();
                        vista.telefono = leido["telefono"].ToString();
                        vista.domicilio = leido["domicilio"].ToString();
                        vista.altura = leido["altura"].ToString();
                        vista.depto = leido["depto"].ToString();
                        vista.documento = leido["documento"].ToString();
                        vista.piso = leido["piso"].ToString() ;
                        vista.cuit = leido["cuit"].ToString();
                        vista.id = leido["idCliente"].ToString();
                    }
                    var i = new ingresarCliente();
                    i.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar para modificar el menú:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Menú", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["nombre"].Value.ToString();
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("UPDATE Cliente SET estado='D' WHERE nombre=@nombre", conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", Insum);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el cliente: " + Insum);
                        CargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        private void CargarGrilla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand(" SELECT  idCliente ,nombre, documento, telefono FROM Cliente WHERE estado = 'A' ORDER BY nombre ASC", conexion))
                using (SqlDataReader registros = comando.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                   
                    dataGridView1.Columns.Add("nombre", "NOMBRE");
                    dataGridView1.Columns.Add("documento", "DOCUMENTO");
                    dataGridView1.Columns.Add("telefono", "TELEFONO");


                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add( registros["nombre"], registros["documento"], registros["telefono"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los clientes en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listadoCliente l = new listadoCliente();
            l.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (var comando = new SqlCommand("SELECT nombre, documento, telefono FROM Cliente WHERE nombre LIKE @nombre", conexion))
            {
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = textBusqueda.Text + "%";
                dataGridView1.Rows.Clear();

                using (SqlDataReader registros = comando.ExecuteReader())
                {
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("nombre", "NOMBRE");
                    dataGridView1.Columns.Add("documento", "DOCUMENTO");
                    dataGridView1.Columns.Add("telefono", "TELEFONO");

                    while (registros.Read())
                    {
                        dataGridView1.Rows.Add(registros["nombre"], registros["documento"], registros["telefono"]);
                    }
                }
            }
        }


    }

}
