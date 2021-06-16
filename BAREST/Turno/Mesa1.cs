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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Mesa1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        public static class ClaseCompartida
        {
            public static int valor=0;
            public static int usu = 0;
            // otras variables estáticas
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            Cone.Open();
            string sql = "select nombre,precio from Menu where nombre=@nom";
            SqlCommand comando = new SqlCommand(sql, Cone);
            comando.Parameters.Clear();
            comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = textBox2.Text;
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            if (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombre"].ToString(), registros["precio"].ToString());
            }
            registros.Close();
            Cone.Close();

            ClaseCompartida.valor = 1;

            int sumatorio = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sumatorio += Convert.ToInt32(row.Cells["precio"].Value);
            }


            string hola = sumatorio.ToString();

            textBox1.Text = hola;

        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            //string Insum = "";
            //Insum = tablaArticulos.Rows[tablaArticulos.CurrentRow.Index].Cells["Detalles"].Value.ToString();
            //tablaArticulos.Columns.Clear();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
