using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BAREST.Compras
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
        }

        private void consultarInsumos_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCamposInsumo()
        {
            textDescInsumo.Text = string.Empty;
            textCantidad.Text = string.Empty;
            comboUnidad.SelectedIndex = -1;
            comboRubroInsumo.SelectedIndex = -1;
            dateTimefechaIngreso.Value = DateTime.Now;
        }

        /// <summary>
        /// Insert Insumos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool InsumoExist()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Insumo WHERE descripcion = @desc", conexion))
                {
                    comando.Parameters.AddWithValue("desc", textDescInsumo.Text);
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el menú existe:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void CargarComboRubroInsumo()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = "SELECT idrubroInsumo, descripcion FROM RubroInsumo WHERE estado = 'A'";
                    SqlDataAdapter adaptador1 = new SqlDataAdapter();
                    adaptador1.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adaptador1.Fill(tabla1);
                    comboRubroInsumo.DisplayMember = "descripcion"; // Nombre de la columna que se mostrará en el ComboBox
                    comboRubroInsumo.ValueMember = "idrubroInsumo"; // Nombre de la columna que contiene los valores asociados
                    comboRubroInsumo.DataSource = tabla1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN EL LLENAR COMBO RUBRO INSUMO", MessageBoxButtons.OK);
            }
        }


        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (InsumoExist())
            {
                MessageBox.Show("Ya existe un Insumo registrado con este nombre");
                return;
            }

            if (string.IsNullOrWhiteSpace(textDescInsumo.Text) || string.IsNullOrWhiteSpace(textCantidad.Text) || comboUnidad.SelectedIndex == -1 || comboRubroInsumo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar algún campo");
            }
            else
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("INSERT INTO Insumo (descripcion, cantidad, unidad, idrubroInsumo, fechaIngreso) VALUES (@descripcion, @cantidad, @unidad, @idrubroInsumo, @fechaIngreso)", conexion))
                    {
                        comando.Parameters.AddWithValue("@descripcion", textDescInsumo.Text);
                        comando.Parameters.AddWithValue("@cantidad", int.Parse(textCantidad.Text));
                        comando.Parameters.AddWithValue("@unidad", comboUnidad.SelectedItem);
                        comando.Parameters.AddWithValue("@idrubroInsumo", comboRubroInsumo.SelectedValue);
                        comando.Parameters.AddWithValue("@fechaIngreso", dateTimefechaIngreso.Value);
                        comando.ExecuteNonQuery();

                        limpiarCamposInsumo();
                        // Opcional: Puedes mostrar un mensaje de éxito o actualizar la lista de insumos.
                        MessageBox.Show("Insumo registrado correctamente");
                        CargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el insumo: " + ex.Message);
                }
            }
        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
            if (RubroExiste(textRubro.Text))
            {
                MessageBox.Show("Ya existió un Rubro con este Nombre ");
                return;
            }
            Conexion.ObtenerConexion();
            string sql = "insert into RubroInsumo (descripcion) values (@desRubro)";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
            comando.ExecuteNonQuery();
            textRubro.Text = " ";
            Conexion.ObtenerConexion().Close();
            CargarComboRubroInsumo();
            CargarRubro();
            MessageBox.Show("Rubro Registrado");
        }
        //-------------------- PARA VERIFICAR SI EXISTE UN RUBRO -----------------------------------

        private bool RubroExiste(string rubro)
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string sql = "select COUNT(*) from RubroInsumo where descripcion = @desRubro";
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    comando.Parameters.AddWithValue("@desRubro", textRubro.Text);
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el rubro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //--------------------------------------------------------------------------------

        //-------------------- PARA CARGAR  LA GRILLA -----------------------------------
        private void CargarRubro()
        {
            Conexion.ObtenerConexion();
            string sql = "select descripcion from RubroInsumo where estado = 'A' ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaRubro.Rows.Clear();
            while (registros.Read())
            {
                tablaRubro.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }



        private void CargarGrilla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand("SELECT Insumo.descripcion, Insumo.cantidad, Insumo.unidad, RubroInsumo.descripcion rubro, Insumo.fechaIngreso FROM Insumo INNER JOIN RubroInsumo ON Insumo.idrubroInsumo = RubroInsumo.idRubroInsumo WHERE Insumo.estado = 'A' ORDER BY LTRIM(Insumo.descripcion) ASC", conexion))
                {
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaInsumo.Rows.Clear();
                    tablaInsumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    while (registros.Read())
                    {
                        string descripcion = registros["descripcion"].ToString();
                        int cantidad = Convert.ToInt32(registros["cantidad"]);
                        string unidad = registros["unidad"].ToString();
                        string rubro = registros["rubro"].ToString();
                        DateTime fechaIngreso = (DateTime)registros["fechaIngreso"];
                        tablaInsumo.Rows.Add(descripcion, cantidad, unidad, rubro, fechaIngreso);
                    }

                    registros.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del Insumo en la tablaInsumo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Insumos_Load(object sender, EventArgs e)
        {
            CargarRubro();
            CargarComboRubroInsumo();
            CargarGrilla();
        }

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
                    using (var comando = new SqlCommand("UPDATE RubroInsumo SET estado = 'D' WHERE descripcion = @nombreRubro", conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreRubro", nombreRubro);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Se eliminó el rubro: " + nombreRubro);
                    CargarRubro();
                    CargarComboRubroInsumo();
                    comboRubroInsumo.SelectedItem = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el rubro:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Insumo", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = tablaInsumo.Rows[tablaInsumo.CurrentRow.Index].Cells["descripcion"].Value.ToString();
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("UPDATE Insumo SET estado='D' WHERE descripcion=@descripcion", conexion))
                    {
                        comando.Parameters.AddWithValue("@descripcion", Insum);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el Insumo: " + Insum);
                        CargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Insumo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void modificarInsu_Click(object sender, EventArgs e)
        {
            string Insumo = tablaInsumo.Rows[tablaInsumo.CurrentRow.Index].Cells["descripcion"].Value.ToString();
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT Insumo.descripcion ,Insumo.cantidad ,Insumo.unidad ,RubroInsumo.descripcion rubro ,Insumo.fechaIngreso , Insumo.idInsumo FROM Insumo  INNER JOIN RubroInsumo  ON Insumo.idrubroInsumo = RubroInsumo.idRubroInsumo WHERE Insumo.descripcion= @descripcion AND Insumo.estado='A' ", conexion))
                {
                    comando.Parameters.AddWithValue("@descripcion", Insumo);
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textDescInsumo.Text = leido["descripcion"].ToString();
                        textCantidad.Text = leido["cantidad"].ToString();
                        comboUnidad.Text = leido["unidad"].ToString();
                        comboRubroInsumo.Text = leido["rubro"].ToString();
                        dateTimefechaIngreso.Text = leido["fechaIngreso"].ToString();
                        textidInsumo.Text = leido["idInsumo"].ToString();
                        btnguardar.Visible = true;
                        agregarInsu.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar para modificar el Insumo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textDescInsumo.Text) || string.IsNullOrWhiteSpace(textCantidad.Text) || comboUnidad.SelectedIndex == -1 || comboRubroInsumo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta completar algún campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand(" UPDATE [dbo].[Insumo] SET [descripcion] = @descripcion ,[cantidad] =@cantidad  ,[unidad] =@unidad  , [fechaIngreso] = @fechaIngreso ,[idrubroInsumo] = @idrubroInsumo   WHERE idInsumo = @idInsumo", conexion))
                {
                    comando.Parameters.AddWithValue("@descripcion", textDescInsumo.Text);
                    comando.Parameters.AddWithValue("@cantidad", int.Parse(textCantidad.Text));
                    comando.Parameters.AddWithValue("@unidad", comboUnidad.SelectedItem);
                    comando.Parameters.AddWithValue("@idrubroInsumo", comboRubroInsumo.SelectedValue);
                    comando.Parameters.AddWithValue("@fechaIngreso", dateTimefechaIngreso.Value);
                    comando.Parameters.AddWithValue("@idInsumo", textidInsumo.Text);
                    comando.ExecuteNonQuery();


                    limpiarCamposInsumo();
                    CargarGrilla();


                    btnguardar.Visible = false;
                    agregarInsu.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Insumo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            consultaInsumos m = new consultaInsumos();
            m.ShowDialog();
        }
    }

}
