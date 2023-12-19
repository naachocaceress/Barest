using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAREST.turno
{
    public partial class Mozo : Form
    {
        public Mozo()
        {
            InitializeComponent();
        }

        private void IngresarMozo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Pedro";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void EliminarInsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void juanfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Juan";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void calebfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Caleb";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void nachofoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Nacho";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void ianfoto_Click(object sender, EventArgs e)
        {
            Mesa1 m = new Mesa1();
            m.labelmozo.Text = "Ian";
            m.labelmesa.Text = label7.Text;

            this.Close();
            m.ShowDialog();
        }

        private void crearComanda()
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Crear una nueva Comanda?", "Nueva Comanda", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    using (SqlCommand comando = new SqlCommand("INSERT INTO [dbo].[Comanda]([mesa],[mozo],[fecha]) VALUES (@mesa, @mozo, GETDATE())", conexion))
                    {
                        Mesa1 m = new Mesa1();
                        comando.Parameters.AddWithValue("mesa", m.labelmesa.Text);
                        comando.Parameters.AddWithValue("@mozo", m.labelmozo.Text);

                        comando.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al eliminar el crear comanda:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Mozo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
