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
            radioButton1.Checked = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
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
                groupBox1.Enabled = true;
            }
            else
            {
                iconButton3.Text = "       Cobro multiple";
                groupBox1.Enabled = false;
            }
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un medio de cobro");
            }
            else
            {
                try
                {
                    Conexion.ObtenerConexion();
                    using (var comanda = new SqlCommand())
                    {
                        comanda.Connection = Conexion.ObtenerConexion();
                        comanda.CommandText = "UPDATE Mesa SET mesa = @mesa1 ,mozo = @mozo ,cantidad = @cantidad ,detalles = @detalles ,precioUnitario = @precioUnitario ,precioTotal = @precioTotal,total = @total,comensal = @comensal,efectivo = @efectivo,transferencia = @transferencia,tarjeta = @tarjeta WHERE mesa = @mesa2 and estado ='A'";

                        comanda.Parameters.AddWithValue("@total", SqlDbType.Float).Value = textTotal.Text;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {

                            comanda.Parameters.Add("@mesa1", SqlDbType.VarChar).Value = labelmesa.Text;
                            comanda.Parameters.Add("@mozo", SqlDbType.VarChar).Value = labelmozo.Text;
                            comanda.Parameters.Add("@comensal", SqlDbType.VarChar).Value = textBox3.Text;
                            comanda.Parameters.Add("@cantidad", SqlDbType.Int).Value = row.Cells["cant"].Value;

                            comanda.Parameters.Add("@detalles", SqlDbType.VarChar).Value = row.Cells["Detalles"].Value;
                            comanda.Parameters.Add("@precioUnitario", SqlDbType.Float).Value = row.Cells["precio"].Value;
                            comanda.Parameters.Add("@precioTotal", SqlDbType.Float).Value = row.Cells["PTotal"].Value;

                            if (radioButton1.Checked == true)
                            {
                                comanda.Parameters.Add("@tarjeta", SqlDbType.Float).Value = row.Cells["PTotal"].Value;
                                comanda.Parameters.Add("@efectivo", SqlDbType.Float).Value = 0;
                                comanda.Parameters.Add("@transferencia", SqlDbType.Float).Value = 0;
                            }
                            else if (radioButton2.Checked == true)
                            {
                                comanda.Parameters.Add("@tarjeta", SqlDbType.Float).Value = 0;
                                comanda.Parameters.Add("@efectivo", SqlDbType.Float).Value = row.Cells["PTotal"].Value;
                                comanda.Parameters.Add("@transferencia", SqlDbType.Float).Value = 0;
                            }
                            else if (radioButton3.Checked == true)
                            {
                                comanda.Parameters.Add("@tarjeta", SqlDbType.Float).Value = 0;
                                comanda.Parameters.Add("@efectivo", SqlDbType.Float).Value = 0;
                                comanda.Parameters.Add("@transferencia", SqlDbType.Float).Value = row.Cells["PTotal"].Value;
                            }
                        }


                        int rowcount = comanda.ExecuteNonQuery();
                        if (rowcount == 0)
                            throw new Exception("hubo error en  la insercion");
                        // comanda.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
