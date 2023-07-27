using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BAREST.Configuracion.CLIENTE;

namespace BAREST.Clientes
{
    public partial class ingresarCliente : Form
    {
        public string nombre;
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public string altura { get; set; }
        public string depto { get; set; }
        public string id { get; set; }
        public string documento { get; set; }
        public string piso { get; set; }
        public string cuit { get; set; }
        public  string telefono { get; set; }   
        public DateTime fecha { get; set; }

        public ingresarCliente()
        {
            InitializeComponent();
        }

        private void agregarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(textid.Text))
                {
                    if (existeCliente())
                    {
                        MessageBox.Show("Existe este documento en el sistema con el nombre: " + textNombre.Text);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textApe.Text) || string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textcalle.Text) || string.IsNullOrWhiteSpace(textAltura.Text))
                    {
                        MessageBox.Show("Los campos con * son necesarios");
                        return;
                    }

                    InsercionCliente();
                }
                else
                {
                    EditCliente();
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool existeCliente()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT documento FROM Cliente WHERE documento = @dni", conexion))
                {
                    comando.Parameters.AddWithValue("@dni", SqlDbType.VarChar).Value = textdni.Text;
                    return comando.ExecuteScalar() != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void InsercionCliente()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("INSERT INTO Cliente (nombre, apellido, telefono, domicilio, altura, depto, documento, piso, cuit, fecha) VALUES (@nombre, @apellido, @telefono, @domicilio, @altura, @depto, @documento, @piso, @cuit, @fecha)", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = textApe.Text;
                    comando.Parameters.AddWithValue("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.AddWithValue("@domicilio", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.AddWithValue("@altura", SqlDbType.VarChar).Value = textAltura.Text;
                    comando.Parameters.AddWithValue("@depto", SqlDbType.VarChar).Value = textDepto.Text;
                    comando.Parameters.AddWithValue("@documento", SqlDbType.VarChar).Value = textdni.Text;
                    comando.Parameters.AddWithValue("@piso", SqlDbType.VarChar).Value = textPiso.Text;
                    comando.Parameters.AddWithValue("@cuit", SqlDbType.VarChar).Value = textCuil.Text;
                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Se ha registrado un nuevo cliente");
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
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("UPDATE Cliente SET nombre = @nombre, apellido = @apellido, telefono = @telefono, domicilio = @domicilio, altura = @altura, depto = @depto, cuit = @cuit, fecha=@fecha WHERE dni = @dni", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
                    comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = textApe.Text;
                    comando.Parameters.AddWithValue("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.AddWithValue("@domicilio", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.AddWithValue("@altura", SqlDbType.VarChar).Value = textAltura.Text;
                    comando.Parameters.AddWithValue("@depto", SqlDbType.VarChar).Value = textDepto.Text;
                    comando.Parameters.AddWithValue("@cuit", SqlDbType.VarChar).Value = textCuil.Text;
                    comando.Parameters.AddWithValue("@dni", SqlDbType.VarChar).Value = textdni.Text;
                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Se ha actualizado el cliente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buscarDatos()
        {
            textid.Text = id;
            textNombre.Text = nombre;
            textApe.Text = apellido;
            textTel.Text = telefono;
            textcalle.Text = domicilio;
            textAltura.Text = altura; 
            textDepto.Text = depto;
            textdni.Text = documento;
            textPiso.Text = piso;
            textCuil.Text = cuit;
            
            
        }
        private void LimpiarCampos()
        {
            textid.Text = "";
            textNombre.Text = "";
            textApe.Text = "";
            textTel.Text = "";
            textcalle.Text = "";
            textAltura.Text = "";
            textDepto.Text = "";
            textdni.Text = "";
            textPiso.Text = "";
            textCuil.Text = "";
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarCliente_Load(object sender, EventArgs e)
        {
            if (nombre != "")
            {
                buscarDatos();
            }
        }
    }
}
