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
using static BAREST.Mesa1;

namespace BAREST.Turno
{
    public partial class Cobro : Form
    {
        public Cobro()
        {
            InitializeComponent();
        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            if (ClaseCompartida.mmm == 1)
            {
                Conexion.ObtenerConexion();
                string sql = "select top (1) cantidad, detalles, precioUnitario, precioTotal, comensal, mesa, mozo ,total from Mesa  where Mesa = @mesa AND estado ='A' order by mesa desc";
                SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@mesa", ClaseCompartida.Mesa);
                SqlDataReader leido = comando.ExecuteReader();
                if (leido.Read())
                {
                    //llenarTabla();
                    dataGridView1.Rows.Add(new String[]{leido["cantidad"].ToString(),
                                                        leido["detalles"].ToString(),
                                                        leido["precioUnitario"].ToString(),
                                                        leido["precioTotal"].ToString() });
                    textBox3.Text = leido["comensal"].ToString();
                    labelmesa.Text = leido["mesa"].ToString();
                    labelmozo.Text = leido["mozo"].ToString();
                    textTotal.Text = leido["total"].ToString();
                }
                ClaseCompartida.mmm = 0;
                Conexion.ObtenerConexion().Close();
            }

            void llenarTabla()
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "cant";
                dataGridView1.Columns[1].Name = "Detalles";
                dataGridView1.Columns[2].Name = "precio";
                dataGridView1.Columns[2].Name = "PTotal";
                dataGridView1.Columns["Cantidad"].HeaderText = "cant";
                dataGridView1.Columns["Detalles"].HeaderText = "Detalles";
                dataGridView1.Columns["precio"].HeaderText = "precio";
                dataGridView1.Columns["PTotal"].HeaderText = "Total";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //radioButton2.Checked = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (iconButton3.Text == "       Cobro multiple")
            {
                iconButton3.Text = "       Cobro simple";
                //groupBox1.Enabled = true;
            }
            else
            {
                iconButton3.Text = "       Cobro multiple";
                //groupBox1.Enabled = false;
            }
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            FormaDeCobro m = new FormaDeCobro();
            m.valor = textTotal.Text;
            m.mesa = labelmesa.Text;
            m.Show();
            //this.Close();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
