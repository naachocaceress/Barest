using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Transitions;
using static BAREST.Configuracion.CLIENTE;

namespace BAREST.Clientes
{
    public partial class ingresarCliente : Form
    {
        public ingresarCliente()
        {
            InitializeComponent();
        }

        private void agregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (textid.Text =="")
                {
                    if (existeCLiente())
                    {
                        MessageBox.Show("Existe este documento en el sistema con el nombre:"+ textNombre.Text + " ");
                        return;
                    }
                    if (textApe.Text == "" || textNombre.Text == "" || textdni.Text == "") 
                    {
                        MessageBox.Show("falta ingresar DAtos a algun Campo");
                        return;
                    }
                    else
                    {
                        InsercionCLiente();
                        limpiar();
                        return;
                    }
                }
                else
                {
                    EditCliente();
                    limpiar();
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        } 
        bool  existeCLiente()
        {
            bool existe = false;
            try
            {
                Conexion.ObtenerConexion();
                String sql = " select dni from Cliente where dni like @dni";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@dni", SqlDbType.Char).Value = textdni.Text;
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                    existe = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Conexion.ObtenerConexion().Close();
            return existe;
        } 
        void InsercionCLiente()
        {
            try
            {
                String sql = " INSERT INTO Cliente(nombre,apellido,telefono,domicilio,altura,deptopiso,dni) VALUES(@nombre,@apellido,@telefono,@domicilio,@altura,@deptopiso,@dni)";

                using (Conexion.ObtenerConexion())
                {

                    var comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApe.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textdni.Text;
                    comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = textNro.Text;
                    comando.Parameters.Add("@deptopiso", SqlDbType.VarChar).Value = textDepto.Text;
                    comando.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();
                    MessageBox.Show(" se  ha registrado un nuevo cliente");
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void EditCliente()
        {
            try
            {
                String sql = "Update [Cliente] SET[nombre]= @nombre, [apellido] = @apellido,  [telefono] = @telefono,  [domicilio] = @domicilio,  [altura] = @altura,  [deptopiso] = @deptopiso, [dni] = @dni WHERE id = @id";
                using (Conexion.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = textApe.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textdni.Text;
                    comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = textNro.Text;
                    comando.Parameters.Add("@deptopiso", SqlDbType.VarChar).Value = textDepto.Text;
                    comando.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = textid.Text;
                    comando.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();
                    MessageBox.Show(" se  ha Moficado  un  cliente" + textNombre.Text + " Correctamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void buscarDatos()
        {
            Conexion.ObtenerConexion();
            string sql = "SELECT id,nombre,apellido,telefono,domicilio,altura,deptopiso,dni from Cliente WHERE nombre = @nombre";
            var comando = new SqlCommand(sql,Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = CLientesshare.selectCliente;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textid.Text = leido["id"].ToString();
                textNombre.Text = leido["nombre"].ToString();
                textApe.Text= leido["apellido"].ToString();
                textcalle.Text = leido["domicilio"].ToString();
                textTel.Text = leido["telefono"].ToString();
                textNro.Text = leido["altura"].ToString();
                textDepto.Text = leido["deptopiso"].ToString();
                textdni.Text = leido["dni"].ToString();
               
            }
            Conexion.ObtenerConexion().Close();
        }
       
        private void ingresarCliente_Load(object sender, EventArgs e)
        { 
            if (CLientesshare.selectCliente == "")
            {

            }
            else
            {
                buscarDatos();
            }
        }

        public void limpiar()
        {
            textNombre.Text = " ";
            textApe.Text = " ";
            textTel.Text = " ";
            textdni.Text = " ";
            textcalle.Text = "";
            textNro.Text = "";
            textDepto.Text = "";
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*int idCliente = 0;
       public void SeleccionarCliente(string pnombre = null)
       {//dynamic BuscarUsu = tablaUsua.Rows[tablaUsua.CurrentRow.Index].Cells["documento"].Value.ToString();
        //   pnombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["NOMBRE"].Value.ToString();
           using (Conexion.ObtenerConexion())
           {
               String sql = "Select nombre,apellido,telefono,domicilio,altura,deptopiso,dni,id from Cliente where nombre like '%' " + pnombre + " '%'";
               var comando = new SqlCommand(sql, Conexion.ObtenerConexion());
               SqlDataReader reader = comando.ExecuteReader();
               if (reader.Read())
               {

                   textNombre.Text = reader.GetString(0);
                   textApe.Text = reader.GetString(1);
                   textTel.Text = reader.GetString(2);
                   textdni.Text = reader.GetString(3);
                   textcalle.Text = reader.GetString(4);
                   textNro.Text = reader.GetString(5);
                   textDepto.Text = reader.GetString(6);
                   idCliente = reader.GetInt32(7);

               }

           }

       }
       */
    }


}
