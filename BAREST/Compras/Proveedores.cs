using System;
using System.Data;
using System.Data.SqlClient;
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

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            if (existeProveedor())
            {
                MessageBox.Show("Ya existe un proveedor registrado con este Numero CUIL/CUIT: " + textcuit.Text);
                return;
            }
            if (textEmpresa.Text != "" && textTel.Text != "" && textcalle.Text != "" && textNro.Text != "" && textcuit.Text != "")
            {
                try
                {
                    Conexion.ObtenerConexion();
                    string sql = " INSERT INTO [dbo].[Proveedor] ([cuit] ,[empresa],[telefono] ,[direccion] ,[altura],[deptopiso] ,[archivo])VALUES  (@cuit, @empresa,  @telefono, @direccion,  @altura, @deptopiso,  @archivo) ";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@cuit", SqlDbType.VarChar).Value = textcuit.Text;
                    comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                    comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = textNro.Text;
                    comando.Parameters.Add("@deptopiso", SqlDbType.VarChar).Value = textDepto.Text;
                    comando.Parameters.Add("@archivo", SqlDbType.Xml).Value = button3.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha regitrado el proveedor " + textEmpresa.Text + " correctamente");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                limpiarCampo();
                Conexion.ObtenerConexion().Close();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Falta ingresar algún Datos ");
            }
        }
        void limpiarCampo()
        {
            textcalle.Text = " ";
            textDepto.Text = " ";
            textNro.Text = " ";
            textcuit.Text = " ";
            textEmpresa.Text = " ";
            textTel.Text = " ";
            button3.Text = "";
        }

        private void cargarGrilla()
        {
            Conexion.ObtenerConexion();
            string sql = "select empresa,telefono from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaProveedores.Rows.Clear();
            while (registros.Read())
            {
                tablaProveedores.Rows.Add(registros["empresa"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
        bool existeProveedor()
        {
            bool existe = false;
            try
            {
                Conexion.ObtenerConexion();
                String sql = " select cuit from Proveedor where cuit like @cuit";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@cuit", SqlDbType.Char).Value = textcuit.Text;
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

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            guardarModifi.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listadoProveedor m = new listadoProveedor();
            m.ShowDialog();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar proveedores", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["empresa"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete  from Proveedor where empresa = @empresa";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@empresa", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el Proveedor: " + Insum);
                Conexion.ObtenerConexion().Close();
                cargarGrilla();
            }
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            textEmpresa.ReadOnly = true;
            button3.Visible = false;
            label7.Visible = false;
            try
            {
                String ProvSelect = "";
                ProvSelect = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["empresa"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "select id, cuit,empresa,telefono,direccion,altura,deptopiso from Proveedor where empresa =@empresa";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@empresa", SqlDbType.VarChar).Value = ProvSelect;
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                {
                    textcuit.Text = leido["cuit"].ToString();
                    textEmpresa.Text = leido["empresa"].ToString();
                    textTel.Text = leido["telefono"].ToString();
                    textcalle.Text = leido["direccion"].ToString();
                    textNro.Text = leido["altura"].ToString();
                    textDepto.Text = leido["deptopiso"].ToString();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Conexion.ObtenerConexion().Close();
            guardarModifi.Visible = true;
        }

        void modificarProveedores()
        {
            try
            {
                using (Conexion.ObtenerConexion())
                {
                    String sql = "update Proveedor set cuit= @cuit, empresa= @empresa, telefono= @tel, direccion= @calle, altura= @nro, deptopiso= @depto where id=@id";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Add("@cuit", SqlDbType.VarChar).Value = textcuit.Text;
                    comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                    comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
                    comando.Parameters.Add("@calle", SqlDbType.VarChar).Value = textcalle.Text;
                    comando.Parameters.Add("@nro", SqlDbType.VarChar).Value = textNro.Text;
                    comando.Parameters.Add("@depto", SqlDbType.VarChar).Value = textDepto.Text;
                    //comando.Parameters.AddWithValue("@id", SqlDbType.Int).Value = textid.Text;
                    comando.ExecuteNonQuery();
                    Conexion.ObtenerConexion().Close();

                }
                MessageBox.Show("Se cambiaron los datos el proveedor " + textEmpresa.Text + " correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiarCampo();
            cargarGrilla();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarProveedores();
            guardarModifi.Visible = false;
        }
    }
}
