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

namespace BAREST.Configuracion
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void agregarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            String sql = " INSERT INTO Cliente(nombre,apellido,dni,telefono,domicilio,altura,depto,piso) " +
                "values(@nombre,@ape,@dni,@tel,@dom,@altura,@depto,@piso) ";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@ape", SqlDbType.VarChar).Value = textApe.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
            comando.Parameters.Add("@dni", SqlDbType.VarChar).Value = textdni.Text;
            Conexion.ObtenerConexion().Close();
            MessageBox.Show(" se  ha registrado un nuevo cliente");
            textNombre.Text = " ";
            textApe.Text = " ";
            textTel.Text = " ";
            textdni.Text = " ";
            cargarGrilla();
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            String sql = "update Cliente set nombre = @nombre, apellido = @ape, telefono =@tel, dni = @dni , " +
                "domicilio =@dom, altura =  @altura, depto = @depto, piso =@piso";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
            comando.Parameters.Add("@ape", SqlDbType.VarChar).Value = textApe.Text;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = textTel.Text;
            comando.Parameters.Add("@dni", SqlDbType.NChar).Value = textdni.Text;
            Conexion.ObtenerConexion().Close();
            cargarGrilla();

        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            String sql = " delete  from Cliente where nombre=@nombre";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textNombre.Text;
            int cant = comando.ExecuteNonQuery();
            MessageBox.Show("Se eliminó el usuario: " + textNombre.Text);
            Conexion.ObtenerConexion().Close();
            textNombre.Text = " ";
            textApe.Text = " ";
            textTel.Text = " ";
            textdni.Text = " ";
            cargarGrilla();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            Conexion.ObtenerConexion();
            String sql = "select nombre,telefono from Cliente";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "nombre";
                dataGridView1.Columns[1].Name = "tel";
                dataGridView1.Columns["nombre"].HeaderText = "NOMBRE";
                dataGridView1.Columns["tel"].HeaderText = "TELEFONO";
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["telefono"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listadoCliente l = new listadoCliente();
            l.ShowDialog();
        }
    }
}
