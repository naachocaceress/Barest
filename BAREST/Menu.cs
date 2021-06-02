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

namespace BAREST
{
    public partial class Menu : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void agregarRubro_Click(object sender, EventArgs e)
        {
           if (rubroExist())
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
                string sql = "insert into RubroMenu (descripcion) values (@desRubro)";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
                comando.ExecuteNonQuery();
                textRubro.Text = " ";
                Cone.Close();
                MessageBox.Show("Rubro Registrado");
                cargarRubroM();
               // cargarComboRubro();
            }
            //----------------------------------controlar si existe un rubro-----------------------
             bool rubroExist()
            {
                Cone.Open();
                string sql = "select * from RubroMenu where descripcion=@desRubro";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Add("@desRubro", SqlDbType.VarChar).Value = textRubro.Text;
                bool existe = false;
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                    existe = true;
                Cone.Close();
                return existe;
            }

            //--------------------------------------cargar la tabla------------------------------
            void cargarRubroM()
            {
                Cone.Open();
                string sql = "select descripcion from RubroMenu";
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
                    string sql = "delete from RubroMenu where descripcion = @descripcion";
                    SqlCommand comando = new SqlCommand(sql, Cone);
                    comando.Parameters.AddWithValue("@descripcion", Rubrosd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se eliminó el rubro: " + Rubrosd);
                    Cone.Close();
                    
            }
            }
    }
}
