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
        public string arti = "";
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
            if (articuloExiste())
            {
                MessageBox.Show("El insumo ya existe");
                return;
            }

            if (textDescInsumo.Text == "" || textUnidad.Text == "" || textCant.Text == "" || comboRubro.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Falta completar algun campo");
            }
            else
            {
                Cone.Open();
                string sql = "insert into Insumo(descripcion, unidad, cant,idProveedor,idRubro) values(@des,@uni,@cant, @idProv,@idrub)";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@des", SqlDbType.VarChar).Value = textDescInsumo.Text;
                comando.Parameters.Add("@uni", SqlDbType.VarChar).Value = textUnidad.Text;
                comando.Parameters.Add("@cant", SqlDbType.Float).Value = textCant.Text;
                comando.Parameters.Add("@idProv", SqlDbType.Int).Value = comboProveedor.SelectedValue.ToString();
                comando.Parameters.Add("@idrub", SqlDbType.Int).Value = comboRubro.SelectedValue.ToString();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el articulo " + textDescInsumo.Text + " correctamente");
                textDescInsumo.Text = "";
                textUnidad.Text = "";
                textCant.Text = "";
                comboRubro.SelectedItem = null;
                comboProveedor.SelectedItem = null;
                Cone.Close();
                cargarArticulos();
            }
        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
            if (rubroExiste())
            {
                MessageBox.Show("Ya existió un Rubro con este Nombre ");
                return;
            }

            if (textRubro.Text == "")
            {
                MessageBox.Show("Falta agregar nombre de rubro");
            }
            else
            {
                Cone.Open();
                string sql = "insert into Rubro (descripcion) values (@desRubro)";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
                comando.ExecuteNonQuery();
                textRubro.Text = " ";
                Cone.Close();
                MessageBox.Show("Rubro Registrado");
                cargarRubro();
                cargarComboRubro();
                comboRubro.SelectedItem = null;
                comboProveedor.SelectedItem = null;
            }
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

        private bool articuloExiste()
        {
            Cone.Open();
            string sql = "select * from Insumo where descripcion=@desc";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@desc", SqlDbType.Char).Value = textDescInsumo.Text;
            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;
            Cone.Close();
            return existe;
        }

        //-------------------- PARA CARGAR LA GRILLA RUBROS -----------------------------------
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

        private void cargarArticulos()
        {
            Cone.Open();
            string sql = "select descripcion from Insumo";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataReader registros = comando.ExecuteReader();
            tablaArticulos.Rows.Clear();
            while (registros.Read())
            {
                tablaArticulos.Rows.Add(registros["descripcion"].ToString());
            }
            registros.Close();
            Cone.Close();
        }


        private void Insumos_Load(object sender, EventArgs e)
        {
            guardarModifi.Visible = false;
            cargarRubro();
            cargarArticulos();
            cargarComboRubro();
            cargarcomboProveedor();
            comboRubro.SelectedItem = null;
            comboProveedor.SelectedItem = null;
        }

        private void cargarComboRubro()
        {
            Cone.Open();
            string sql = "select id, descripcion from Rubro";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboRubro.DisplayMember = "descripcion";
            comboRubro.ValueMember = "id";
            comboRubro.DataSource = tabla1;
            Cone.Close();
        }

        private void cargarcomboProveedor()
        {
            Cone.Open();
            string sql = "select id, nombre from Proveedor";
            SqlCommand comando = new SqlCommand(sql, Cone);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);
            comboProveedor.DisplayMember = "nombre";
            comboProveedor.ValueMember = "id";
            comboProveedor.DataSource = tabla1;
            Cone.Close();
        }

        private void eliminarRubro_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar Rubros", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Rubrosd = "";
                Rubrosd = tablaRubro.Rows[tablaRubro.CurrentRow.Index].Cells["Rubros"].Value.ToString();
                Cone.Open();
                string sql = "delete from Rubro where descripcion = @descripcion";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.AddWithValue("@descripcion", Rubrosd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el rubro: " + Rubrosd);
                Cone.Close();
                cargarRubro();
                cargarComboRubro();
                comboRubro.SelectedItem = null;
                comboProveedor.SelectedItem = null;
            }
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere borrar?", "Borrar insumos", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string Insum = "";
                Insum = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
                Cone.Open();
                string sql = "delete from Insumo where descripcion = @descripcion";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.AddWithValue("@descripcion", Insum);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se eliminó el Articulo: " + Insum);
                Cone.Close();
                cargarArticulos();
            }
        }

        private void modificarInsu_Click(object sender, EventArgs e)
        {
            string Insum2 = "";
            Insum2 = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Articulos"].Value.ToString();
            Cone.Open();
            string sql = "select descripcion, unidad, cant, idRubro, idProveedor from Insumo where descripcion=@descripcion";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.AddWithValue("@descripcion", Insum2);
            SqlDataReader leido = comando.ExecuteReader();
            if (leido.Read())
            {
                textDescInsumo.Text = leido["descripcion"].ToString();
                textUnidad.Text = leido["unidad"].ToString();
                textCant.Text = leido["cant"].ToString();
                comboRubro.Text = leido["idRubro"].ToString();
                comboProveedor.Text = leido["idProveedor"].ToString();

                arti = textDescInsumo.Text;

            }
            Cone.Close();
            guardarModifi.Visible = true;
        }

        private void guardarModifi_Click(object sender, EventArgs e)
        {
                Cone.Open();
                string sql = "update Insumo set descripcion=@descripcion, unidad=@unidad, cant=@cant where descripcion =@arti";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textDescInsumo.Text;
                comando.Parameters.Add("@unidad", SqlDbType.VarChar).Value = textUnidad.Text;
                comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = textCant.Text;
                //comando.Parameters.Add("@cargo", SqlDbType.VarChar).Value = comboCargo.SelectedItem.ToString();
                comando.Parameters.Add("@arti", SqlDbType.VarChar).Value = arti;
                int cant = comando.ExecuteNonQuery();
                if (cant != 0)
                {
                    MessageBox.Show("Los datos se modificaron correctamente");
                    arti = "";
                    textDescInsumo.Text = "";
                    textUnidad.Text = "";
                    textCant.Text = "";
                comboRubro.SelectedItem = null;
                comboProveedor.SelectedItem = null;
            }   
                Cone.Close();
                cargarArticulos();
                guardarModifi.Visible = false;
        }
    }
}
