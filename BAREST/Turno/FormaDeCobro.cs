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
    public partial class FormaDeCobro : Form
    {
        public string valor, mesa;

        public FormaDeCobro()
        {
            InitializeComponent();
        }

        private void agregarMenulista_Click(object sender, EventArgs e)
        {
            
            ClaseCompartida.valor = 10;
            if (Convert.ToDouble(textResumen.Text) != 0)
                MessageBox.Show("Tiene que cobrar todo el monto");
            else
            {
                try
                {
                    Conexion.ObtenerConexion();
                    using (var comanda = new SqlCommand())
                    {
                        comanda.Connection = Conexion.ObtenerConexion();
                        comanda.CommandText = "UPDATE Mesa SET estado = @estado,efectivo = @efectivo,transferencia = @transferencia,tarjeta = @tarjeta WHERE mesa = @mesa";

                        comanda.Parameters.AddWithValue("@estado", SqlDbType.VarChar).Value = "C";
                        comanda.Parameters.AddWithValue("@efectivo", SqlDbType.VarChar).Value = textEfectivo.Text;
                        comanda.Parameters.AddWithValue("@transferencia", SqlDbType.VarChar).Value = textTransf.Text;
                        comanda.Parameters.AddWithValue("@tarjeta", SqlDbType.VarChar).Value = textTarjeta.Text;
                        comanda.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = mesa;
                        int rowcount = comanda.ExecuteNonQuery();
                        if (rowcount == 0)
                            throw new Exception("hugo error en  la insercion");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }

        private void FormaDeCobro_Load(object sender, EventArgs e)
        {
            textTotal.Text = valor;
            textResumen.Text = valor;
            textEfectivo.Text = "0";
            textTarjeta.Text = "0";
            textTransf.Text = "0";
        }

        public void Resumen ()
        {
            Double total = 0, efe = 0, tarj = 0, tran = 0, final = 0;

            total = Convert.ToDouble(textTotal.Text);
            efe = Convert.ToDouble(textEfectivo.Text);
            tarj = Convert.ToDouble(textTarjeta.Text);
            tran = Convert.ToDouble(textTransf.Text);

            if (Convert.ToDouble(textResumen.Text) < 0)
                MessageBox.Show("El resumen no debe contener valores negativos");
            else
                final = total - efe - tarj - tran;
            if (final < 0)
                MessageBox.Show("El resumen no debe contener valores negativos");
            else
            {
                string resumen = final.ToString();
                textResumen.Text = resumen;
            }
        }

        private void textEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Resumen();
            }
        }

        private void textTransf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Resumen();
            }
        }

        private void textTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Resumen();
            }
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
