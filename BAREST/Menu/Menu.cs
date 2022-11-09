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
using System.Globalization;

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

            if (string.IsNullOrWhiteSpace(textRubro.Text))
            {
                MessageBox.Show("Falta agregar nombre del rubro");
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = "insert into RubroMenu (nombre) values (@desRubro)";
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
                string sql = "select * from RubroMenu where nombre=@desRubro";
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
            try
            {
                Conexion.ObtenerConexion();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText= "SELECT nombre FROM RubroMenu ORDER BY Ltrim(nombre) ASC";
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaRubro.Rows.Clear();
                    while (registros.Read())
                    {
                        tablaRubro.Rows.Add(registros["nombre"].ToString());
                    }
                    registros.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN DATAGRID RUBRO MENU", MessageBoxButtons.OK);
            }
           
           
        }
        //----------------------------------CARGAR COMBO MENU---------------------------------------------------------------
        private void cargarcomboRubroMenu()
        {
            try
            {
                Conexion.ObtenerConexion();
                using(var comando= new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText= " SELECT id, nombre FROM RubroMenu WHERE estado = 'A'";
                    SqlDataAdapter adaptador1 = new SqlDataAdapter();
                    adaptador1.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adaptador1.Fill(tabla1);
                    comborubroMenu.DisplayMember = "nombre";
                    comborubroMenu.ValueMember = "id";
                    comborubroMenu.DataSource = tabla1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR EN EL LLENARCOMBOMENU", MessageBoxButtons.OK);
            }
           
        }

        //----------------------------- Cargar el dataMenu ------------------------------
        private void cargarMenu()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText= "SELECT nombre, precio FROM Menu  WHERE estado ='A' ORDER BY Ltrim(nombre) ASC";
                    SqlDataReader registros = comando.ExecuteReader();
                    tablaArticulos.Rows.Clear();
                    tablaArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    while (registros.Read())
                    {
                        tablaArticulos.Rows.Add(registros["nombre"].ToString(), registros["precio"].ToString());
                    }
                   
                    registros.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message," Error en  DatagridMenu", MessageBoxButtons.OK);
            }
           
        }

        private bool menuExiste()
        {
            Conexion.ObtenerConexion();
            string sql = "SELECT * FROM Menu WHERE nombre=@desc";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@desc", SqlDbType.Char).Value = textnomM.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Conexion.ObtenerConexion().Close();
            return existe;
        }
        //-----------------------------ELIMINACION RUBROMENU------------------------------------------------------------------------
        private void eliminarRubro_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Rubros", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Rubrosd = "";
                Rubrosd = tablaRubro.Rows[tablaRubro.CurrentRow.Index].Cells["Rubros"].Value.ToString();
                try
                {
                    Conexion.ObtenerConexion();
                    using(var comando =new SqlCommand())
                    {
                        comando.Connection = Conexion.ObtenerConexion();
                        comando.CommandText = "UPDATE RubroMenu set estado ='D' where nombre=@nombre";
                        comando.Parameters.AddWithValue("@nombre", Rubrosd);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el rubro: " + Rubrosd);
                        cargarRubroM();
                        cargarcomboRubroMenu();
                        comborubroMenu.SelectedItem = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR EN LA ELIMINACION DE RUBROMENU", MessageBoxButtons.OK);
                }
            }
        }
        //------------------------------------------------------Insert Menu---------------------------------------------------------------
        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (menuExiste())
            {
                MessageBox.Show("Exite  un Menu registrado con este nombre");
                return;
            }

            if (textnomM.Text == "" || textPrecioM.Text == "" || comborubroMenu.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Falta completar algun campo");
            }
            else
            {
                try
                {
                    Conexion.ObtenerConexion();
                    using ( var comando = new SqlCommand()) 
                    {
                        comando.Connection = Conexion.ObtenerConexion();
                        comando.CommandText= "INSERT INTO  Menu (nombre, idRubro, precio, descripcion, foto ) VALUES (@nombre,@idrubro,@precio, @descripcion,@foto)";
                        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textnomM.Text;
                        comando.Parameters.Add("@idrubro", SqlDbType.Int).Value = comborubroMenu.SelectedValue.ToString();
                        comando.Parameters.Add("@precio", SqlDbType.Float).Value = textPrecioM.Text;
                        comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textDescM.Text;
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        comando.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                        comando.ExecuteNonQuery();

                        limpiarTextMenu();
                        cargarMenu();
                    }
                }
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message ,"ERROR EN LA INSERCION DE MENU",MessageBoxButtons.OK);
                }
                    
                
            }
            
        }
        //---------------------------------------------------- UPDATE MENU------------------------------------------------------------------------
        
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = "update Menu set nombre=@nombre, precio=@precio, descripcion = @descripcion , idrubro=@rubro ,foto=@foto where id =@id";
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textnomM.Text;
                    comando.Parameters.Add("@precio", SqlDbType.Float).Value = textPrecioM.Text;
                    comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textDescM.Text;
                    comando.Parameters.Add("@rubro", SqlDbType.Int).Value = comborubroMenu.SelectedValue.ToString();
                    
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    comando.Parameters.Add("@foto", SqlDbType.Image).Value = ms.GetBuffer();
                    comando.Parameters.Add("id", SqlDbType.Int).Value = textId.Text;
                    comando.ExecuteNonQuery();

                    limpiarTextMenu();
                    cargarMenu();
                    
                    btnguardar.Visible = false;
                    btnInsertar.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR EN LA MODIFICACION DEL MENU", MessageBoxButtons.OK);
            }
        }

        private void limpiarTextMenu()
        {
            textnomM.Text = " ";
            textPrecioM.Text = " ";
            textDescM.Text = " ";
            pictureBox1.Image = Properties.Resources.Barest;
            comborubroMenu.SelectedIndex = -1;
            cargarMenu();
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
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Menu", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
                try
                {
                    Conexion.ObtenerConexion();
                    using (var comando= new SqlCommand())
                    {
                        comando.Connection = Conexion.ObtenerConexion();
                        comando.CommandText = "update Menu set estado ='D' where nombre=@nombre";
                        comando.Parameters.AddWithValue("@nombre", Insum);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el Menu: " + Insum);
                        cargarMenu();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERROE EN LA ELIMINACION DEL MENU", MessageBoxButtons.OK);
                }
                
                
               
            }
        }
//--------------------------------------------CONSULTAR PARA MODIFICAR MENU----------------------------------------------------------------
        private void modificarInsu_Click_1(object sender, EventArgs e)
        {
            string Insum2 = "";
            Insum2 = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
            try
            {
                Conexion.ObtenerConexion();
                using ( var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = "SELECT m.id,m.nombre,m.descripcion,m.precio,r.nombre as rubro FROM Menu m INNER JOIN RubroMenu r on m.idRubro = r.id WHERE m.nombre= @nombre";
                    comando.Parameters.AddWithValue("@nombre", Insum2);
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textnomM.Text = leido["nombre"].ToString();
                        textDescM.Text = leido["descripcion"].ToString();
                        textPrecioM.Text = leido["precio"].ToString();
                        comborubroMenu.Text = leido["rubro"].ToString();
                       

                        arti = textnomM.Text;
                    }
                    
                    btnguardar.Visible = true;
                    btnInsertar.Visible = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR EN BOTON DE LA MODIFICACION ", MessageBoxButtons.OK);
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
