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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql="insert into Provincia(nombre) values(@nomProv) select @@IDENTITY insert into Localidad(idprovincia, nombre, codigoPostal) values(@@IDENTITY,@Nomlo,@codP) select @@IDENTITY insert into Domicilio(calle, dpto, numero, piso, idLocalidad) values(@Nomdo, @dept,@num,@piso,@@IDENTITY) select @@IDENTITY insert into Proveedor(nombre, descripcion, telefono, idDomicilo) values(@NomPro,@NomEmp,@tel,@@IDENTITY)";
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
            MessageBox.Show("Se ha regitrado el Proveedor " + textNombre.Text + " correctamente");
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
        }

        private void cargarGrilla()
        {
            Cone.Open();
            string sql = "select nombre, telefono from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
