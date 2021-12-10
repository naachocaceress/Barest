using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Ya existe un proveedor con el nombre ingresado ");
                return;
            }
            if (textEmpresa.Text=="")
            {
                MessageBox.Show("Falta ingresar la descripcion del proveedor ");
                return;
            }
            if (textTel.Text == "")
            {
                MessageBox.Show("Falta ingresar el telefono del proveedor ");
                return;
            }
            if (textcalle.Text == "")
            {
                MessageBox.Show("Falta ingresar la calle del proveedor ");
                return;
            }
            if (textNro.Text == "")
            {
                MessageBox.Show("Falta ingresar la altura del proveedor ");
                return;
            }
            else
            {
                Conexion.ObtenerConexion();
                string sql = " insert into Proveedor(nombre,empresa,telefono,calle,nro,depto,piso,codPostal,localidad,provincia) values (@nom, @empresa, @tel, @calle, @nro, @dept, @piso, @codpost, @localidad, @provi) ";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Add("@Nom", SqlDbType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
                comando.Parameters.Add("@calle", SqlDbType.VarChar).Value = textcalle.Text;
                comando.Parameters.Add("@nro", SqlDbType.VarChar).Value = textNro.Text;
                comando.Parameters.Add("@dept", SqlDbType.VarChar).Value = textDepto.Text;
                comando.Parameters.Add("@piso", SqlDbType.VarChar).Value = textPiso.Text;
                comando.Parameters.Add("@codpost", SqlDbType.VarChar).Value = textCodP.Text;
                comando.Parameters.Add("@localidad", SqlDbType.VarChar).Value = textLocalidad.Text;
                comando.Parameters.Add("@provi", SqlDbType.VarChar).Value = textProv.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha regitrado el proveedor " + textNombre.Text + " correctamente");
                textProv.Text = " ";
                textLocalidad.Text = " ";
                textCodP.Text = " ";
                textcalle.Text = " ";
                textDepto.Text = " ";
                textNro.Text = " ";
                textPiso.Text = " ";
                textNombre.Text = " ";
                textEmpresa.Text = " ";
                textTel.Text = " ";
                Conexion.ObtenerConexion().Close();
                cargarGrilla();
            }   
        }

        private void cargarGrilla()
        {
            Conexion.ObtenerConexion();
            string sql = "select nombre,telefono from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaProveedores.Rows.Clear();
            while (registros.Read())
            {
                tablaProveedores.Rows.Add(registros["nombre"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }
        bool existeProveedor()
        {
            Conexion.ObtenerConexion();
            String sql = " select * from Proveedor where nombre= @nom";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nom", SqlDbType.Char).Value = textNombre.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
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
                Insum = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["Nombre"].Value.ToString();
                Conexion.ObtenerConexion();
                string sql = "delete  from Proveedor where nombre = @nombre";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@nombre", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el Proveedor: " + Insum);
                Conexion.ObtenerConexion().Close();
                cargarGrilla();
            }
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            String ProvSelect = " ";
            ProvSelect = tablaProveedores.Rows[tablaProveedores.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            Conexion.ObtenerConexion();
            string sql = "select nombre,empresa,telefono,calle,nro,depto,piso,codPostal,localidad,provincia from Proveedor where nombre =@nombre";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", ProvSelect);
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textNombre.Text = leido["nombre"].ToString();
                textEmpresa.Text = leido["empresa"].ToString();
                textTel.Text = leido["telefono"].ToString();
                textcalle.Text = leido["calle"].ToString();
                textNro.Text = leido["nro"].ToString();
                textDepto.Text = leido["depto"].ToString();
                textPiso.Text = leido["piso"].ToString();
                textCodP.Text = leido["codPostal"].ToString();
                textLocalidad.Text = leido["localidad"].ToString();
                textProv.Text = leido["Provincia"].ToString();

            }
            Conexion.ObtenerConexion().Close();
            guardarModifi.Visible = true;
        }

        void modificarProveedores()
        {
            Conexion.ObtenerConexion();
            String sql = "update Proveedor set nombre= @nom, empresa= @empresa, telefono= @tel, calle= @calle, nro= @nro, depto= @depto, piso= @piso, codPostal= @codPost, localidad= @localidad, provincia= @Prov where nombre=@nom ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@empresa", SqlDbType.VarChar).Value = textEmpresa.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
            comando.Parameters.Add("@calle", SqlDbType.VarChar).Value = textcalle.Text;
            comando.Parameters.Add("@nro", SqlDbType.VarChar).Value = textNro.Text;
            comando.Parameters.Add("@dept", SqlDbType.VarChar).Value = textDepto.Text;
            comando.Parameters.Add("@piso", SqlDbType.VarChar).Value = textPiso.Text;
            comando.Parameters.Add("@codpost", SqlDbType.VarChar).Value = textCodP.Text;
            comando.Parameters.Add("@localidad", SqlDbType.VarChar).Value = textLocalidad.Text;
            comando.Parameters.Add("@provi", SqlDbType.VarChar).Value = textProv.Text;


            MessageBox.Show("Se cambiaron los datos el proveedor " + textNombre.Text + " correctamente");
            textProv.Text = " ";
            textLocalidad.Text = " ";
            textCodP.Text = " ";
            textcalle.Text = " ";
            textDepto.Text = " ";
            textNro.Text = " ";
            textPiso.Text = " ";
            textNombre.Text = " ";
            textEmpresa.Text = " ";
            textTel.Text = " ";
            Conexion.ObtenerConexion().Close();
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
