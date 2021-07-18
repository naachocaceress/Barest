using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            guardarModifi.Visible = false;
            cargarRubroM();
            cargarMenu();
            cargarcomboRubroMenu();
            comborubroMenu.SelectedItem = null;
        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
            if (rubroExist())
            {
                MessageBox.Show("Ya existe un rubro con este Nombre ");
                return;
            }

            if (textRubro.Text == "")
            {
                MessageBox.Show("Falta agregar nombre del rubro");
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "insert into RubroMenu (descripcionMenu) values (@desRubro)";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
                comando.ExecuteNonQuery();
                textRubro.Text = " ";
                MessageBox.Show("Rubro registrado");
                cargarRubroM();
                cargarcomboRubroMenu();
                comborubroMenu.SelectedItem = null;
                Conexion.ObtenerConexion().Close();
            }

            //---------------------- Controlar si existe el Rubro -----------------------

            bool rubroExist()
            {
                Conexion.ObtenerConexion();
                string sql = "select * from RubroMenu where descripcionMenu=@desRubro";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
                bool existe = false;
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                    existe = true;
                Conexion.ObtenerConexion().Close();
                return existe;
            }
        }

        //----------------------------- Cargar el dataRubro -----------------------------
        void cargarRubroM()
        {
            Conexion.ObtenerConexion();
            string sql = "select descripcionMenu from RubroMenu";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaRubro.Rows.Clear();
            while (registros.Read())
            {
                tablaRubro.Rows.Add(registros["descripcionMenu"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void cargarcomboRubroMenu()
        {
            Conexion.ObtenerConexion();
            string sql = " select id,descripcionMenu from RubroMenu";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comborubroMenu.DisplayMember = "descripcionMenu";
            comborubroMenu.ValueMember = "id";
            comborubroMenu.DataSource = tabla1;
            Conexion.ObtenerConexion().Close();
        }

        //----------------------------- Cargar el dataMenu ------------------------------
        private void cargarMenu()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre from Menu";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaArticulos.Rows.Clear();
            while (registros.Read())
            {
                tablaArticulos.Rows.Add(registros["nombre"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private bool menuExiste()
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Menu where nombre=@desc";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@desc", SqlDbType.Char).Value = textnomM.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Conexion.ObtenerConexion().Close();
            return existe;
        }

        private void eliminarRubro_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Rubros", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Rubrosd = "";
                Rubrosd = tablaRubro.Rows[tablaRubro.CurrentRow.Index].Cells["Rubros"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete from RubroMenu where descripcion = @descripcion";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@descripcion", Rubrosd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el rubro: " + Rubrosd);
                cargarRubroM();
                cargarcomboRubroMenu();
                comborubroMenu.SelectedItem = null;
                Conexion.ObtenerConexion().Close();
            }
        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (menuExiste())
            {
                MessageBox.Show("El insumo ya existe");
                return;
            }

            if (textnomM.Text == "" || textDescM.Text == "" || textPrecioM.Text == "" || comborubroMenu.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Falta completar algun campo");
            }
            else
            {
                    Conexion.ObtenerConexion();
                    String sql = "insert into DetalleMenu (descripcion) values (@descD) select @@IDENTITY insert into Menu (nombre, precio, foto, idRubroMenu, idDetalleMenu) values (@nom, @pre, @foto, @idrubM, @@IDENTITY)";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textnomM.Text;
                    comando.Parameters.Add("@pre", SqlDbType.Float).Value = textPrecioM.Text;
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    comando.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                    comando.Parameters.Add("@idrubM", SqlDbType.Int).Value = comborubroMenu.SelectedValue.ToString();
                    comando.Parameters.Add("@descD", SqlDbType.VarChar).Value = textDescM.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show(textnomM.Text + " fue registrado correctamente");
                    textnomM.Text = " ";
                    textPrecioM.Text = " ";
                    textDescM.Text = " ";
                    pictureBox1.Image = Properties.Resources.imagenmenu;
                    comborubroMenu.SelectedItem = null;
                    cargarMenu();
                    Conexion.ObtenerConexion().Close();
            }
            
        }

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

        private void EliminarInsu_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Menu", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete from Menu where nombre = @nombre";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@nombre", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el Menu: " + Insum);
                cargarMenu();
                Conexion.ObtenerConexion().Close();
            }
        }

        private void modificarInsu_Click_1(object sender, EventArgs e)
        {
            string Insum2 = "";
            Insum2 = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
            Conexion.ObtenerConexion();
            string sql = "select m.nombre,d.descripcion,r.descripcionMenu,m.precio from menu m inner join DetalleMenu  d on m.IdDetalleMenu=d.id inner join RubroMenu r on r.id=m.idRubroMenu where nombre=@nombre";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", Insum2);
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textnomM.Text = leido["nombre"].ToString();
                textDescM.Text = leido["descripcion"].ToString();
                comborubroMenu.Text = leido["descripcionMenu"].ToString();
                textPrecioM.Text = leido["precio"].ToString();

                arti = textnomM.Text;
            }
            guardarModifi.Visible = true;
            Conexion.ObtenerConexion().Close();
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

        private void guardarModifi_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "update Menu set nombre=@nombre, precio=@precio where nombre =@arti";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textnomM.Text;
            //comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textDescM.Text;
            comando.Parameters.Add("@precio", SqlDbType.VarChar).Value = textPrecioM.Text;
            //comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargo.SelectedItem.ToString();
            comando.Parameters.Add("@arti", SqlDbType.VarChar).Value = arti;
            int cant = comando.ExecuteNonQuery();
            if (cant != 0)
            {
                MessageBox.Show("Los datos se modificaron correctamente");
                arti = "";
                textnomM.Text = "";
                textDescM.Text = "";
                textDescM.Text = "";
                comborubroMenu.SelectedItem = null;
            }
            cargarMenu();
            guardarModifi.Visible = false;
            Conexion.ObtenerConexion().Close();
        }
    }
}
