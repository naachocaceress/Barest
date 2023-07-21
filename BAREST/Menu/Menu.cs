using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BAREST
{
    public partial class Menu : Form
    {
        public string arti = "";

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarRubroM();
            CargarMenu();
            CargarcomboRubroMenu();
            comborubroMenu.SelectedItem = null;
        }

        // Método para verificar si el rubro ya existe
        /// <summary>
        /// rubro exist
        /// </summary>
        /// <param name="rubro"></param>
        /// <returns></returns>
        private bool RubroExist(string rubro)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT COUNT(*) FROM RubroMenu WHERE nombre = @desRubro";
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@desRubro", rubro);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el rubro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retornar false en caso de error.
            }
        }

        // Evento para agregar un nuevo rubro
        private void agregarRubro_Click(object sender, EventArgs e)
        {
            string rubro = textRubro.Text.Trim();

            if (string.IsNullOrEmpty(rubro))
            {
                MessageBox.Show("Falta agregar el nombre del rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RubroExist(rubro))
            {
                MessageBox.Show("Ya existe un rubro con este nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string sql = "INSERT INTO RubroMenu (nombre) VALUES (@desRubro)";
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@desRubro", rubro);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Rubro registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textRubro.Text = "";
                    CargarRubroM();
                    CargarcomboRubroMenu();
                    comborubroMenu.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el rubro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------- Cargar el dataRubro -----------------------------

        void CargarRubroM()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT nombre FROM RubroMenu WHERE estado='A' ORDER BY nombre ASC", conexion))
                {
                    tablaRubro.Rows.Clear();
                    using (SqlDataReader registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
                            tablaRubro.Rows.Add(registros["nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del RubroMenu:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------CARGAR COMBO MENU---------------------------------------------------------------
        private void CargarcomboRubroMenu()     
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT idRubroMenu, nombre FROM RubroMenu WHERE estado = 'A'", conexion))
                {
                    SqlDataAdapter adaptador1 = new SqlDataAdapter();
                    adaptador1.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adaptador1.Fill(tabla1);
                    comborubroMenu.DisplayMember = "nombre";
                    comborubroMenu.ValueMember = "idRubroMenu"; 
                    comborubroMenu.DataSource = tabla1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del RubroMenu en el combobox:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------- Cargar el dataMenu ------------------------------
        private void CargarMenu()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT nombre, precio FROM Menu WHERE estado ='A' ORDER BY LTRIM(nombre) ASC", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaMenu.Rows.Clear();
                    tablaMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    while (registros.Read())
                    {
                        string nombre = registros["nombre"].ToString();
                        decimal precio = Convert.ToDecimal(registros["precio"]); // Asegúrate de que el precio sea de tipo numérico en la base de datos
                        tablaMenu.Rows.Add(nombre, precio);
                    }

                    registros.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del menú en el DataGridView:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool MenuExiste()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Menu WHERE nombre = @desc", conexion))
                {
                    comando.Parameters.AddWithValue("@desc", textnomM.Text);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el menú existe:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retornar false en caso de error.
            }
        }
        //-----------------------------ELIMINACION RUBROMENU------------------------------------------------------------------------
        private void eliminarRubro_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Rubros", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string nombreRubro = tablaRubro.Rows[tablaRubro.CurrentRow.Index].Cells["Rubros"].Value.ToString();

                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("UPDATE RubroMenu SET estado = 'D' WHERE nombre = @nombreRubro", conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreRubro", nombreRubro);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Se eliminó el rubro: " + nombreRubro);
                    CargarRubroM();
                    CargarcomboRubroMenu();
                    comborubroMenu.SelectedItem = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el rubro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //------------------------------------------------------Insert Menu---------------------------------------------------------------
        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (MenuExiste())
            {
                MessageBox.Show("Ya existe un menú registrado con este nombre");
                return;
            }

            if (string.IsNullOrWhiteSpace(textnomM.Text) || string.IsNullOrWhiteSpace(textPrecioM.Text) || comborubroMenu.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar algún campo");
            }
            else
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("INSERT INTO Menu (nombre, idRubroMenu, precio, descripcion, foto) VALUES (@nombre, @idRubroMenu, @precio, @descripcion, @foto)", conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre",  textnomM.Text);
                        comando.Parameters.Add("@idRubroMenu", SqlDbType.Int).Value = comborubroMenu.SelectedValue;
                        comando.Parameters.Add("@precio", SqlDbType.Float).Value = float.Parse(textPrecioM.Text);
                        comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textDescM.Text;

                        // Guardar imagen en formato de byte array
                        byte[] fotoBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBytes = ms.ToArray();
                        }
                        comando.Parameters.Add("@foto", SqlDbType.Image).Value = fotoBytes;

                        comando.ExecuteNonQuery();

                        limpiarTextMenu();
                        CargarMenu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el menú:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //---------------------------------------------------- UPDATE MENU------------------------------------------------------------------------

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnomM.Text) || string.IsNullOrWhiteSpace(textPrecioM.Text) || comborubroMenu.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar algún campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand(" UPDATE Menu SET nombre=@nombre, precio=@precio, descripcion=@descripcion, idRubroMenu=@idRubroMenu, foto=@foto WHERE idMenu = @idMenu", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", textnomM.Text);
                    comando.Parameters.AddWithValue("@precio", float.Parse(textPrecioM.Text));
                    comando.Parameters.AddWithValue("@descripcion", textDescM.Text);
                    comando.Parameters.AddWithValue("@idRubroMenu", comborubroMenu.SelectedValue);

                    byte[] fotoBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fotoBytes = ms.ToArray();
                    }
                    comando.Parameters.Add("@foto", SqlDbType.Image).Value = fotoBytes;
                    comando.Parameters.AddWithValue("@idMenu", textId.Text);
                    comando.ExecuteNonQuery();

                    limpiarTextMenu();
                    CargarMenu();

                    btnguardar.Visible = false;
                    btnInsertar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el menú:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarTextMenu()
        {
            textnomM.Text = "";
            textPrecioM.Text = "";
            textDescM.Text = "";
            pictureBox1.Image = null;
            comborubroMenu.SelectedIndex = -1;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------
        //------------------------ Insercion de imagen ----------------------------
        private void bfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(foto.FileName);
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            listadoMenu m = new listadoMenu();
            m.ShowDialog();
        }
        //----------------------------------------ELIMINACION DE MENU-------------------------------------------------------------------------
        private void EliminarInsu_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Menú", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = tablaMenu.Rows[tablaMenu.CurrentRow.Index].Cells["Articulos"].Value.ToString();
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("UPDATE Menu SET estado='D' WHERE nombre=@nombre", conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", Insum);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el Menú: " + Insum);
                        CargarMenu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el menú:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //--------------------------------------------CONSULTAR PARA MODIFICAR MENU----------------------------------------------------------------
        private void modificarInsu_Click_1(object sender, EventArgs e)
        {
            string Insum2 = tablaMenu.Rows[tablaMenu.CurrentRow.Index].Cells["Articulos"].Value.ToString();
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT Menu.idMenu, Menu.nombre, Menu.descripcion, Menu.precio, Menu.foto ,RubroMenu.nombre as rubro FROM Menu  INNER JOIN RubroMenu  on Menu.idRubroMenu = RubroMenu.idRubroMenu WHERE Menu.nombre= @nombre", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", Insum2);
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textnomM.Text = leido["nombre"].ToString();
                        textDescM.Text = leido["descripcion"].ToString();
                        textPrecioM.Text = leido["precio"].ToString();
                        comborubroMenu.Text = leido["rubro"].ToString();
                        byte[] fotoBytes = (byte[])leido["foto"];
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        pictureBox1.Image = Image.FromStream(ms);
                        textId.Text = leido["idMenu"].ToString();
                    }

                    btnguardar.Visible = true;
                    btnInsertar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar para modificar el menú:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------- PARA HACER QUE SOLO SE PUEDA PONER NUMEROS EN EL TEXTPRECIO -------------

        private void textPrecioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }





        //-----------------------------------------------------------------------------------




    }
}
