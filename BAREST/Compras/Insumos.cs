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
        void LimpiarCampo()
        {
            textDescInsumo.Text = " ";
            comboUnidad.SelectedIndex = 0;
            textCant.Text = " ";
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }



        private void agregarInsu_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            string sql = "insert into Insumo(descripcion,cantidad, unidad, idrubro,fechaIngreso) values(@des,@cant,@uni,@rubro,@fechaI)";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.Add("@des", SqlDbType.VarChar).Value = textDescInsumo.Text;
            comando.Parameters.Add("@cant", SqlDbType.Int).Value = textCant.Text;
            comando.Parameters.Add("@uni", SqlDbType.VarChar).Value = comboUnidad.SelectedItem.ToString();
            comando.Parameters.Add("rubro", SqlDbType.Int).Value = comboBox1.SelectedIndex.ToString();
            comando.Parameters.Add("@fechaI", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Registrado el articulo "+ textDescInsumo +" correctamente");
            
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
            string sql = "insert into RubroInsumo (descripcion) values (@desRubro)";
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
            string sql = "select * from RubroInsumo where descripcion=@desRubro";
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
            string sql = "select descripcion from RubroInsumo";
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

        void cargartabla()
        {

        }
        public void cargarRubroi()
        {
            Conexion.ObtenerConexion();
            string sql = " SELECT TOP (20) [id],[descripcion] FROM[BARESTNEW].[dbo].[RubroInsumo]";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "descripcion";
            DataRow dataRow = table.NewRow();
            dataRow[0] = 0;
            dataRow[1] = "Select";
            table.Rows.InsertAt(dataRow, 0);
            comboBox1.DataSource = table;
            Conexion.ObtenerConexion().Close();
        }

        private void Insumos_Load(object sender, EventArgs e)
        {
            cargarRubro();
            cargarRubroi();
        }

        private void eliminarRubro_Click(object sender, EventArgs e)
        {

        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
