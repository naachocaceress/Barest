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
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Insumos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void consultarInsumos_Click(object sender, EventArgs e)
        {
            consultaInsumos m = new consultaInsumos();
            m.ShowDialog();
        }

        private void agregarInsu_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql= "insert into Insumo(descripcion, unidad, cant) values(@des,@uni,@cant)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@des", SqlDbType.VarChar).Value = textDescInsumo.Text;
            comando.Parameters.Add("@uni", SqlDbType.VarChar).Value = comboUnidad.SelectedItem.ToString();
            comando.Parameters.Add("@cant", SqlDbType.Float).Value = textCant.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Registrado el articulo "+ textDescInsumo +" correctamente");
            textDescInsumo.Text = " ";
            comboUnidad.SelectedIndex = 0;
            textCant.Text = " ";
            Cone.Close();
            
        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
            if (rubroExiste())
            {
                MessageBox.Show("Ya existió un Rubro con este Nombre ");
                return;
            }
            Cone.Open();
            string sql = "insert into Rubro (descripcion) values (@desRubro)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
            comando.ExecuteNonQuery();
            textRubro.Text = " ";
            Cone.Close();
            MessageBox.Show("Rubro Registrado");
        }
        //-------------------- PARA VERIFICAR SI EXISTE UN RUBRO -----------------------------------

        private bool rubroExiste()
        {
            Cone.Open();
            string sql = "select * from Rubro where descripcion=@desRubro";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
            bool existe = false;
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
                existe = true;
            Cone.Close();
            return existe;
        }
        //--------------------------------------------------------------------------------

        //-------------------- PARA CARGAR  LA GRILLA -----------------------------------
        private void cargarRubro()
        {
            Cone.Open();
            string sql = "select descripcion from Rubro";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            tablaRubro.Rows.Clear();
            while (registros.Read())
            {
                tablaRubro.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Cone.Close();
        }

        private void Insumos_Load(object sender, EventArgs e)
        {
            cargarRubro();
        }
    }

}
