using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAREST;
using System.Data.SqlClient;

namespace BAREST.Turno
{
    public partial class DeliveryMesa : Form
    {
        public DeliveryMesa()
        {
            InitializeComponent();
        }

        public static class ClaseCompartida
        {
            public static bool pagado = false, py = false;
            public static int valor = 0;
        }

            public void iconButton3_Click(object sender, EventArgs e)
        {
            DetallesDeli m = new DetallesDeli();
            if (checkPagado.Checked == true)
                ClaseCompartida.pagado = true;
            if (checkPy.Checked == true)
                ClaseCompartida.py = true;
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            agregarMenulista2();
        }

            public int cantidad = 0;

        private void agregarMenulista2()
        {

            if (cantidad == 0)
            {
                if (textBox2.Text.All(char.IsDigit) && textBox2.Text.Length != 0)
                {
                    int cantN = Int32.Parse(textBox2.Text);
                    cantidad = cantN;
                    textBox2.Text = "";
                }
                else
                {
                   /* cantidad = 1;
                    Conexion.ObtenerConexion();
                    string sql = "select nombre,precio from Menu where nombre=@nom";
                    SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                    comando.Parameters.Clear();
                    comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
                    SqlDataReader registros = comando.ExecuteReader();
                    if (registros.Read())
                    {
                        dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString() });
                    }
                    registros.Close();
                    Conexion.ObtenerConexion().Close();
                    textBox2.Text = "";

                    ClaseCompartida.valor = 1;

                    sumaT();

                    cantidad = 0;*/
                }
            }
            else
            {
                /*Conexion.ObtenerConexion();
                string sql = "select nombre,precio from Menu where nombre=@nom";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.Clear();
                comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
                SqlDataReader registros = comando.ExecuteReader();
                if (registros.Read())
                {
                    string tt = registros["precio"].ToString();
                    int tt2 = Int32.Parse(tt);
                    int tt3 = cantidad * tt2;
                    string tt4 = tt3.ToString();

                    dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString(), tt4 });
                }
                registros.Close();
                Conexion.ObtenerConexion().Close();
                textBox2.Text = "";

                ClaseCompartida.valor = 1;

                cantidad = 0;*/
            }
        }

        private void sumaT()
        {
            int sumatorio = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sumatorio += Convert.ToInt32(row.Cells["PTotal"].Value);
            }

            string hola = sumatorio.ToString();

            textBox1.Text = hola;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            sumaT();
        }

        private void DeliveryMesa_Load(object sender, EventArgs e)
        {
            label4.Text = inicio.ClaseCompartida2.mesaD;
        }
    }
}
