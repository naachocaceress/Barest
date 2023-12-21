using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BAREST.Compras
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private string rutaArchivoSeleccionado; // Variable para almacenar la ruta del archivo
        private string nombreArchivo;

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (existeProveedor())
            {
                MessageBox.Show("Ya existe un proveedor registrado con este Numero CUIL/CUIT: " + textcuit.Text);
                return;
            }

            if (string.IsNullOrWhiteSpace(textEmpresa.Text) || string.IsNullOrWhiteSpace(textTel.Text) || string.IsNullOrWhiteSpace(textcalle.Text) || string.IsNullOrWhiteSpace(textAltura.Text) || string.IsNullOrWhiteSpace(textcuit.Text))
            {
                MessageBox.Show("Los campos con * son necesarios");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new SqlCommand("INSERT INTO [dbo].[Proveedor] ([cuit], [empresa], [telefono], [direccion], [altura], [depto], [archivo], [razon], [email], [piso], [nombreArchivo]) VALUES (@cuit, @empresa, @telefono, @direccion, @altura, @depto, @archivo, @razon, @email, @piso, @nombreArchivo)", conexion))
                    {
                        comando.Parameters.Add("@cuit", SqlDbType.VarChar).Value = textcuit.Text;
                        comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                        comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                        comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textcalle.Text;
                        comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = textAltura.Text;
                        comando.Parameters.Add("@depto", SqlDbType.VarChar).Value = textDepto.Text;

                        // Verificar si se ha seleccionado un archivo
                        if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                        {
                            // Leer el contenido del archivo como un arreglo de bytes
                            byte[] contenidoArchivo = File.ReadAllBytes(rutaArchivoSeleccionado);

                            // Pasar el contenido del archivo al parámetro @archivo
                            comando.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = contenidoArchivo;
                        }
                        else
                        {
                            // Asignar valor nulo si no se seleccionó un archivo
                            comando.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        comando.Parameters.Add("@razon", SqlDbType.VarChar).Value = comboRazon.Text;
                        comando.Parameters.Add("@email", SqlDbType.VarChar).Value = textEmail.Text;
                        comando.Parameters.Add("@piso", SqlDbType.VarChar).Value = textPiso.Text;
                        comando.Parameters.Add("@nombreArchivo", SqlDbType.NVarChar).Value = (object)nombreArchivo ?? DBNull.Value;

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Se ha registrado el proveedor " + textEmpresa.Text + " correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiarCampo();
            cargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lógica de interfaz de usuario
            SeleccionarArchivo();
        }

        private void SeleccionarArchivo()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    // Almacenar la ruta del archivo en la variable
                    rutaArchivoSeleccionado = openFileDialog1.FileName;

                    // Obtener el nombre del archivo y almacenarlo en el campo nombreArchivo
                     nombreArchivo = Path.GetFileName(openFileDialog1.FileName);
                    // Guardar el nombre del archivo en la base de datos o usarlo según sea necesario
                    // Ejemplo: comando.Parameters.Add("@nombreArchivo", SqlDbType.NVarChar).Value = nombreArchivo;
                }
            }

            button3.Text = nombreArchivo;
        }


        private bool existeProveedor()
        {
            bool existe = false;
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT cuit FROM Proveedor WHERE cuit = @cuit AND estado = 'A'", conexion))
                {
                    comando.Parameters.Add("@cuit", SqlDbType.VarChar).Value = textcuit.Text;
                    SqlDataReader registro = comando.ExecuteReader();
                    existe = registro.Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return existe;
        }
        void limpiarCampo()
        {
            textcalle.Text = " ";
            textDepto.Text = " ";
            textAltura.Text = " ";
            textcuit.Text = " ";
            textEmpresa.Text = " ";
            textTel.Text = " ";
            button3.Text = "";
            comboRazon.SelectedIndex = -1;
            textPiso.Text = " ";
            textEmail.Text = " ";
        }

        private void cargarGrilla()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT empresa, telefono FROM Proveedor WHERE estado = 'A'", conexion))
                using (SqlDataReader registros = comando.ExecuteReader())
                {
                    tablaProveedores.Rows.Clear();
                    while (registros.Read())
                    {
                        tablaProveedores.Rows.Add(registros["empresa"].ToString(), registros["telefono"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los proveedores en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            btnguardar.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listadoProveedor m = new listadoProveedor();
            m.ShowDialog();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Está seguro que quiere borrar?", "Borrar Proveedor", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["empresa"].Value.ToString();
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (var comando = new SqlCommand("UPDATE Proveedor SET estado='D' WHERE empresa=@empresa", conexion))
                    {
                        comando.Parameters.AddWithValue("@empresa", Insum);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se eliminó el Menú: " + Insum);
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            try
            {
                String ProvSelect = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["empresa"].Value.ToString();
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("SELECT [idProveedor], [cuit], [empresa], [telefono], [direccion], [altura], [depto], [razon], [email], [piso], [archivo], [nombreArchivo] FROM [dbo].[Proveedor] WHERE empresa = @empresa", conexion))
                {
                    comando.Parameters.AddWithValue("@empresa", SqlDbType.VarChar).Value = ProvSelect;
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textid.Text = leido["idProveedor"].ToString();
                        textcuit.Text = leido["cuit"].ToString();
                        textEmpresa.Text = leido["empresa"].ToString();
                        textTel.Text = leido["telefono"].ToString();
                        textcalle.Text = leido["direccion"].ToString();
                        textAltura.Text = leido["altura"].ToString();
                        textDepto.Text = leido["depto"].ToString();
                        comboRazon.Text = leido["razon"].ToString();
                        textEmail.Text = leido["email"].ToString();
                        textPiso.Text = leido["piso"].ToString();

                        // Obtener el nombre del archivo desde la base de datos y asignarlo al texto del botón
                        nombreArchivo = leido["nombreArchivo"] is DBNull ? null : leido["nombreArchivo"].ToString();
                        button3.Text = nombreArchivo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnguardar.Visible = true;
            agregarProveedor.Visible = false;
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            modificarProveedores();
            agregarProveedor.Visible = true;
            btnguardar.Visible = false;
        }

        private void modificarProveedores()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                using (var comando = new SqlCommand("UPDATE [dbo].[Proveedor] SET [cuit] = @cuit, [empresa] = @empresa, [telefono] = @telefono, [direccion] = @direccion, [altura] = @altura, [depto] = @depto, [archivo] = @archivo, [razon] = @razon, [email] = @email, [piso] = @piso, nombreArchivo = @nombreArchivo WHERE idProveedor = @id", conexion))
                {
                    comando.Parameters.Add("@id", SqlDbType.VarChar).Value = textid.Text;
                    comando.Parameters.Add("@cuit", SqlDbType.VarChar).Value = textcuit.Text;
                    comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = textAltura.Text;
                    comando.Parameters.Add("@depto", SqlDbType.VarChar).Value = textDepto.Text;

                    // Verificar si se ha seleccionado un archivo
                    if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                    {
                        // Leer el contenido del archivo como un arreglo de bytes
                        byte[] contenidoArchivo = File.ReadAllBytes(rutaArchivoSeleccionado);

                        // Pasar el contenido del archivo al parámetro @archivo
                        comando.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = contenidoArchivo;
                    }
                    else
                    {
                        // Asignar valor nulo si no se seleccionó un archivo
                        comando.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    comando.Parameters.Add("@razon", SqlDbType.VarChar).Value = comboRazon.Text;
                    comando.Parameters.Add("@email", SqlDbType.VarChar).Value = textEmail.Text;
                    comando.Parameters.Add("@piso", SqlDbType.VarChar).Value = textPiso.Text;
                    comando.Parameters.Add("@nombreArchivo", SqlDbType.NVarChar).Value = (object)nombreArchivo ?? DBNull.Value;
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Se cambiaron los datos del proveedor " + textEmpresa.Text + " correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiarCampo();
            cargarGrilla();
        }


        private void textcuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, cancelar la entrada de la tecla
                e.Handled = true;
            }
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, cancelar la entrada de la tecla
                e.Handled = true;
            }
        }

        private void textAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, cancelar la entrada de la tecla
                e.Handled = true;
            }
        }
    }
}
