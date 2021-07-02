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
    public partial class Mesa1 : Form
    {
        private SqlConnection Cone = new SqlConnection("Data Source=localhost; Initial Catalog=BaseBarest;Integrated Security=True");

        public Mesa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cone.Open();
            String sql = "insert into provisorio (cantidad, detalles, pUnitario, comensales, mesa, mozo) values (@cant, @det, @puni, @comens, @meza, @mozo)";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Add("@cant", SqlDbType.VarChar).Value = dataGridView1.Rows[0].Cells[0].Value;
            comando.Parameters.Add("@det", SqlDbType.VarChar).Value = dataGridView1.Rows[0].Cells[1].Value;
            comando.Parameters.Add("@puni", SqlDbType.VarChar).Value = dataGridView1.Rows[0].Cells[2].Value;

            comando.Parameters.Add("@comens", SqlDbType.VarChar).Value = textBox3.Text.ToString();
            comando.Parameters.Add("@meza", SqlDbType.VarChar).Value = label4.Text;
            comando.Parameters.Add("@mozo", SqlDbType.VarChar).Value = label5.Text;
            comando.ExecuteNonQuery();
            Cone.Close();
            this.Close();
        }

        public static class ClaseCompartida
        {
            public static int valor=0;
            public static int usu = 0;
            public static int mmm = 0;
            public static string Mesa = "";
            // otras variables estáticas
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
                    cantidad = 1;
                    Cone.Open();
                    string sql = "select nombre,precio from Menu where nombre=@nom";
                    SqlCommand comando = new SqlCommand(sql, Cone);
                    comando.Parameters.Clear();
                    comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
                    SqlDataReader registros = comando.ExecuteReader();
                    if (registros.Read())
                    {
                        dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString(), registros["precio"].ToString()});
                    }
                    registros.Close();
                    Cone.Close();
                    textBox2.Text = "";

                    ClaseCompartida.valor = 1;

                    sumaT();

                    cantidad = 0;
                }
            }
            else
            {
                Cone.Open();
                string sql = "select nombre,precio from Menu where nombre=@nom";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.Clear();
                comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
                SqlDataReader registros = comando.ExecuteReader();
                if (registros.Read())
                {
                    string tt = registros["precio"].ToString();
                    int tt2 = Int32.Parse(tt);
                    int tt3 = cantidad * tt2;
                    string tt4 = tt3.ToString();

                    dataGridView1.Rows.Add(new String[] { cantidad.ToString(), registros["nombre"].ToString(), registros["precio"].ToString(), tt4});
                }
                registros.Close();
                Cone.Close();
                textBox2.Text = "";

                ClaseCompartida.valor = 1;

                sumaT();

                cantidad = 0;
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        public int tot;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string dato = "", dato2 = "";

                dato = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Cantidad"].Value.ToString();

                int num = Int32.Parse(dato);
                tot = num + 1;
                string pep = tot.ToString();

                row.Cells[dataGridView1.CurrentRow.Index].Value = pep;

                //----------------------

                dato2 =  dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["precio"].Value.ToString();

                int num2 = Int32.Parse(dato2);
                int tot2 = num2 * tot;
                string pep2 = tot2.ToString();

                row.Cells["PTotal"].Value = pep2;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string dato = "", dato2 = "";
                dato = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Cantidad"].Value.ToString();
                int num = Int32.Parse(dato);
                int tot = num - 1;

                dato2 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["precio"].Value.ToString();

                int num2 = Int32.Parse(dato2);
                int tot2 = num2 * tot;

                if (tot==0)
                {
                    eliminar();
                }
                else
                {
                    string pep = tot.ToString();
                    row.Cells[dataGridView1.CurrentRow.Index].Value = pep;

                    string pep2 = tot2.ToString();
                    row.Cells["PTotal"].Value = pep2;
                }
            }
        }

        private void Mesa1_Load(object sender, EventArgs e)
        {
            if(ClaseCompartida.mmm==1)
            {
                Cone.Open();
                string sql = "select cantidad, detalles, pUnitario, comensales, mesa, mozo from provisorio where mesa = @nombre";
                SqlCommand comando = new SqlCommand(sql, Cone);
                comando.Parameters.AddWithValue("@nombre", ClaseCompartida.Mesa);
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                {
                    dataGridView1.Rows[0].Cells[0].Value = leido["cantidad"].ToString();
                    dataGridView1.Rows[0].Cells[1].Value = leido["detalles"].ToString();
                    dataGridView1.Rows[0].Cells[2].Value = leido["pUnitario"].ToString();

                    textBox3.Text = leido["comensales"].ToString();
                    label4.Text = leido["mesa"].ToString();
                    label5.Text = leido["mozo"].ToString();
                }
                Cone.Close();

                string dato2 = dataGridView1.Rows[0].Cells["precio"].Value.ToString();
                string dato3 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();

                int num2 = Int32.Parse(dato2);
                int num3 = Int32.Parse(dato3);

                int tot2 = num2 * num3;
                string pep2 = tot2.ToString();

                dataGridView1.Rows[0].Cells["PTotal"].Value = pep2;

                textBox1.Text = pep2;

                ClaseCompartida.mmm = 0;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarMenulista2();

            }
        }
    }
}
