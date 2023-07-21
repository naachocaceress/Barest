using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST
{
    public partial class listadoMenu : Form
    {
        public listadoMenu()
        {
            InitializeComponent();
        }

        private void listadoMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = "SELECT Menu.idMenu, Menu.nombre, Menu.precio, Menu.descripcion, RubroMenu.nombre AS rubro FROM Menu INNER JOIN RubroMenu ON Menu.idRubroMenu = RubroMenu.idRubroMenu WHERE Menu.estado ='A' ORDER BY RubroMenu.nombre ASC";
                    SqlDataReader registros = comando.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (registros.Read())
                    {
                        int id = Convert.ToInt32(registros["idMenu"].ToString());
                        string nombre = registros["nombre"].ToString();
                        decimal precio = Convert.ToDecimal(registros["precio"].ToString());
                        string descripcion = registros["descripcion"].ToString();
                        string rubro = registros["rubro"].ToString();
                        dataGridView1.Rows.Add(id,nombre,precio,descripcion,rubro);
                    }
                    registros.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del menú en el DataGridView:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
