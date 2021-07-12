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
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
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
            if (textDesc.Text=="")
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
                Cone.Open();
                string sql = "insert into Provincia(nombre) values(@nomProv) select @@IDENTITY insert into Localidad(idprovincia, nombre, codigoPostal) values(@@IDENTITY,@Nomlo,@codP) select @@IDENTITY insert into Domicilio(calle, dpto, numero, piso, idLocalidad) values(@Nomdo, @dept,@num,@piso,@@IDENTITY) select @@IDENTITY insert into Proveedor(nombre, descripcion, telefono, idDomicilo) values(@NomPro,@NomEmp,@tel,@@IDENTITY)";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@NomProv", SqlDbType.VarChar).Value = textProv.Text;
                comando.Parameters.Add("@Nomlo", SqlDbType.VarChar).Value = textLocalidad.Text;
                comando.Parameters.Add("@codP", SqlDbType.VarChar).Value = textCodP.Text;
                comando.Parameters.Add("@Nomdo", SqlDbType.VarChar).Value = textcalle.Text;
                comando.Parameters.Add("@dept", SqlDbType.VarChar).Value = textDepto.Text;
                comando.Parameters.Add("@num", SqlDbType.VarChar).Value = textNro.Text;
                comando.Parameters.Add("@piso", SqlDbType.VarChar).Value = textPiso.Text;
                comando.Parameters.Add("@NomPro", SqlDbType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("@NomEmp", SqlDbType.VarChar).Value = textDesc.Text;
                comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
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
                textDesc.Text = " ";
                textTel.Text = " ";
                Cone.Close();
                cargarGrilla();
            }   
        }

        private void cargarGrilla()
        {
            Cone.Open();
            string sql = "select nombre, telefono from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            tablaProveedores.Rows.Clear();
            while (registros.Read())
            {
                tablaProveedores.Rows.Add(registros["nombre"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Cone.Close();
        }
        bool existeProveedor()
        {
            Cone.Open();
            String sql = " select * from Proveedor where nombre= @nom";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@nom", SqlDbType.Char).Value = textNombre.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Cone.Close();
            return existe;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
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
                Cone.Open();
                string sql = "delete from Proveedor where nombre = @nombre";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.AddWithValue("@nombre", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el Proveedor: " + Insum);
                Cone.Close();
                cargarGrilla();
            }
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
        }
    }
}
