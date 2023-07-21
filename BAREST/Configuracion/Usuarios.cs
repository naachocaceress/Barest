using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public static class Nusuario
        {
            public static string valorUsuario = "";
            public static int valorcargo = 0;
            public static int valorsucursal = 0;

        }
        public void cargarSucursal()
        {
            Conexion.ObtenerConexion();
            string sql = " SELECT TOP (10) [idsucursal],[descripcion] FROM[BARESTNEW].[dbo].[Sucursal]";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            comboSucursal.ValueMember = "id";
            comboSucursal.DisplayMember = "descripcion";
            DataRow dataRow = table.NewRow();
            dataRow[0] = 0;
            dataRow[1] = "--------------------------Select---------------------------------------";
            table.Rows.InsertAt(dataRow, 0);
            comboSucursal.DataSource = table;
            Conexion.ObtenerConexion().Close();
        }
        public void cargarCargo()
        {
            Conexion.ObtenerConexion();
            string sql = " SELECT TOP (10) [idCargo],[descripcion] FROM[BARESTNEW].[dbo].[Cargo]";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            comboCargo.ValueMember = "id";
            comboCargo.DisplayMember = "descripcion";
            DataRow dataRow = table.NewRow();
            dataRow[0] = 0;
            dataRow[1] = "------------------------Select----------------------------------------- ";
            table.Rows.InsertAt(dataRow, 0);
            comboCargo.DataSource = table;
            Conexion.ObtenerConexion().Close();
        }
      

        public void limpiarcampo()
        {
            textDocumento.Text = "";
            textEmail.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textTelefono.Text = "";
            textDocumento.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboCargo.SelectedIndex = -1;
            comboSucursal.SelectedIndex = -1;
        }
        int Permiso()
        {
            int valor = 1;


            if (comboCargo.SelectedItem != null)
            {
                int seleccionado = Convert.ToInt32(comboCargo.SelectedValue);

                if (comboCargo.Text == "Administrador" || comboCargo.Text == "Socio")
                {
                    valor = 10;
                }
                else if (comboCargo.Text == "Encargado")
                {
                    valor = 9;
                }
                else if (comboCargo.Text == "Mozo")
                {
                    valor = 2;
                }


            }
            return valor;
        }

        //-------------------- PARA VERIFICAR SI EXISTE -----------------------------------
        // yo no es necesario porque  llamamos con dobleclick  un usuario
        private bool Inscripto()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuario WHERE documento = @documento";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@documento", textDocumento.Text);
                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// ver Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerUsuario_Click(object sender, EventArgs e)
        {
            if (tablaUsua.SelectedRows.Count > 0)
            {
                var SUsuario = tablaUsua.Rows[tablaUsua.CurrentCell.RowIndex].Cells["documento"].Value.ToString();
                try
                {

                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        string sql = "SELECT Usuario.documento, Usuario.email, Usuario.nombre, Usuario.apellido, Usuario.telefono, Usuario.fechaNacimiento, Sucursal.descripcion AS sucursal, Cargo.descripcion AS cargo  FROM Usuario INNER JOIN Sucursal ON Usuario.idSucursal = Sucursal.idsucursal INNER JOIN Cargo ON Usuario.idCargo = Cargo.idCargo WHERE Usuario.documento = @documento";
                        SqlCommand comando = new SqlCommand(sql, conexion);
                        comando.Parameters.AddWithValue("@documento", SUsuario);
                        using (SqlDataReader leido = comando.ExecuteReader())
                        {
                            if (leido.Read())
                            {

                                textDocumento.Text = leido["documento"].ToString();
                                textEmail.Text = leido["email"].ToString();
                                textNombre.Text = leido["nombre"].ToString();
                                textApellido.Text = leido["apellido"].ToString();
                                textTelefono.Text = leido["telefono"].ToString();
                                dateTimePicker1.Value = (DateTime)leido["fechaNacimiento"];
                                comboSucursal.Text = leido["sucursal"].ToString();
                                comboCargo.Text = leido["cargo"].ToString();

                            }
                        }
                        btnConfirmar.Enabled = !string.IsNullOrEmpty(SUsuario);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar para modificar el Usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Error No ha seleccionado  un Usuario:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


        /// <summary>
        /// update usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDocumento.Text))
            {
                MessageBox.Show("Es necesario buscar el usuario para modificarlo");
                return;
            }

            if (!Inscripto())
            {
                MessageBox.Show("El usuario con el documento especificado no existe");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {

                    if (comboCargo.SelectedItem != null)
                    {
                        int cargo = Convert.ToInt32(comboCargo.SelectedValue);
                    }
                    if (comboSucursal.SelectedItem != null)
                    {
                        int sucurcal = Convert.ToInt32(comboSucursal.SelectedValue);
                    }
                    string sql = "UPDATE [dbo].[Usuario] SET [email] = @email ,[nombre] = @nombre ,[telefono] = @telefono ,[fechaNacimiento] = @fechaNacimiento ,[idSucursal] = @sucursal ,[idCargo] = @cargo , [apellido] = @apellido ,[permiso] = @permiso WHERE [documento] = @documento";
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@documento", textDocumento.Text);
                    comando.Parameters.AddWithValue("@email", textEmail.Text);
                    comando.Parameters.AddWithValue("@nombre", textNombre.Text);
                    comando.Parameters.AddWithValue("@telefono", textTelefono.Text);
                    comando.Parameters.AddWithValue("@fechaNacimiento", dateTimePicker1.Value);
                    comando.Parameters.AddWithValue("@sucursal", comboSucursal.SelectedValue);
                    comando.Parameters.AddWithValue("@cargo", comboCargo.SelectedValue);
                    comando.Parameters.AddWithValue("@apellido", textApellido.Text);
                    comando.Parameters.AddWithValue("@permiso", Permiso());

                    int cant = comando.ExecuteNonQuery();
                    if (cant != 0)
                    {
                        MessageBox.Show("Los datos se modificaron correctamente");
                        limpiarcampo();
                    }
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Dar debaja usuario cambio su estado a 'D'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var SUsuario = Nusuario.valorUsuario;
            if (string.IsNullOrEmpty(SUsuario))
            {
                MessageBox.Show("Ver antes el Usuario que desea darse de Baja");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Usuario", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conexion = Conexion.ObtenerConexion())
                        {
                            string sql = " UPDATE [dbo].[Usuario] SET [estado] = 'D' WHERE [documento]= @documento";
                            SqlCommand comando = new SqlCommand(sql, conexion);
                            comando.CommandType = CommandType.Text;
                            comando.Parameters.AddWithValue("@documento", SUsuario);

                            int cant = comando.ExecuteNonQuery();
                            if (cant != 0)
                            {
                                MessageBox.Show("Se ha dado de baja al Usuario " + SUsuario);
                            }
                            CargarGrilla();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            cargarCargo();
            cargarSucursal();
        }

        private void CargarGrilla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT documento, email, nombre, apellido, telefono, fechaNacimiento, Sucursal.descripcion AS sucursal, Cargo.descripcion AS cargo FROM Usuario INNER JOIN Sucursal ON Usuario.idSucursal = Sucursal.idsucursal INNER JOIN Cargo ON Usuario.idCargo = Cargo.idCargo WHERE Usuario.estado = 'A' ORDER BY nombre ASC";
                    ;

                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaUsua.Rows.Clear();
                    while (registros.Read())
                    {
                        tablaUsua.Rows.Add(
                            registros["documento"].ToString(),
                            registros["email"].ToString(),
                            registros["nombre"].ToString(),
                            registros["apellido"].ToString(),
                            registros["telefono"].ToString(),
                            registros["fechaNacimiento"].ToString(),
                            registros["sucursal"].ToString(),
                            registros["cargo"].ToString()

                            );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Usuarios_Load_1(object sender, EventArgs e)
        {
            CargarGrilla();
            cargarCargo();
            cargarSucursal();
        }




    }
}
