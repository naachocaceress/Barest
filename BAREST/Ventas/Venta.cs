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

namespace BAREST.Ventas
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buscarMesaBTN_Click(object sender, EventArgs e)
        {
            Wefectivo();
            Wtransf();
            Wtarj();
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " SELECT  mesa ,cantidad ,detalles ,total,efectivo ,transferencia,tarjeta FROM Mesa WHERE mesa like @mesa";
                    comando.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value =textMesa.Text;
                    SqlDataReader leido = comando.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (leido.Read())
                    {
                        dataGridView1.Rows.Add(new String[]{leido["mesa"].ToString(),
                                                        leido["cantidad"].ToString(),
                                                        leido["detalles"].ToString(),
                                                        leido["total"].ToString(),
                                                        leido["efectivo"].ToString(),
                                                        leido["transferencia"].ToString(),
                                                        leido["tarjeta"].ToString()
                                                         });
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void efectivo()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(efectivo) AS efect from Mesa";
                    //comando.Parameters.AddWithValue("@efect", SqlDbType.VarChar).Value = " ";
                    SqlDataReader leido = comando.ExecuteReader();
                    if(leido.Read())
                    {
                        textEfect.Text = leido["efect"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void transf()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(transferencia) AS trans from Mesa";
                    //comando.Parameters.AddWithValue("@efect", SqlDbType.VarChar).Value = " ";
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textTransf.Text = leido["trans"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tarj()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(tarjeta) AS tar from Mesa";
                    //comando.Parameters.AddWithValue("@efect", SqlDbType.VarChar).Value = " ";
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textTarj.Text = leido["tar"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            efectivo();
            transf();
            tarj();
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " SELECT  mesa ,cantidad ,detalles ,total,efectivo ,transferencia,tarjeta FROM Mesa";
                    comando.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = " ";
                    SqlDataReader leido = comando.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (leido.Read())
                    {
                        dataGridView1.Rows.Add(new String[]{leido["mesa"].ToString(),
                                                        leido["cantidad"].ToString(),
                                                        leido["detalles"].ToString(),
                                                        leido["total"].ToString(),
                                                        leido["efectivo"].ToString(),
                                                        leido["transferencia"].ToString(),
                                                        leido["tarjeta"].ToString()
                                                         });
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Wefectivo()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(efectivo) AS efect from Mesa WHERE mesa LIKE @mesa";
                    comando.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = textMesa.Text;
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textEfect.Text = leido["efect"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Wtransf()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(transferencia) AS trans from Mesa WHERE mesa LIKE @mesa";
                    comando.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = textMesa.Text;
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textTransf.Text = leido["trans"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Wtarj()
        {
            try
            {
                Conexion.ObtenerConexion();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = Conexion.ObtenerConexion();
                    comando.CommandText = " select SUM(tarjeta) AS tar from Mesa WHERE mesa LIKE @mesa";
                    comando.Parameters.AddWithValue("@mesa", SqlDbType.VarChar).Value = textMesa.Text;
                    SqlDataReader leido = comando.ExecuteReader();
                    if (leido.Read())
                    {
                        textTarj.Text = leido["tar"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
