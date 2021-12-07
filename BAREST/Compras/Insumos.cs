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
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
        }

        private void consultarInsumos_Click(object sender, EventArgs e)
        {
            consultaInsumos m = new consultaInsumos();
            m.ShowDialog();
        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "insert into Insumo(descripcion, unidad, cant) values(@des,@uni,@cant)";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@des", SqlDbType.VarChar).Value = textDescInsumo.Text;
            comando.Parameters.Add("@uni", SqlDbType.VarChar).Value = comboUnidad.SelectedItem.ToString();
            comando.Parameters.Add("@cant", SqlDbType.Float).Value = textCant.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Registrado el articulo "+ textDescInsumo +" correctamente");
            textDescInsumo.Text = " ";
            comboUnidad.SelectedIndex = 0;
            textCant.Text = " ";
            Conexion.ObtenerConexion().Close();

        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
            if (rubroExiste())
            {
                MessageBox.Show("Ya existió un Rubro con este Nombre ");
                return;
            }
            Conexion.ObtenerConexion();
            string sql = "insert into Rubro (descripcion) values (@desRubro)";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
            comando.ExecuteNonQuery();
            textRubro.Text = " ";
            Conexion.ObtenerConexion().Close();
            MessageBox.Show("Rubro Registrado");
        }
        //-------------------- PARA VERIFICAR SI EXISTE UN RUBRO -----------------------------------

        private bool rubroExiste()
        {
            Conexion.ObtenerConexion();
            string sql = "select * from Rubro where descripcion=@desRubro";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            Conexion.ObtenerConexion().Close();
            return existe;
        }
        //--------------------------------------------------------------------------------

        //-------------------- PARA CARGAR  LA GRILLA -----------------------------------
        private void cargarRubro()
        {
            Conexion.ObtenerConexion();
            string sql = "select descripcion from Rubro";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataReader registros = comando.ExecuteReader();
            tablaRubro.Rows.Clear();
            while (registros.Read())
            {
                tablaRubro.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Conexion.ObtenerConexion().Close();
        }

        private void Insumos_Load(object sender, EventArgs e)
        {
            cargarRubro();
        }

        private void eliminarRubro_Click(object sender, EventArgs e)
        {

        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {

        }
    }

}
